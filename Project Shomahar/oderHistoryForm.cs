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
    public partial class oderHistoryForm : Form
    {
        public oderHistoryForm()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            firstForm abc = new firstForm();
            abc.ShowDialog();
        }

        private void oderHistoryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
