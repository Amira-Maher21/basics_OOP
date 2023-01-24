using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AmeraProject
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        int a;
        string b;

        int value;
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            value = Convert.ToInt32(textEdit3.EditValue);
            //a =Convert.ToInt32( textEdit1.EditValue);
            //MessageBox.Show(a.ToString());
            for (int i =0; i < value; i++)
            {
                
                a = Convert.ToInt32(textEdit1.EditValue);
                MessageBox.Show(a.ToString());
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            value = Convert.ToInt32(textEdit3.EditValue);
            //b = Convert.ToString(textEdit2.Text);
            //MessageBox.Show(b);
            for (int i =0; i < value; i++)
            {
                b = Convert.ToString(textEdit2.Text);
                MessageBox.Show(b);
            }

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
           
            {

            }
        }
    }
}
