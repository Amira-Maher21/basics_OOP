using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace AmeraProject
{
    public partial class InvoiceForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DataClassesTestDataContext dbcontxt = new DataClassesTestDataContext();
        public bool ISEdite;
        public DataTable Invoicedata;
        public InvoiceForm()
        {
            InitializeComponent();
            CreateGrid();
        }

        void InsertOrUpdate()
        {

            //إعطاء الاداتا تيبل الداتا سورس من الجريد
            gridControl1.DataSource = Invoicedata;
            Invoicedata = (DataTable)gridControl1.DataSource;


            try
            {

                // عمل انسيرت للماستر
                InvoiceMaster st = new InvoiceMaster();

                st.DocTypeId = Convert.ToInt32(searchLookUpEdit2.EditValue);
                st.InvoiceDate = Convert.ToDateTime(InvoiceDate.EditValue);
                st.StoreId = Convert.ToInt32(StoreId.EditValue);
                st.StudentId = Convert.ToInt32(StudentId.EditValue);
                st.ClassesFlagId = Convert.ToInt32(searchLookUpEdit1.EditValue);
                st.TeatacherId = Convert.ToInt32(searchLookUpEdit4.EditValue);
                st.MainDiscount = Convert.ToDecimal(MainDiscount.EditValue);
                st.LastFinalTotalDiscount = Convert.ToDecimal(LastFinalTotalDiscount.EditValue);
                st.InvoiceWinValue = Convert.ToDecimal(InvoiceWinValue.EditValue);
                st.InvoiceNetValue2 = Convert.ToDecimal(InvoiceNetValue2.EditValue);
                st.InvoiceNetValueAfterDiscount = Convert.ToDecimal(InvoiceNetValueAfterDiscount.EditValue);
                dbcontxt.InvoiceMasters.InsertOnSubmit(st);
                dbcontxt.SubmitChanges();

                //عمل انسيرت للديتيل
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    //أخذ قيم البروسيدجر من الجريد
                    int id = Convert.ToInt32(gridView1.GetRowCellValue(i, "itemId"));
                    int qty = Convert.ToInt32(gridView1.GetRowCellValue(i, "ItemQuantity"));
                    decimal pri = Convert.ToDecimal(gridView1.GetRowCellValue(i, "Price"));
                    decimal tot = Convert.ToDecimal(gridView1.GetRowCellValue(i, "Total"));
                    //إعطاء البروسيدجر قيم الادخال
                    dbcontxt.InsertInDetail(st.InvoiceId, id,qty,pri,tot);
                    dbcontxt.SubmitChanges();
                }

                MessageBox.Show("تم الحفظ");
            }
            catch 
            {

                MessageBox.Show("لم يتم الحفظ");
            }
               
          
        }



                   


        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            Fill();
        }
        void Fill()
        {
            InvoiceDate.EditValue = DateTime.Now;
            //searchLookUpEdit2.Properties.DataSource = dbcontxt.DocTypes.ToList();
            searchLookUpEdit2.EditValue = 1;
            StoreId.Properties.DataSource = dbcontxt.Stores.ToList();
            searchLookUpEdit1.Properties.DataSource = dbcontxt.ClassesFlags.ToList();
            StudentId.Properties.DataSource = dbcontxt.Students.ToList();
            searchLookUpEdit4.Properties.DataSource = dbcontxt.Teatachers.ToList();

            repositoryItemSearchLookUpEdit1.DataSource = dbcontxt.items.ToList();
           
        }

        private void searchLookUpEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }


        public void CreateGrid()
        {
            //عمل داتا تيبل مع عمل عملية حسابية للاجمالي عن طريق استخدام الاكسيبريشن
            Invoicedata = new DataTable();
            Invoicedata.Columns.Add("itemId", typeof(int));
            Invoicedata.Columns.Add("ItemQuantity", typeof(decimal));
            Invoicedata.Columns.Add("Price", typeof(decimal));
            Invoicedata.Columns.Add("Total", typeof(decimal)).Expression= "ItemQuantity*Price";
            gridControl1.DataSource = Invoicedata;

        }
        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
           
            int id = new int();
            int docid = Convert.ToInt32(searchLookUpEdit2.EditValue);
            //عند إختيار الصنف يتم الدخول الى الايفينت لجلب بيانات الصنف وعمل سيت للجريد فيو حسب نوع الفاتورة
            if (e.Column.FieldName == "itemId")
            {
                id = Convert.ToInt32(gridView1.GetRowCellValue(e.RowHandle, "itemId"));
                //سيليكت لجلب بيانات الصنف
                var data = dbcontxt.items.Where(a => a.itemId == id).FirstOrDefault();
                //عمل سيت للكمية بقيمة ثابته تساوى 1
                gridView1.SetRowCellValue(e.RowHandle, "ItemQuantity",1);
                //عمل سيت للسعر على حسب نوع الفاتورة
                if (docid==1 || docid ==2 || docid == 5 || docid == 6)
                {
                    gridView1.SetRowCellValue(e.RowHandle, "Price", data.itemsllprice);
                }
                else
                {
                    gridView1.SetRowCellValue(e.RowHandle, "Price", data.itembuypirice);
                }
                //لالغاء الرو الفاضي وتجميع الرو اللى فيه الداتا
                gridView1.FocusedRowHandle = -1;
                Claculation();
            }
           
        }

        //عمليه حسابيه
        private void Claculation()
        {
           
            decimal tot = new decimal();
            decimal netval = new decimal();
            decimal dis = new decimal();
            decimal maintot = new decimal();

            for (int i = 0; i < gridView1.RowCount; i++)
            {
                //بيحسب الاجمالي 
                gridView1.FocusedRowHandle = -1;
                tot = Convert.ToDecimal(gridView1.GetRowCellValue(i, "Total"));
                netval = netval + tot;

            }
            //بيحسب الخصومات 
            dis = Convert.ToDecimal(MainDiscount.EditValue);
            if (dis==0 )
            {
                //بيحسب الصافي
                InvoiceNetValueAfterDiscount.EditValue = Convert.ToDecimal(netval);
                InvoiceNetValue2.EditValue = Convert.ToDecimal(netval);
            }
            else
            {
                // الاجمالي =صافي القيمه -الخصم
                maintot = netval - dis;
                InvoiceNetValueAfterDiscount.EditValue = Convert.ToDecimal(netval);
                InvoiceNetValue2.EditValue = 0;
                InvoiceNetValue2.EditValue =Convert.ToDecimal( maintot);
            }
           


        }

        private void MainDiscount_EditValueChanged(object sender, EventArgs e)
        {

        }
        //بركود
        private void MainDiscount_KeyUp(object sender, KeyEventArgs e)
        {
            Claculation();
        }
        int itemId;
        decimal price;
        decimal price2;
        decimal SoldQty;
        private void textEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            // بسمي بركودstring متغير 
            string itemcode = itembarcode.Text;
            //  عشان لو هي فواتير بيع ولا شري عشان اظبط السعر عليها  DOCTAUDبجيب 
            int docid = Convert.ToInt32(searchLookUpEdit2.EditValue);
            //          private void textEdit1_KeyDown(object sender, KeyEventArgs e)          //  حرف ال ء ده  اوبجكت من الزرار ده 

            if (e.KeyCode == Keys.Enter) //  لو ضغط انتر خش نفذلي  البركود ده 
            {
                //لو البركود ف ارقام 
                if (itemcode != null || itemcode != string.Empty || itemcode != "")
                {
                    //   هروح اجيب الداتا بتاعت الصنف الي انا مديت البركود بتاعه من التكست  
                    // بشرط ان البركود الى انا مدخله يكون جاي من الداتا بيز  
                    var data = dbcontxt.items.Where(a => a.Barcode == itemcode).FirstOrDefault();
                    // لو الداتا دي مش فاضيه 
                    if (data != null)
                    {
                        // دول انا عاملهم متغيرات برا عشان اسويهم بالجريد 
                        // هقوله ان الايتم هيساوي لبليتم الي جاي من الداتا بيز وسعر الشري يساوي سعر الشرا الي جاي من الداتا بي ز وسعر البيع يساوي سعر لبيع الي جاي من الداتا بيز والكميه بتساوي 1
                        itemId = Convert.ToInt32(data.itemId);
                        price = Convert.ToDecimal(data.itemsllprice);
                        price2 = Convert.ToDecimal(data.itembuypirice);
                        SoldQty = 1;
                        // بدي الفلاج  بتاع الفاتوره  
                        if (docid == 1 || docid == 2 || docid == 5 || docid == 6)
                        {
                            // لو الفواتير دي بيع 
                            gridControl1.DataSource =
                            // بضيف ف الفاتوره الايتم وسعر الشرا والكميه 
                            //itemId يعني نوع 
                            Invoicedata.Rows.Add(itemId, price, SoldQty);
                            // بخلي لبركود ب NULL
                            itembarcode.Text = "";
                            // ف البركود Focusبحط  
                            itembarcode.Focus();
                            // بعمل العمليات الحسابيه بتاعتي 
                            Claculation();
                        }
                        else

                           
                        {
                            // لو الفواتير شرا 
                            gridControl1.DataSource =
                                // بضيف ف الفاتوره الايتم وسعر الشرا والكميه 
                            Invoicedata.Rows.Add(itemId, price2, SoldQty);
                            // بخلي البركود ب NLL
                            itembarcode.Text = "";
                            // ف البركود Focusبحط  

                            itembarcode.Focus();
                            // بعمل العمليات الحسابيه بتاعتي 

                            Claculation();
                        }

                    }
                    else
                    {
                        XtraMessageBox.Show("لايوجد صنف بهذا الرقم  الباركود خاطئ");
                        itembarcode.Text = null;
                        itembarcode.Focus();
                    }

                }
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            InsertOrUpdate();
        }

        private void itembarcode_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void InvoiceNetValue2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void searchLookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}