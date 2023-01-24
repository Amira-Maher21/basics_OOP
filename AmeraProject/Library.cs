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
    public partial class bookform : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DataClassesTestDataContext dbcontxt = new DataClassesTestDataContext();
        public bool IsEdite;
        public int Code;
        public bookform()
        {
            InitializeComponent();
        }



        void InsertOrUpdate()
        {
            //try
            //{
            //    if (IsEdite)
            //    {

            //        //var getdata = dbcontxt.books.Where(a => a.BookId == Code).FirstOrDefault();
            //        //getdata.BookName = Convert.ToString(textEditName.Text);
            //        //getdata.CategoryId = Convert.ToInt32(searchLookUpEditCategory.Text);
            //    }
            //    else
            //    {
            //        bookform te = new AmeraProject.bookform();

            //        te.bookname = Convert.ToString(textEditName.Text);
            //    }
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            book
            book bo = new AmeraProject.bookform();
            bo.
        }
        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void Library_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click_1(object sender, EventArgs e)
        {

        }
    }
}