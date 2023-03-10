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
    public partial class bookPopUp : Form
    {
        public bookPopUp()
        {
            InitializeComponent();
        }

        private void bookPopUp_Load(object sender, EventArgs e)
        {
            if(button4.Created == true)
            {
                textBox1.Clear();
                for (int i = 1; i <= 10; i++)
                {
                    textBox1.Text = textBox1.Text + i;
                    if (i == 11)
                        break;
                }
            }
            ControlBox = false;
            textBox1.Text= "0";
            label5.Text = firstForm.bookName;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
