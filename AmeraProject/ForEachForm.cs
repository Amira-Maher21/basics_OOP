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
    public partial class ForEachForm : DevExpress.XtraEditors.XtraForm
    {
        public ForEachForm()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string[] names = { "احمد", "محمد", "علي", "عزيز", "Ahmed", "Elsayed", "Amera", "Wael" };
            List<string> name= new List<string>();
            name.Add("ali");
            foreach (string n in names)
            {
                comboBox1.Items.Add(n);

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
           int  [] nambrs= { 1, 4, 5, 8, 6, 3, 5 };
            foreach (int n in nambrs)
            {
                comboBox2.Items.Add(n);
                
            }
           

          
              
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
         double [] many ={ 2.5,4.1,8.6};
            foreach (decimal n in many)
            {
                comboBox3.Items.Add(n);
            }
                
        }

        private void ForEachForm_Load(object sender, EventArgs e)
        {
          
           


        }


        private void simpleButton4_Click(object sender, EventArgs e)
        {

            DateTime[] dateTimes1 = new DateTime[]
   {

        new DateTime(2010, 10, 1, 8, 15, 0),
        new DateTime(2010, 10, 1, 8, 30, 1),
        new DateTime(2010, 10, 1, 8, 45, 2),
        new DateTime(2010, 10, 1, 9, 15, 3),
        new DateTime(2010, 10, 1, 9, 30, 4),
        new DateTime(2010, 10, 1, 9, 45, 5),
        new DateTime(2010, 10, 1, 10, 15, 6),
        new DateTime(2010, 10, 1, 10, 30, 7)

   };
            foreach (DateTime n in dateTimes1)
                comboBox4.Items.Add(n);

        }
    }
}