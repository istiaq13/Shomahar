using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Shomahar
{
    public partial class firstForm : Form
    {
        public firstForm()
        {
            InitializeComponent();
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }

        private void firstForm_Load(object sender, EventArgs e)
        {
            dataGrid.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            radioButton1.Checked = true;

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            browseForm abc = new browseForm();
            abc.ShowDialog();
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Gray;
        }

        private void supportLabel_MouseHover(object sender, EventArgs e)
        {
            supportLabel.ForeColor = Color.White;
        }

        private void supportLabel_MouseLeave(object sender, EventArgs e)
        {
            supportLabel.ForeColor = Color.Gray;
        }

        private void WishLabel_MouseHover(object sender, EventArgs e)
        {
            WishLabel.ForeColor = Color.White;
        }

        private void WishLabel_MouseLeave(object sender, EventArgs e)
        {
            WishLabel.ForeColor = Color.Gray;
        }

        private void CartLabel_MouseHover(object sender, EventArgs e)
        {
            CartLabel.ForeColor = Color.White;
        }

        private void CartLabel_MouseLeave(object sender, EventArgs e)
        {
            CartLabel.ForeColor= Color.Gray;
        }

        private void supportLabel_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            settingForm abc = new settingForm();
            abc.ShowDialog();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            profileForm abc = new profileForm();
            abc.ShowDialog();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm abc = new loginForm();
            abc.ShowDialog();
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            dataGrid.Show();
            label6.Show();
            label7.Show();
            label8.Show();
            label9.Show();
            label10.Show();
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {

        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            label6.ForeColor = Color.White;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Gray;
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            label7.ForeColor = Color.White;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Gray;
        }

        private void label8_MouseHover(object sender, EventArgs e)
        {
            label8.ForeColor = Color.White;
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.ForeColor = Color.Gray;
        }

        private void label9_MouseHover(object sender, EventArgs e)
        {
            label9.ForeColor = Color.White;
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            label9.ForeColor = Color.Gray;
        }

        private void firstForm_MouseHover(object sender, EventArgs e)
        {
            dataGrid.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
        }

        private void label10_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            oderHistoryForm abc = new oderHistoryForm();
            abc.ShowDialog();
        }

        private void label10_MouseHover(object sender, EventArgs e)
        {
            label10.ForeColor = Color.White;
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            label10.ForeColor = Color.Gray;
        }

        private void WishLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            wishlistForm abc = new wishlistForm();
            abc.ShowDialog();
        }

        private void CartLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            cartForm abc = new cartForm();
            abc.ShowDialog();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView9_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Show();
            pictureBox2.Hide();
            pictureBox3.Hide();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Show();
            pictureBox1.Hide();
            pictureBox3.Hide();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox3.Show();
            pictureBox1.Hide();
            pictureBox2.Hide();
        }
        private void dataGridView10_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            dataGrid.Show();
            label6.Show();
            label7.Show();
            label8.Show();
            label9.Show();
            label10.Show();
        }

        private void firstForm_MouseClick(object sender, MouseEventArgs e)
        {
            dataGrid.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (progressBar1.Value == 5)
            {
               radioButton2.Checked = true;
            }
            if (progressBar1.Value == 10)
            {
                radioButton3.Checked = true;
            }
            if (progressBar1.Value == 15)
            {
                radioButton1.Checked = true;
            }
            if (progressBar1.Value == 20)
            {
                radioButton2.Checked = true;
            }
            if (progressBar1.Value == 25)
            {
                radioButton3.Checked = true;
            }
            if (progressBar1.Value == 30)
            {
                radioButton1.Checked = true;
            }
            if (progressBar1.Value == 35)
            {
                radioButton2.Checked = true;
            }
            if (progressBar1.Value == 40)
            {
                radioButton3.Checked = true;
            }
            if (progressBar1.Value == 45)
            {
                radioButton1.Checked = true;
            }
            if (progressBar1.Value == 50)
            {
                radioButton2.Checked = true;
            }
            if (progressBar1.Value == 55)
            {
                radioButton3.Checked = true;
            }
            if (progressBar1.Value == 60)
            {
                radioButton1.Checked = true;
            }
            if (progressBar1.Value == 65)
            {
                radioButton2.Checked = true;
            }
            if (progressBar1.Value == 70)
            {
                radioButton3.Checked = true;
            }
            if (progressBar1.Value == 75)
            {
                radioButton1.Checked = true;
            }
            if (progressBar1.Value == 80)
            {
                radioButton2.Checked = true;
            }
            if (progressBar1.Value == 85)
            {
                radioButton3.Checked = true;
            }
            if (progressBar1.Value == 90)
            {
                radioButton1.Checked = true;
            }
            if (progressBar1.Value == 95)
            {
                radioButton2.Checked = true;
            }
            if (progressBar1.Value == 100)
            {
                radioButton3.Checked = true;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView14_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
