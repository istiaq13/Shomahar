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
    public partial class settingForm : Form
    {
        public settingForm()
        {
            InitializeComponent();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            firstForm abc = new firstForm();
            abc.ShowDialog();
        }

        private void settingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
