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
    public partial class StudentForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DataClassesTestDataContext dbcontxt = new DataClassesTestDataContext();
        public StudentForm()
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

        private void requesterDescTxt_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)


        {
            try
            {
                Student st = new Student();

                st.StudentName = Convert.ToString(StudentNamText.Text);
                st.StudentIsAcive = Convert.ToBoolean(checkEditIsActive.Checked);
                st.StudentAddress = Convert.ToString(StudentAdresText.Text);
                dbcontxt.Students.InsertOnSubmit(st);
                dbcontxt.SubmitChanges();
                MessageBox.Show("تم الحفظ");
                gridControl1.DataSource = dbcontxt.Students.ToList();
                clear();
            }
            catch 
            {

                MessageBox.Show("لم يتم الحفظ ");
            }


        

        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = dbcontxt.Students.ToList();
        }



        private void clear()
        {

            StudentNamText.Text = "";
            StudentAdresText.Text = "";
            checkEditIsActive.Checked = false;
            

        }

        private void StudentAdresText_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void checkEditIsActive_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
