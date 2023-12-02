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

namespace WindowsFormsApp28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void dönd()
        {
            int forrnd = rnd.Next(0, 12);
            int forrnd2 = rnd.Next(0, 12);
            int[] k = { 5, 10, 15, 20, 25, 30, 35, 40, 50, 55, 60, 65, 70 };
            label3.Text = k[forrnd].ToString() + " ";
            label3.Text = label3.Text + k[forrnd2].ToString();
            if (forrnd == forrnd2)
            {
                dönd();
            }
            if (forrnd > forrnd2)
            {
                dönd();
            }
            if (forrnd < forrnd2)
            {
                int silrnd = rnd.Next(k[forrnd], k[forrnd2]);
                label6.Text = silrnd.ToString();
                MessageBox.Show("Sayın Belirlendi Tahmin Et Bakalım");
                

            }
        }


        public Random rnd = new Random();
        public Random rnd2 = new Random();
        public int sayaç = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            dönd();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //belirlenen sonucum gizli textbox a aktarılıyor ve veri çekiliyor :D
            if (textBox1.Text == label6.Text)
            {
                MessageBox.Show("Sayıyı Doğru Bildin");
            }
            else
            {
                MessageBox.Show("Sayıyı Yanlış Bildin");
            }
            //pengu//
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                label6.Visible = true;
            }
            else
            {
                label6.Visible = false;   
            }
        }
    }
}
