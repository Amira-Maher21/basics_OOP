using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace AmeraProject
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Student_Click(object sender, EventArgs e)
        {
            StudentForm st = new StudentForm();
            st.ShowDialog();
        }

        private void Teacher_Click(object sender, EventArgs e)
        {
            TeacherForm te = new AmeraProject.TeacherForm();
            te.ShowDialog();
        }

        private void Subject_Click(object sender, EventArgs e)
        {
            subjectsform sb = new subjectsform();
            sb.ShowDialog();
        }

        private void Class_Click(object sender, EventArgs e)
        {
            classform cl = new AmeraProject.classform();
            cl.ShowDialog();
        }

        private void ClassFlag_Click(object sender, EventArgs e)
        {
            classesflagform clf = new AmeraProject.classesflagform();
            clf.ShowDialog();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            teacherstudentclassesform cif = new AmeraProject.teacherstudentclassesform();
            cif.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            StudentSubjectIdform cif = new AmeraProject.StudentSubjectIdform();
            cif.ShowDialog();
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            InvoiceForm cif = new InvoiceForm();
            cif.ShowDialog();
        }
    }
}