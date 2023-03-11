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
        public static int connectID;
        public bookPopUp()
        {
            InitializeComponent();
        }

        private void bookPopUp_Load(object sender, EventArgs e)
        {
            ControlBox = false;
            textBox1.Text= "0";

            if((connectID = 1)==firstForm.bookid)
            {
                Namelabel.Text = "JAVA By ORACLE (11th Edition)";
                Authorlabel.Text = "Herbert Schildt";
                priceLabel.Text = "170 BDT";

                bsnsPB.Hide();
                dopadetoxPB.Hide();
                iutPB.Hide();
                gotPB.Hide();

                doglapanPB.Hide();
                msgPB.Hide();
                fbefctPB.Hide();
                ahbanPB.Hide();
                statupHpb.Hide();

            }
            else if ((connectID = 2) == firstForm.bookid)
            {
                Namelabel.Text = "বিজনেস ব্লুপ্রিন্ট";
                Authorlabel.Text = " মুহাম্মদ ইলিয়াস কাঞ্চন (কোচ কাঞ্চন)";
                priceLabel.Text = "405 BDT";

                javaPB.Hide();
                dopadetoxPB.Hide();
                iutPB.Hide();
                gotPB.Hide();

                doglapanPB.Hide();
                msgPB.Hide();
                fbefctPB.Hide();
                ahbanPB.Hide();
                statupHpb.Hide();
            }
            else if ((connectID = 3) == firstForm.bookid)
            {
                Namelabel.Text = "ডোপামিন ডিটক্স";
                Authorlabel.Text = "থিবো মেরিস , প্রিতম মুজতাহিদ (অনুবাদক)";
                priceLabel.Text = "599 BDT";

                javaPB.Hide();
                bsnsPB.Hide();
                iutPB.Hide();
                gotPB.Hide();

                doglapanPB.Hide();
                msgPB.Hide();
                fbefctPB.Hide();
                ahbanPB.Hide();
                statupHpb.Hide();
            }
            else if ((connectID =4 ) == firstForm.bookid)
            {
                Namelabel.Text = "আইইউটি ভর্তি প্রস্তুতি";
                Authorlabel.Text = "জয়কলি পাবলিকেশন্স লিঃ";
                priceLabel.Text = "190 BDT";

                javaPB.Hide();
                bsnsPB.Hide();
                dopadetoxPB.Hide();
                gotPB.Hide();

                doglapanPB.Hide();
                msgPB.Hide();
                fbefctPB.Hide();
                ahbanPB.Hide();
                statupHpb.Hide();
            }
            else if ((connectID =5 ) == firstForm.bookid)
            {
                Namelabel.Text = "GAME OF THRONES-COMPLETE SERIES";
                Authorlabel.Text = "George R. R. Martin";
                priceLabel.Text = "999 BDT";

                javaPB.Hide();
                bsnsPB.Hide();
                dopadetoxPB.Hide();
                iutPB.Hide();

                doglapanPB.Hide();
                msgPB.Hide();
                fbefctPB.Hide();
                ahbanPB.Hide();
                statupHpb.Hide();
            }
            else if ((connectID =6 ) == firstForm.bookid)
            {
                Namelabel.Text = "DOGLAPAN";
                Authorlabel.Text = "Ashneer Grover";
                priceLabel.Text = "799 BDT";

                javaPB.Hide();
                bsnsPB.Hide();
                dopadetoxPB.Hide();
                iutPB.Hide();
                gotPB.Hide();

                msgPB.Hide();
                fbefctPB.Hide();
                ahbanPB.Hide();
                statupHpb.Hide();
            }
            else if ((connectID =7 ) == firstForm.bookid)
            {
                Namelabel.Text = "ম্যাসেজ (আধুনিক মননে দ্বীনের ছোঁয়া)";
                Authorlabel.Text = "ড. মিজানুর রহমান আজহারি";
                priceLabel.Text = "199 BDT";

                javaPB.Hide();
                bsnsPB.Hide();
                dopadetoxPB.Hide();
                iutPB.Hide();
                gotPB.Hide();

                doglapanPB.Hide();
                fbefctPB.Hide();
                ahbanPB.Hide();
                statupHpb.Hide();
            }
            else if ((connectID = 8) == firstForm.bookid)
            {
                Namelabel.Text = "THE FACEBOOK EFFECT";
                Authorlabel.Text = "David Kirkpatrick";
                priceLabel.Text = "999 BDT";

                javaPB.Hide();
                bsnsPB.Hide();
                dopadetoxPB.Hide();
                iutPB.Hide();
                gotPB.Hide();

                doglapanPB.Hide();
                msgPB.Hide();
                ahbanPB.Hide();
                statupHpb.Hide();
            }
            else if ((connectID =9 ) == firstForm.bookid)
            {
                Namelabel.Text = "আহ্বান (আধুনিক মননে আলোর পরশ)";
                Authorlabel.Text = "ড. মিজানুর রহমান আজহারি";
                priceLabel.Text = "199 BDT";

                javaPB.Hide();
                bsnsPB.Hide();
                dopadetoxPB.Hide();
                iutPB.Hide();
                gotPB.Hide();

                doglapanPB.Hide();
                msgPB.Hide();
                fbefctPB.Hide();
                statupHpb.Hide();
            }
            else if ((connectID = 10) == firstForm.bookid)
            {
                Namelabel.Text = "The $100 Startup";
                Authorlabel.Text = "Chris Guillebeau";
                priceLabel.Text = "699 BDT";

                javaPB.Hide();
                bsnsPB.Hide();
                dopadetoxPB.Hide();
                iutPB.Hide();
                gotPB.Hide();

                doglapanPB.Hide();
                msgPB.Hide();
                fbefctPB.Hide();
                ahbanPB.Hide();
            }
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
            textBox1.Text = "0";
            for(int i=1; i < 10; i++)
            {
                textBox1.Text = textBox1.Text + i;

            }
        }
    }
}
