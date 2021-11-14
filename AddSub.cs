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
    public partial class AddSub : Form
    {
        public AddSub()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            var form2 = new DeepakJha();
            this.Close();
            form2.Show();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            var form2 = new Add();
            this.Close();
            form2.Show();
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            var form2 = new Sub();
      
            this.Close();
            form2.Show();
        }
    }
}
