using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


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


        public void checkUser(string str)
        {
            string user = $@"C:\Users\RC\source\repos\Shomahar\userInfo\{str}.txt";

            if (File.Exists(user))
            {
                string[] users = File.ReadAllLines(user);

                foreach (string u in users)
                {
                    if (u.Contains("un:"))
                    {
                        if (textBox2.Text == u.Remove(0, 3))
                        {
                            foreach (string p in users)
                            {
                                if (p.Contains("pass:"))
                                {
                                    if (textBox1.Text == p.Remove(0, 5))
                                    {
                                        GlobalClass._userName = u.Remove(0, 3);
                                        foreach (string n in users)
                                        {
                                            if (n.Contains("nm:"))
                                            {
                                                GlobalClass._name = n.Remove(0, 3);
                                            }
                                        }
                                        this.Hide();
                                        firstForm abc = new firstForm();
                                        abc.ShowDialog();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Incorrect Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Account does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Account does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            checkUser(textBox2.Text);
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
