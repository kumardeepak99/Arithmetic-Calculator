using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindApp
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void LoginPage_Click(object sender, EventArgs e)
        {
            var form2 = new DeepakJha();
            //  this.Hide();
            this.Close();
            form2.Show();
        }

        private void BackToAddSum_Click(object sender, EventArgs e)
        {
            var form2 = new AddSub();
            //  this.Hide();
            this.Close();
            form2.Show();
        }

        private void GetSumVal_Click(object sender, EventArgs e)
        {
            if (ANum1.Text == "" || ANum2.Text == "")
            {
                MessageBox.Show("Please Fill Both Feilds");
            }
            else
            {
                int x = 0;

                Int32.TryParse(ANum1.Text, out x);
                int y = 0;
                Int32.TryParse(ANum2.Text, out y);

                int z = x + y;
                Sumval.Text = z.ToString();
            }
        }
    }
}
