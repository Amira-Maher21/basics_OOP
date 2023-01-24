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
    public partial class subjectsform : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DataClassesTestDataContext dbcontxt = new DataClassesTestDataContext();
        public subjectsform()
        {
            InitializeComponent();
        }

        private void اغلاق_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void حفظ_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void subjects_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = dbcontxt.Subjcts.ToList();
               
        }
        private void Clear()
        {
            subjectsNamText.Text = "";
            SubjectActive.Checked = false;
        }

        private void Root_Click(object sender, EventArgs e)
        {

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
              Subjct su = new Subjct();
                su.SubjectDesc = Convert.ToString(subjectsNamText.Text);
                su.SubjectIsActive =Convert.ToBoolean(SubjectActive.Checked);
                dbcontxt.Subjcts.InsertOnSubmit(su);
                dbcontxt.SubmitChanges();
                MessageBox.Show("تم الحفظ");


                Clear();

            }
            catch 
            {
                MessageBox.Show("لم يتم الحفظ");
                return;
                
            }
            gridControl1.DataSource = dbcontxt.Subjcts.ToList();
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}