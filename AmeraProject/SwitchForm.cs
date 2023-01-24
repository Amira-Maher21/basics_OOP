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
    public partial class SwitchForm : DevExpress.XtraEditors.XtraForm
    {

        public string grade;
        public string newgr;
        public SwitchForm()
        {
            InitializeComponent();

        }

        private void SwitchForm_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            textEdit1.Text = "";
            string degree = Convert.ToString(textEdit8.Text);

            switch (degree)
            {
                case "95":
                    textEdit1.Text = "ممتاز";
                    break;
                case "85":
                    textEdit1.Text = "جيد جدا";
                    break;
                case "75":
                    textEdit1.Text = "جيد مرتفع";
                    break;
                case "65":
                    textEdit1.Text = "جيد ";
                    break;
                case "55":
                    textEdit1.Text = "مقبول";
                    break;
                case "50":
                    textEdit1.Text = "ضعيف";
                    break;
                default:
                    break;
            }


        }


        private void switchgradee()
        {
            textEdit2.Text = "";
            switch (grade)
            {
                case "95":
                    textEdit2.Text = "ممتاز";
                    break;
                case "85":
                    textEdit2.Text = "جيد جدا";
                    break;
                case "75":
                    textEdit2.Text = "جيد مرتفع";
                    break;
                case "65":
                    textEdit2.Text = "جيد ";
                    break;
                case "55":
                    textEdit2.Text = "مقبول";
                    break;
                case "50":
                    textEdit2.Text = "ضعيف";
                    break;
                case "45":
                    textEdit2.Text = "لم ينجح";
                    break;
                default:
                    break;
                
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            grade = "";
            grade = Convert.ToString(simpleButton2.Text);
            switchgradee();
            
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            grade = "";
            grade = Convert.ToString(simpleButton7.Text);
            switchgradee();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            grade = "";
            grade = Convert.ToString(simpleButton6.Text);
            switchgradee();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            grade = "";
            grade = Convert.ToString(simpleButton5.Text);
            switchgradee();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            grade = "";
            grade = Convert.ToString(simpleButton4.Text);
            switchgradee();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            grade = "";
            grade = Convert.ToString(simpleButton3.Text);
            switchgradee();
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

 

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            textEdit4.Text = "";
            string degree = Convert.ToString(textEdit3.Text);
            switch (degree)

            {
                case "95":
                    textEdit4.Text = "ممتاز";
                    break;

                case "90":
                    textEdit4.Text = "[جيدجدا";
                    break;
                default:
                    break;



            }
            
            
                 
            

        }

        private void textEdit4_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit5_EditValueChanged(object sender, EventArgs e)
        {
 
        }

        private void switchnewval()
        {
            textEdit5.Text = "";
            switch (newgr)
            {
                case "95":
                    textEdit5.Text = "ممتاز";
                    break;

                case "85":
                    textEdit5.Text = "[جيدجدا";
                    break;
                default:
                    break; 
            }
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            newgr = Convert.ToString(simpleButton9.Text);

            switchnewval();


        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {

            newgr = Convert.ToString(simpleButton10.Text);

            switchnewval();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}