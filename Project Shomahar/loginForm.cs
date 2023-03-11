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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            loginbtn.Focus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            forgetPassForm abc = new forgetPassForm();
            abc.ShowDialog();
        }

        private void signupLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            crtAccForm abc = new crtAccForm();
            abc.ShowDialog();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            
            firstForm abc = new firstForm();
            abc.ShowDialog();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fpassLabel_MouseHover(object sender, EventArgs e)
        {
            fpassLabel.ForeColor= Color.DodgerBlue;
        }

        private void fpassLabel_MouseLeave(object sender, EventArgs e)
        {
            fpassLabel.ForeColor= Color.White;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
