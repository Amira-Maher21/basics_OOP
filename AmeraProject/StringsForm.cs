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
    public partial class StringsForm : DevExpress.XtraEditors.XtraForm
    {
        public StringsForm()
        {
            InitializeComponent();
        }

        private void simpleButtonLength_Click(object sender, EventArgs e)
        {
            string txtlength;
            txtlength = Convert.ToString(textEditCardId.Text);

            textEditLength.Text = Convert.ToString(txtlength.Length);



        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            string txtlength;
            txtlength = Convert.ToString(textEditCardId.Text);
            textEditLower.Text = Convert.ToString(txtlength.ToUpper());
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            string txtlength;
            txtlength = Convert.ToString(textEditCardId.Text);
            textEditUpper.Text = Convert.ToString(txtlength.ToLower());
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {

            string Num;
            string name;

            Num = Convert.ToString(textEditCardId.Text);
            name = Convert.ToString(textEditName.Text);

            textEditNameandNum.Text = Num + " \t  " + name;


        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            string Num;
            Num = Convert.ToString(textEditCardId.Text);
            char a = Convert.ToChar(2);
            char b = Convert.ToChar(7);

            char[] charsToTrim = { '*', '.' };

            textEditTrimtext.Text = Num.Trim(charsToTrim);
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {

            string idNumber;
            Byte id=6;
            string flag = "2";
            idNumber = Convert.ToString(textEditCardId.Text);
            //string Year = idNumber.Remove(0, 1);
            //string month = idNumber.Remove(0,3);
            string day = idNumber.Remove(0,flag.Length).Substring(id);
            textEditDateOfBirth.Text = day;

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            string idNumber;
            idNumber = Convert.ToString(textEditCardId.Text);
            string num = idNumber.Remove(0, 3);
            texteditcardnumber.Text = num;
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {

            string code;
            code = Convert.ToString(textEditCardId.Text);
            string numes = code.Remove(0, 1);
            textEditegypt.Text = numes;

        }

        private void textEditegypt_EditValueChanged(object sender, EventArgs e)
        {



        }

        private void texteditcardnumber_EditValueChanged(object sender, EventArgs e)
        {


        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void mkm_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string number;
            string name;
            
            number = Convert.ToString(textEditCardId.Text);
            name = Convert.ToString(textEditName.Text);

            texteditcardnumber2.Text = number + "        " + name;


            



        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {

        }

        private void textEditNameandNum_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
    
}










   
   