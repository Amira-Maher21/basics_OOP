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
    public partial class classesflagform : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DataClassesTestDataContext dbcontxt = new DataClassesTestDataContext();
        public classesflagform()
        {
            InitializeComponent();
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void teatatchar_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = dbcontxt.ClassesFlags.ToList();
        }

        private void Clear()
        {
            classesflagdesctxt.Text = "";
            classesflagactive.Checked = false;
        }
        private void gridControl1_Click(object sender, EventArgs e)
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
                ClassesFlag fl = new ClassesFlag();
                fl.ClassesFlagDesc = Convert.ToString(classesflagdesctxt.Text);
                fl.ClassesFlagIsActive = Convert.ToBoolean(classesflagactive.Checked);
                dbcontxt.ClassesFlags.InsertOnSubmit(fl);
                dbcontxt.SubmitChanges();
                MessageBox.Show("تم الحفظ");

                Clear();

            }
            catch 
            {

                MessageBox.Show("لم يتم الحفظ");
                return;
            }
            gridControl1.DataSource = dbcontxt.ClassesFlags.ToList();
        }

        private void classesflagdesctxt_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}