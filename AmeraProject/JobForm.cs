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
    public partial class JobForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DataClassesTestDataContext dbcontxt = new DataClassesTestDataContext();
        public JobForm()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Job jo = new Job();
                jo.JobDese = Convert.ToString(JobDescTxt.Text);
                jo.JobIsactive = Convert.ToBoolean(JobActive.Checked);
                dbcontxt.Jobs.InsertOnSubmit(jo);
                dbcontxt.SubmitChanges();
                MessageBox.Show("تم الحفظ");

                Clear();
            }
            catch 
            {
                MessageBox.Show("لم يتم الحفظ");    
                return;

            }
           
            gridControl1.DataSource = dbcontxt.Jobs.ToList();
        }

        private void JobForm_Load(object sender, EventArgs e)
        {     
            gridControl1.DataSource = dbcontxt.Jobs.ToList();
          
        }

        private void Clear()
        {
            JobDescTxt.Text = "";
            JobActive.Checked = false;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
           
        }

        private void gridControl1_Click_1(object sender, EventArgs e)
        {

        }

        private void JobActive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void JobDescTxt_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}