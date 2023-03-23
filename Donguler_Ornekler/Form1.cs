using System;
using System.Windows.Forms;

namespace Donguler_Ornekler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // 10 dan küçük sayıların toplamı
        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            for (int i = 1; i <= 10; i++)
            {
                toplam = toplam + i;
            }
            label1.Text = toplam.ToString();
        }
        // 10 dan küçük çift sayıların toplamı
        private void button2_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            for (int i = 0; i <= 10; i += 2)
            {
                toplam = toplam + i;

            }
            label2.Text = toplam.ToString();
        }
        // Klavyeden girilecek olan sayı ile 0 arasındaki sayıların toplamı
        private void button3_Click(object sender, EventArgs e)
        {
            int toplam = 0, i, sayi = Convert.ToInt16(textBox1.Text);

            for (i = 0; i <= sayi; i++)
            {
                toplam = toplam + i;
            }
            label3.Text = toplam.ToString();
        }
        // 1 ile 10 arasında olup 3 e kalansız bölünen sayılar
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
        // 100'den küçük olup 5 ve 7 sayılarına kalansız bölünen sayılar
        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0 && i % 7 == 0)
                {
                    listBox2.Items.Add(i);

                }
            }
        }
        // Klavyeden girilecek olan sayının 1'den o sayıya kadar yazdırılması
        private void button6_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(textBox2.Text);
            for (int i = 1; i <= sayi; i++)
            {
                listBox3.Items.Add(i);
            }
        }
        // Klavyeden girilen sayının tam bölenleri
        private void button7_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(textBox3.Text);
            for (int i = 1; i <= sayi; i++)
            {
                if (sayi % i == 0)
                {
                    listBox4.Items.Add(i);
                }
            }
        }
        // Klavyeden girilecek sayının faktoriyeli
        private void button8_Click(object sender, EventArgs e)
        {
            
            int i, sayi = Convert.ToInt16(textBox4.Text);
            int faktoriyel = 1;
            for (i = 1; i <= sayi; i++)
            {
                faktoriyel = faktoriyel * i;

            }
            listBox5.Items.Add(sayi + "! = " + faktoriyel);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            char[] harf = { 'a', 'b', 'c' };
            for (int i = 1; i < 6; i++)
            {
                listBox6.Items.Add(i);
                foreach (var h in harf)
                {
                    listBox6.Items.Add(h);
                }
            }
        }
    }
}
