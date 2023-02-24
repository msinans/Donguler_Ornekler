using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donguler_Ornekler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            for (int i = 1; i <= 10; i++)
            {
                toplam = toplam + i;
            }
            label1.Text = toplam.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            for (int i = 0; i <= 10; i += 2)
            {
                toplam = toplam + i;

            }
            label2.Text = toplam.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int toplam = 0, i, sayi = Convert.ToInt16(textBox1.Text);

            for (i = 0; i <= sayi; i++)
            {
                toplam = toplam + i;
            }
            label3.Text = toplam.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i % 3 == 0)
                {
                    listBox1.Items.Add(i);
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100;  i++)
            {
                if (i%5==0 || i%7==0)
                {
                    listBox2.Items.Add(i);

                }
            }
        }
    }
}
