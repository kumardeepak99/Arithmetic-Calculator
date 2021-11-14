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
    public partial class Sub : Form
    {
        public Sub()
        {
            InitializeComponent();
        }

        private void GotToLoginPage_Click(object sender, EventArgs e)
        {
            var form2 = new DeepakJha();
            //  this.Hide();
            this.Close();
            form2.Show();
        }

        private void GoToAddSub_Click(object sender, EventArgs e)
        {
            var form2 = new AddSub();
            //  this.Hide();
            this.Close();
            form2.Show();
        }

        private void GetSubVal_Click(object sender, EventArgs e)
        {
            if (SNum1.Text == "" || SNum2.Text == "")
            {
                MessageBox.Show("Please Fill Both Feilds");
            }
            else
            {
                int x = 0;

                Int32.TryParse(SNum1.Text, out x);
                int y = 0;
                Int32.TryParse(SNum2.Text, out y);

                int z = x - y;
                SubVal.Text = z.ToString();
            }
        }
    }
}
