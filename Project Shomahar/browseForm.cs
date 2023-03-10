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
    public partial class browseForm : Form
    {
        public browseForm()
        {
            InitializeComponent();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            firstForm abc = new firstForm();
            abc.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            firstForm abc = new firstForm();
            abc.ShowDialog();
        }

        private void dataGridView10_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void browseForm_Load(object sender, EventArgs e)
        {
            dataGrid.Hide();
            label11.Hide();
            label12.Hide();
            label14.Hide();
            label15.Hide();
            label16.Hide();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm abc = new loginForm();
            abc.ShowDialog();
        }

        private void browseForm_MouseHover(object sender, EventArgs e)
        {
            dataGrid.Hide();
            label11.Hide();
            label12.Hide();
            label14.Hide();
            label15.Hide();
            label16.Hide();
            label17.Show();
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            dataGrid.Show();
            label11.Show();
            label12.Show();
            label14.Show();
            label15.Show();
            label16.Show();
            label17.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            dataGrid.Show();
            label11.Show();
            label12.Show();
            label14.Show();
            label15.Show();
            label16.Show();
            label17.Hide();
        }

        private void browseForm_MouseClick(object sender, MouseEventArgs e)
        {
            dataGrid.Hide();
            label11.Hide();
            label12.Hide();
            label14.Hide();
            label15.Hide();
            label16.Hide();
            label17.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            label5.ForeColor= Color.White;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor= Color.Gray;
        }
    }
}
