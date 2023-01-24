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
    public partial class SwitchTest : DevExpress.XtraEditors.XtraForm
    {
        public string newgr;
        public SwitchTest()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            textEdit1.Text = "";
            string degre = Convert.ToString(textEdit2.Text);


            switch (degre)
            {
                case "10":
                    textEdit1.Text = "اميره";
                    break;

                case "5":
                    textEdit1.Text = "ايمان";
                    break;
            }
        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {
            textEdit1.Text = "";
            switch (newgr)
            {

                case "10":
                    textEdit1.Text = "اميره";
                    break;

                case "5":
                    textEdit1.Text = "ايمان";
                    break;
            }
            


        {

        }
    }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            newgr = Convert.ToString(simpleButton2.Text);

        }

        }
    }