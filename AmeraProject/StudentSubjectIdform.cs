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

namespace AmeraProject
{
    public partial class StudentSubjectIdform : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DataClassesTestDataContext dbcontxt = new DataClassesTestDataContext();
        public bool ISEdite;
        public int COde;
        //عمل داتا تيبل
        public DataTable Subjectdata ;

        public StudentSubjectIdform()
        {
            InitializeComponent();
            CreateGrid();
        }
        void InsertOrUpdate()
        {
            gridView1.FocusedRowHandle = -1;
            try
            {
                if (ISEdite)
                {
                    //var getdata = dbcontxt.StudentSubjects.Where(a => a.StudentSubjectId == COde).FirstOrDefault();
                    //getdata.StudentId = Convert.ToInt32(searchLookUpEditstudent.EditValue);
                    //getdata.SubjectId =Convert.ToInt32(searchLookUpEditsubject.EditValue);
                    //dbcontxt.SubmitChanges();
                    //MessageBox.Show("تم الحفظ");
                    //ISEdite = false;
                    //CIear();
                    //fill();
               
                }
                else
                {



                    //st.StudentId = Convert.ToInt32(searchLookUpEditstudent.EditValue);
                    //st.SubjectId = Convert.ToInt32(searchLookUpEditsubject.EditValue);


                    //for (int i = 0; i < gridView1.RowCount; i++)
                    //{
                    //    dbcontxt.InsertStudentSubject(Convert.ToInt32(searchLookUpEditstudent.EditValue), Convert.ToInt32(gridView1.GetRowCellValue(i, "SubjectId")));

                    //    dbcontxt.SubmitChanges();
                    //}

                    //حفظ الديتيل عن طريق فور ايتش وداتا تيبل
                    Subjectdata = (DataTable)gridControl1.DataSource;
                    
                        
                        foreach (DataRow row in Subjectdata.Rows)
                        {
                            StudentSubject st = new StudentSubject();
                            st.StudentId = Convert.ToInt32(searchLookUpEditstudent.EditValue);
                            st.SubjectId = Convert.ToInt32(row["SubjectId"]);
                         
                            dbcontxt.StudentSubjects.InsertOnSubmit(st);
                            dbcontxt.SubmitChanges();
                        }
                    
                    


                    MessageBox.Show("تم الحفظ");
                    CIear();
                    fill();
                }
            }
            catch 
            {
                MessageBox.Show("لم يتم الحفظ");
            }
        }
        
       void  CIear ()
        {
            searchLookUpEditstudent.Text = null;
          

        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            InsertOrUpdate();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            CIear();
        }

        private void StudentSubjectIdform_Load(object sender, EventArgs e)
        {
            fill();
        }
        void fill()
        {
            searchLookUpEditstudent.Properties.DataSource = dbcontxt.Students.ToList();

          

            //searchLookUpEditsubject.Properties.DataSource = dbcontxt.Subjcts.ToList();
            // إعطاء الريبوريزاتري الداتا سورس
            repositoryItemSearchLookUpEdit1.DataSource= dbcontxt.Subjcts.ToList();

            //var data = (from t in dbcontxt.StudentSubjects
            //            join s in dbcontxt.Students on t.StudentId equals s.StudentId
            //            join r in dbcontxt.Subjcts on t.SubjectId equals r.SubjectId
            //            where s.StudentIsAcive == true && r.SubjectIsActive == true
            //            select new {t.StudentSubjectId, s.StudentName, r.SubjectDesc }).ToList();
            //gridControl1.DataSource = data;

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }     
        
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            COde = Convert.ToInt32(gridView1.GetFocusedRowCellValue("StudentSubjectId"));

            var getdata = dbcontxt.StudentSubjects.Where(a => a.StudentSubjectId == COde).FirstOrDefault();
            searchLookUpEditstudent.EditValue = Convert.ToInt32(getdata.StudentId);

            ISEdite = true;
        }

        //عمل الداتا تيبل وإعطاء الجريد كنترول الداتا سورس من الداتا تيبل
        public void CreateGrid()
        {

            Subjectdata = new DataTable();
            Subjectdata.Columns.Add("StudentSubjectId", typeof(int));
            Subjectdata.Columns.Add("SubjectId",typeof(int));
            gridControl1.DataSource = Subjectdata;
        }

        //أخذ القيمة الجديده من السيرش لوك اب ايديت وجلب الداتا عن طؤيق سيليكت بداخله ليست وإعطاء الجريد كنترول الداتا سورس من الليست
        private void searchLookUpEditstudent_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            int id = Convert.ToInt32(e.NewValue);

            var getdata=dbcontxt.StudentSubjects.Where(a=>a.StudentId==id).ToList();

            gridControl1.DataSource = getdata;

            

            }  

        private void searchLookUpEditsubject_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void searchLookUpEditstudent_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }
    }
}