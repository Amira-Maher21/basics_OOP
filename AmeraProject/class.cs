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
    public partial class classform : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DataClassesTestDataContext dbcontxt = new DataClassesTestDataContext();
        public classform()
        {
            InitializeComponent();
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

            try
            {

                Class cl = new Class();
                cl.ClassDesc = Convert.ToString(classdesctxt.Text);
                cl.ClassIsActive = Convert.ToBoolean(classactiv.Checked);
                dbcontxt.Classes.InsertOnSubmit(cl);
                dbcontxt.SubmitChanges();
                MessageBox.Show("تم الحفظ");

                Clear();
            }
            catch
            {
                MessageBox.Show("لم يتم الحفظ");
                return;

            }
            gridControl1.DataSource = dbcontxt.Classes.ToList();
        }

        private void classform_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = dbcontxt.Classes.ToList();
        }
        private void Clear()
        {
            classdesctxt.Text = "";
            classactiv.Checked = false;
        }
        private void classdesctxt_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void classdesctxt_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void classactiv_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void classactiv_Click(object sender, EventArgs e)
        {

        }
    }
}