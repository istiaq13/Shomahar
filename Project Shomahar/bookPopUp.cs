using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Shomahar
{
    public partial class bookPopUp : Form
    {
        public static int connectID;
        public bookPopUp()
        {
            InitializeComponent();
        }
        public static long i = 0;
        
        private void bookPopUp_Load(object sender, EventArgs e)
        {
            button2.BackColor = Color.Gray;
            button2.ForeColor = Color.White;
            button2.Enabled = false;
            textBox1.Text = Convert.ToString(i);
            ControlBox = false;
            textBox1.Text= "0";

            javaPB.Hide();
            bsnsPB.Hide();
            dopadetoxPB.Hide();
            iutPB.Hide();
            gotPB.Hide();

            doglapanPB.Hide();
            msgPB.Hide();
            fbefctPB.Hide();
            ahbanPB.Hide();
            statupHpb.Hide();

            if ((connectID = 1)==firstForm.bookid)
            {
                Namelabel.Text = "JAVA By ORACLE (11th Edition)";
                Authorlabel.Text = "Herbert Schildt";
                priceLabel.Text = "170 BDT";
                javaPB.Show();
            }
            else if ((connectID = 2) == firstForm.bookid)
            {
                Namelabel.Text = "বিজনেস ব্লুপ্রিন্ট";
                Authorlabel.Text = " মুহাম্মদ ইলিয়াস কাঞ্চন (কোচ কাঞ্চন)";
                priceLabel.Text = "405 BDT";
                bsnsPB.Show();
            }
            else if ((connectID = 3) == firstForm.bookid)
            {
                Namelabel.Text = "ডোপামিন ডিটক্স";
                Authorlabel.Text = "থিবো মেরিস , প্রিতম মুজতাহিদ (অনুবাদক)";
                priceLabel.Text = "599 BDT";
                dopadetoxPB.Show();
            }
            else if ((connectID =4 ) == firstForm.bookid)
            {
                Namelabel.Text = "আইইউটি ভর্তি প্রস্তুতি";
                Authorlabel.Text = "জয়কলি পাবলিকেশন্স লিঃ";
                priceLabel.Text = "190 BDT";
                iutPB.Show();
            }
            else if ((connectID =5 ) == firstForm.bookid)
            {
                Namelabel.Text = "GAME OF THRONES-COMPLETE SERIES";
                Authorlabel.Text = "George R. R. Martin";
                priceLabel.Text = "999 BDT";
                gotPB.Show();
            }
            else if ((connectID =6 ) == firstForm.bookid)
            {
                Namelabel.Text = "DOGLAPAN";
                Authorlabel.Text = "Ashneer Grover";
                priceLabel.Text = "799 BDT";
                doglapanPB.Show();
            }
            else if ((connectID =7 ) == firstForm.bookid)
            {
                Namelabel.Text = "ম্যাসেজ (আধুনিক মননে দ্বীনের ছোঁয়া)";
                Authorlabel.Text = "ড. মিজানুর রহমান আজহারি";
                priceLabel.Text = "199 BDT";
                msgPB.Show();
            }
            else if ((connectID = 8) == firstForm.bookid)
            {
                Namelabel.Text = "THE FACEBOOK EFFECT";
                Authorlabel.Text = "David Kirkpatrick";
                priceLabel.Text = "999 BDT";
                fbefctPB.Show();
            }
            else if ((connectID =9 ) == firstForm.bookid)
            {
                Namelabel.Text = "আহ্বান (আধুনিক মননে আলোর পরশ)";
                Authorlabel.Text = "ড. মিজানুর রহমান আজহারি";
                priceLabel.Text = "199 BDT";
                ahbanPB.Show();
            }
            else if ((connectID = 10) == firstForm.bookid)
            {
                Namelabel.Text = "The $100 Startup";
                Authorlabel.Text = "Chris Guillebeau";
                priceLabel.Text = "699 BDT";

                statupHpb.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Your Order has been placed successfully");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            i++;
            
            if(i<6)
            {
                textBox1.Text = Convert.ToString(i);
                label6.Text = "See Total Price";
            }
            else
            {
                MessageBox.Show("Sorry! We have only 5 books in stock");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            i--;

            if (i>=0)
            {
                textBox1.Text = Convert.ToString(i-1);
                label6.Text = "See Total Price";
            }
            else
            {
               
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if ((connectID = 1) == firstForm.bookid)
            {
                label6.Text = (Convert.ToString(170 * (Convert.ToInt32(textBox1.Text)))) + " " + "BDT";
            }
            else if ((connectID = 2) == firstForm.bookid)
            {
                label6.Text = (Convert.ToString(405 * (Convert.ToInt32(textBox1.Text)))) + " " + "BDT";
            }
            else if ((connectID = 3) == firstForm.bookid)
            {
                label6.Text = (Convert.ToString(599 * (Convert.ToInt32(textBox1.Text)))) + " " + "BDT";
            }
            else if ((connectID = 4) == firstForm.bookid)
            {
                label6.Text = (Convert.ToString(190 * (Convert.ToInt32(textBox1.Text)))) + " " + "BDT";
            }
            else if ((connectID = 5) == firstForm.bookid)
            {
                label6.Text = (Convert.ToString(999 * (Convert.ToInt32(textBox1.Text)))) + " " + "BDT";
            }
            else if ((connectID = 6) == firstForm.bookid)
            {
                label6.Text = (Convert.ToString(799 * (Convert.ToInt32(textBox1.Text)))) + " " + "BDT";
            }
            else if ((connectID = 7) == firstForm.bookid)
            {
                label6.Text = (Convert.ToString(199 * (Convert.ToInt32(textBox1.Text)))) + " " + "BDT";
            }
            else if ((connectID = 8) == firstForm.bookid)
            {
                label6.Text = (Convert.ToString(999 * (Convert.ToInt32(textBox1.Text)))) + " " + "BDT";
            }
            else if ((connectID = 9) == firstForm.bookid)
            {
                label6.Text = (Convert.ToString(199 * (Convert.ToInt32(textBox1.Text)))) + " " + "BDT";
            }
            else if ((connectID = 10) == firstForm.bookid)
            {
                label6.Text = (Convert.ToString(699 * (Convert.ToInt32(textBox1.Text)))) + " " + "BDT";
            }
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            label6.ForeColor = Color.LawnGreen;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Lavender;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                button2.Enabled = true;
                button2.BackColor = Color.Green;
            }
            else
            {
                button2.Enabled = false;
                button2.BackColor = Color.Gray;
                button2.ForeColor = Color.White;
            }
        }
    }
}
