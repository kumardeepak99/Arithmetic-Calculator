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
    public partial class DeepakJha : Form
    {
        public DeepakJha()
        {
            InitializeComponent();
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            if (UserName.Text == "Deepak" && Password.Text == "12345")
            {

                MessageBox.Show("Hello Deepak Kumar jha \n Welcome To Our Window Application\n");
             
                var form2 = new AddSub();
              
                UserName.Text = "";
                Password.Text = "";
                this.Hide();
                form2.Show();

            }
            else if (UserName.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Please Fill All Feilds\n");
            }
            else
            {
                MessageBox.Show("Invalid User Name Or Password\n");
            }
        }

        private void DeepakJha_Load(object sender, EventArgs e)
        {
            UserName.Text = "";
            Password.Text = "";
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do You Really Want To Close ??\n");
            this.Close();
        }
    }
}
