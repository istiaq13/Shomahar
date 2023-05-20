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
        public static int bookid;
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
            dataGridView10.Hide();
            dataGrid.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label161.Hide();
            label171.Hide();
            label162.Hide();
            pictureBox161.Hide();
            pictureBox171.Hide();

            cartDotLabel.Hide();
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
            MessageBox.Show("Not Available Right Now!");
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Logged in as : {GlobalClass._userName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show("Not Available Right Now!");
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
            bookid = 2;
            bookPopUp abc = new bookPopUp();
            abc.ShowDialog();
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView14_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            bookid = 1;
            bookPopUp abc = new bookPopUp();
            abc.ShowDialog();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            bookid = 5;
            bookPopUp abc = new bookPopUp();
            abc.ShowDialog();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            bookid = 3;
            bookPopUp abc = new bookPopUp();
            abc.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            bookid = 4;
            bookPopUp abc = new bookPopUp();
            abc.ShowDialog();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            bookid = 6;
            bookPopUp abc = new bookPopUp();
            abc.ShowDialog();
           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            bookid = 7;
            bookPopUp abc = new bookPopUp();
            abc.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            bookid = 8;
            bookPopUp abc = new bookPopUp();
            abc.ShowDialog();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            bookid = 9;
            bookPopUp abc = new bookPopUp();
            abc.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            bookid = 10;
            bookPopUp abc = new bookPopUp();
            abc.ShowDialog();
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=XwUAxv9jDds");
        }

        private void label36_MouseHover(object sender, EventArgs e)
        {
            label36.ForeColor = Color.LawnGreen;
        }

        private void label36_MouseLeave(object sender, EventArgs e)
        {
            label36.ForeColor = Color.Lavender;
        }

        private void dataGridView17_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {
           
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            MessageBox.Show("                  Added To Wishlist.                ");
        }

        private void javawishPB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("                  Added To Wishlist.                ");
        }

        private void bsnswishPB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("                  Added To Wishlist.                ");
        }

        private void dopadetoxwishPB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("                  Added To Wishlist.                ");
        }

        private void iutwishPB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("                  Added To Wishlist.                ");
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            MessageBox.Show("                  Added To Wishlist.                ");
        }

        private void doglapanwishPB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("                  Added To Wishlist.                ");
        }

        private void fbeffectwishPB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("                  Added To Wishlist.                ");
        }

        private void ahbanwishPB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("                  Added To Wishlist.                ");
        }

        private void startHwishPB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("                  Added To Wishlist.                ");
        }

        private void cartDotLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NO DISCOUNT! FULL TK DIYE KINEN!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Focused)
            {
                dataGridView10.Show();
            }
            else if(textBox1.Text.Length == 0)
            {
                dataGridView10.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="Java" || textBox1.Text == "JAVA" || textBox1.Text == "java")
            {
                pictureBox161.Show();
                label161.Show();
                label171.Show();
            }
            else if (textBox1.Text == "Business" || textBox1.Text == "business")
            {
                pictureBox171.Show();
                label162.Show();
                label171.Show();
            }
            else
            {
                MessageBox.Show("No Result Found!");
            }
        }
    }
}
