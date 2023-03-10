using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Shomahar
{
    public partial class forgetPassForm : Form
    {
        public forgetPassForm()
        {
            InitializeComponent();
        }

        private void forgetPassForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm abc = new loginForm();
            abc.ShowDialog();
        }
    }
}
