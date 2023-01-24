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
    public partial class ForForm : DevExpress.XtraEditors.XtraForm
    {
        public ForForm()
        {
            InitializeComponent();
        }
        int s;
        String B;

        int value;
        private void XtraFormTest1_Load(object sender, EventArgs e)
        {

        }

        private void أرق4ام_Click(object sender, EventArgs e)
        {



        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32( textEdit3.EditValue) == 0 || textEdit1.EditValue == null || Convert.ToInt32( textEdit1.EditValue)==0 || textEdit3.EditValue==null ||
                textEdit3.Text=="" || textEdit3.Text==string.Empty)
            {
                MessageBox.Show("من فضلك أدخل البيانات المطلوبة");
                return;
            }
            else
            {
                value = Convert.ToInt32(textEdit3.EditValue);
                //s = Convert.ToInt32(textEdit1.EditValue);
                //MessageBox.Show(s.ToString());
                for (int i = 0; i < value; i++)
                {
                    s = Convert.ToInt32(textEdit1.EditValue);
                    MessageBox.Show(s.ToString());
                }
            }
           
        }



        private void simpleButton2_Click(object sender, EventArgs e)
        {

            if (Convert.ToString( textEdit3.EditValue)=="" || textEdit2.EditValue == null || Convert.ToString(textEdit2.EditValue)== ""|| textEdit3.EditValue==null||
                textEdit3.Text=="" || textEdit3.Text==string.Empty)
            {
                MessageBox.Show("من فضلك أدخل البيانات المطلوبة");
                return;

            }

            else
            {
                value = Convert.ToInt32(textEdit3.EditValue);
                //B = Convert.ToString(textEdit2.Text);
                //MessageBox.Show(B);
                for (int i = 0; i < value; i++)
                {
                    B = Convert.ToString(textEdit2.Text);
                    MessageBox.Show(B);
                }
            }
          
    }


    }
}