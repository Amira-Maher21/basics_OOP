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
    public partial class                                                                                                                                                                                                                                                                                                                                                                                                                  TeacherForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        DataClassesTestDataContext dbcontxt = new DataClassesTestDataContext();
        public bool IsEdite;
        public int Code;
        public TeacherForm()
        {
            InitializeComponent();
        }


        void InsertOrUpdate()
        {
            try
            {

                // كود التعديل
                if (IsEdite)
                {
                    var getdata = dbcontxt.Teatachers.Where(a => a.TeatacherId == Code).FirstOrDefault();
                    getdata.TeatacherMame = Convert.ToString(textEditName.Text);
                    getdata.TeacherBirthdate = Convert.ToDateTime(dateEditBirthdate.Text);
                    getdata.TeacherSalary = Convert.ToDecimal(textEditSalary.EditValue);
                    getdata.SubjectId = Convert.ToInt32(searchLookUpEditSubject.EditValue);
                    getdata.JobId = Convert.ToInt32(searchLookUpEditJob.EditValue);
                    getdata.Teacherphone = Convert.ToString(textEditPhone.Text);
                    getdata.TeacherIsActive = Convert.ToBoolean(checkEditIsActive.Checked);
                    dbcontxt.SubmitChanges();
                    MessageBox.Show("تم الحفظ");
                    IsEdite = false;
                    Clear();
                    Fill();
                }
                else
                {
                    // كود الحفظ
                    Teatacher te = new AmeraProject.Teatacher();

                    te.TeatacherMame = Convert.ToString(textEditName.Text);
                    te.TeacherBirthdate = Convert.ToDateTime(dateEditBirthdate.Text);
                    te.TeacherSalary = Convert.ToDecimal(textEditSalary.EditValue);
                    te.SubjectId = Convert.ToInt32(searchLookUpEditSubject.EditValue);
                    te.JobId = Convert.ToInt32(searchLookUpEditJob.EditValue);
                    te.Teacherphone = Convert.ToString(textEditPhone.Text);
                    te.TeacherIsActive = Convert.ToBoolean(checkEditIsActive.Checked);
                    dbcontxt.Teatachers.InsertOnSubmit(te);
                    dbcontxt.SubmitChanges();
                    MessageBox.Show("تم الحفظ");
                    
                    Clear();
                    Fill();
                }
                
               
            }
            catch
            {

                MessageBox.Show("لم يتم الحفظ ");
            }
        }
        void Clear()
        {
            // كود جديد
            textEditName.Text = "";
            dateEditBirthdate.EditValue = null;
            textEditSalary.Text = "0";
            searchLookUpEditSubject.EditValue = null;
            searchLookUpEditJob.EditValue = null;
            textEditPhone.Text = "";
            checkEditIsActive.Checked = false;

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            InsertOrUpdate();
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            Fill();
        }

        void Fill()
        {
            //إعطاء السيرش لووك أب إيديت الداتا سورس
            searchLookUpEditSubject.Properties.DataSource = dbcontxt.Subjcts.ToList();

            searchLookUpEditJob.Properties.DataSource = dbcontxt.Jobs.ToList();
            //gridControl1.DataSource = dbcontxt.Teatachers.ToList();
            //عمل جملة سيليكت لإعطاء الجريد كنترول الداتا سورس
            var data = (from t in dbcontxt.Teatachers join s in dbcontxt.Subjcts on t.SubjectId equals s.SubjectId
                        join j in dbcontxt.Jobs on t.JobId equals j.JobId
                        where s.SubjectIsActive==true && j.JobIsactive== true select new {t.TeatacherId,t.TeatacherMame,t.TeacherBirthdate,t.TeacherSalary,s.SubjectDesc,j.JobDese,t.Teacherphone }).ToList();
            gridControl1.DataSource = data;
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            Clear();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {

            //لعمل تعديل على الداتا
            //عند الضغط مرتين على الصف يأخذ رقم المدرس ويأتي بالداتا المطلوبة من الداتا بيز
            Code = Convert.ToInt32(gridView1.GetFocusedRowCellValue("TeatacherId"));

            var getdata = dbcontxt.Teatachers.Where(a => a.TeatacherId == Code).FirstOrDefault();

            textEditName.Text = Convert.ToString( getdata.TeatacherMame);
            dateEditBirthdate.EditValue = Convert.ToDateTime( getdata.TeacherBirthdate);
            textEditSalary.EditValue = Convert.ToDecimal(getdata.TeacherSalary);
            searchLookUpEditSubject.EditValue = Convert.ToInt32(getdata.SubjectId);
            searchLookUpEditJob.EditValue = Convert.ToInt32(getdata.JobId);
            textEditPhone.Text = Convert.ToString(getdata.Teacherphone);
            checkEditIsActive.Checked = Convert.ToBoolean(getdata.TeacherIsActive);

            IsEdite = true;                                                                                                                                                                                                                                                                

        }

        private void ribbon_Click(object sender, EventArgs e)
        {
                                                                                                                                                                                                                                                                                                                                                                                 
        }

        private void textEditPhone_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}