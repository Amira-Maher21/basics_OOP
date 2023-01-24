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
    public partial class teacherstudentclassesform : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        DataClassesTestDataContext dbcontxt = new DataClassesTestDataContext();
        public bool IsEdite;
        public int Code;
        public DataTable clssdata;
        public DataTable ClassesFlagsdata1;
        public teacherstudentclassesform()
        {
            InitializeComponent();
            CreateGrid();
            CreateGrid2();
        }
        void InsertOrUpdate()
        {
            gridView1.FocusedRowHandle = -1;


            try
            {
                if (IsEdite)
                {

                    //var getdata = dbcontxt.TeacherStudentClassesses.Where(a => a.TeacherStudentClassessId == Code).FirstOrDefault();
                    //getdata.TeatacherId = Convert.ToInt32(searchLookUpteatacher.EditValue);
                    //getdata.ClassId = Convert.ToInt32(searchLookUpEditclass.EditValue);
                    //getdata.StudentId = Convert.ToInt32(searchLookUpEditstudent.EditValue);
                    //getdata.ClassesFlagId = Convert.ToInt32(searchLookUpEditclassesflag.EditValue);
                    //dbcontxt.SubmitChanges();
                    //MessageBox.Show("تم الحفظ");
                    //IsEdite = false;
                    //Clear();
                    //Fill();

                }
                else
                {

                    //TeacherStudentClassess ts = new TeacherStudentClassess();
                    //    ts.TeatacherId = Convert.ToInt32(searchLookUpteatacher.EditValue);
                    //    ts.ClassId = Convert.ToInt32(searchLookUpEditclass.EditValue);
                    //    ts.StudentId = Convert.ToInt32(searchLookUpEditstudent.EditValue);
                    //    ts.ClassesFlagId = Convert.ToInt32(searchLookUpEditclassesflag.EditValue);
                    //    dbcontxt.TeacherStudentClassesses.InsertOnSubmit(ts);
                    //dbcontxt.SubmitChanges();

                }




                clssdata = (DataTable)gridControl1.DataSource;


                foreach (DataRow row in clssdata.Rows)
                {

                    TeacherStudentClassess ts = new TeacherStudentClassess();
                    ts.TeatacherId = Convert.ToInt32(searchLookUpteatacher.EditValue);
                    ts.ClassId = Convert.ToInt32(row["ClassId"]);
                   
                    ts.ClassesFlagId = Convert.ToInt32(row["ClassesFlagId"]);
                    dbcontxt.TeacherStudentClassesses.InsertOnSubmit(ts);
                    dbcontxt.SubmitChanges();
                }


                ClassesFlagsdata1 = (DataTable)gridControl1.DataSource;


                foreach (DataRow row in ClassesFlagsdata1.Rows)
                {

                    TeacherStudentClassess ts = new TeacherStudentClassess();
                    ts.TeatacherId = Convert.ToInt32(searchLookUpteatacher.EditValue);
                    ts.ClassId = Convert.ToInt32(row["ClassId"]);
                   
                    ts.ClassesFlagId = Convert.ToInt32(row["ClassesFlagId"]);
                    dbcontxt.TeacherStudentClassesses.InsertOnSubmit(ts);
                    dbcontxt.SubmitChanges();
                }



                MessageBox.Show("تم الحفظ");
                Clear();
                Fill();
            }
            catch
            {

                MessageBox.Show("لم يتم الحفظ ");
            }
        }

        

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            InsertOrUpdate();
        }
        
        private void teacherstudentclassesform_Load(object sender, EventArgs e)
        {
            Fill();
        }
        void Fill()
        {


            searchLookUpteatacher.Properties.DataSource = dbcontxt.Teatachers.ToList();

               var data = dbcontxt.Classes.ToList();
                gridControl1.DataSource = data;

                var data2 = dbcontxt.ClassesFlags.ToList();
                gridControl2.DataSource = data2;
            

            //var data = (from t in dbcontxt.TeacherStudentClassesses join s in dbcontxt.Teatachers on t.TeatacherId equals s.TeatacherId
            //            join j in dbcontxt.Classes on t .ClassId equals j.ClassId 
            //            join a in dbcontxt. Students  on t.StudentId equals a.StudentId
            //            join c in dbcontxt. ClassesFlags on t.ClassesFlagId equals c.ClassesFlagId
            //            where s.TeacherIsActive==true && j.ClassIsActive==true && a.StudentIsAcive==true && c.ClassesFlagIsActive== true select new {s.TeatacherMame,j.ClassDesc,a.StudentName,c.ClassesFlagDesc }).ToList();
            //gridControl1.DataSource = data;



        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            //Code = Convert.ToInt32(gridView1.GetFocusedRowCellValue("TeacherStudentClassessid"));
            //var getdata = dbcontxt.TeacherStudentClassesses.Where(a => a.TeacherStudentClassessId == Code).FirstOrDefault();

            //searchLookUpteatacher.Text = Convert.ToString(getdata.TeatacherId);
           

            //IsEdite = true;


        }

        public void CreateGrid()
        {
            clssdata = new DataTable();
            clssdata.Columns.Add("ClassId", typeof(int));
            clssdata.Columns.Add("ClassDesc", typeof(string));
            gridControl1.DataSource = clssdata;
          
        }
        public void CreateGrid2()
        {
           
            ClassesFlagsdata1 = new DataTable();
            ClassesFlagsdata1.Columns.Add("ClassesFlagId" , typeof(int));
            ClassesFlagsdata1.Columns.Add("ClassesFlagDesc", typeof(string));
            gridControl2.DataSource = ClassesFlagsdata1;
        }


        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        void Clear()
        {
            searchLookUpteatacher.Text = null;
           

        }
        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            Clear();
        }

        
        
        private void searchLookUpteatacher_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {


           



            //var data = (from t in dbcontxt.TeacherStudentClassesses join s in dbcontxt.Teatachers on t.TeatacherId equals s.TeatacherId
            //            join j in dbcontxt.Classes on t .ClassId equals j.ClassId 
            //            join a in dbcontxt. Students  on t.StudentId equals a.StudentId
            //            join c in dbcontxt. ClassesFlags on t.ClassesFlagId equals c.ClassesFlagId
            //            where s.TeacherIsActive==true && j.ClassIsActive==true && a.StudentIsAcive==true && c.ClassesFlagIsActive== true select new {s.TeatacherMame,j.ClassDesc,a.StudentName,c.ClassesFlagDesc }).ToList();


        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }
    }
}



   
