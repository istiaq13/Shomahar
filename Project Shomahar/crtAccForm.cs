using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Shomahar
{
    public partial class crtAccForm : Form
    {
        public crtAccForm()
        {
            InitializeComponent();
        }

        private void crtAccForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm abc = new loginForm();
            abc.ShowDialog();
        }

        private void numTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserNametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.ForeColor = Color.DodgerBlue;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor= Color.White;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Make Sure You Have A Stable Internet Connection");
            System.Diagnostics.Process.Start("https://storage.googleapis.com/simg-memechat/9B1E9MUaWnD8olMBJILmsJmCyl5SfZ2695876.jpg");
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        public void regUser(string str)
        {
            string newUser = $@"C:\Users\RC\source\repos\Shomahar\userInfo\{str}.txt";

            using (StreamWriter writer = new StreamWriter(newUser))
            {
                writer.Write("un:" + numTextBox.Text);
                writer.Write('\n');
                if (UserNametextBox.Text.Length >= 6)
                {
                    if (UserNametextBox.Text == passTextBox.Text)
                    {
                        writer.Write("pass:" + UserNametextBox.Text);
                        writer.Write('\n');
                    }
                    else
                    {
                        MessageBox.Show("Passwords do not Match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Password must be at least 6 characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                writer.Write("nm:" + numTextBox.Text);
                writer.Write('\n');
            }
            }


            private void newAccBtn_Click(object sender, EventArgs e)
        {
            if (UserNametextBox.Text.Length >= 6)
            {

                if (UserNametextBox.Text == passTextBox.Text)
                {
                    regUser(numTextBox.Text);
                    user _temp = new user(numTextBox.Text, UserNametextBox.Text, FnameTextBox.Text);
                    MessageBox.Show("Account successfully created!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form1 abc = new Form1();
                    abc.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Passwords do not Match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("Password must be at least 6 characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
