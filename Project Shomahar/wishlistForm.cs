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
    public partial class wishlistForm : Form
    {
        public wishlistForm()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            firstForm abc = new firstForm();
            abc.ShowDialog();
        }

        private void wishlistForm_Load(object sender, EventArgs e)
        {

        }
    }
}
