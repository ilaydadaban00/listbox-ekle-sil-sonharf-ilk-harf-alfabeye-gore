using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace list_ile_listbox_kişi_eklemek
{
    public partial class Form1 : Form
    {
        List<string> kisiler = new List<string>();
        int İndexSira = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            kisiler.Add("SEMA");
            kisiler.Add("SUKEYNA");
            kisiler.Add("MELİSA");
            kisiler.Add("İLAYDA");
            kisiler.Add("NİSA");
            kisiler.Add("KüBRA");

            listBox1.DataSource = kisiler.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            kisiler.Add(txtEkle.Text);
            listBox1.DataSource = kisiler.ToList();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            bool durum = kisiler.Contains(txtEkle.Text);
            if (durum)
            {
                MessageBox.Show("bulundu");

            }
            else
            {
                MessageBox.Show("yok");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int sira = kisiler.IndexOf(txtEkle.Text);
            if (sira > -1)
            {
                MessageBox.Show(txtEkle.Text + " " + sira + ".sirasındadır.");
            }
            else
            {
                MessageBox.Show(txtEkle.Text + "sıralamada yoktur.");
            }
        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            int sira = kisiler.IndexOf(txtEkle.Text);
            if (sira > -1)
            {
                kisiler.RemoveAt(sira);
            }
            listBox1.DataSource = kisiler.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool durum = kisiler.Contains(txtEkle.Text);
            if (durum)
            {
                kisiler.Remove(txtEkle.Text);

            }
            listBox1.DataSource = kisiler.ToList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEkle.Text = listBox1.SelectedIndex.ToString();
            İndexSira = listBox1.SelectedIndex;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //  MessageBox.Show(İndexSira.ToString());
            kisiler[İndexSira] = txtEkle.Text;

            listBox1.DataSource = kisiler.ToList();
        }

        private void btnArtan_Click(object sender, EventArgs e)
        {
            kisiler.Sort();
            listBox1.DataSource = kisiler.ToList();
        }

        private void btnAzalan_Click(object sender, EventArgs e)
        {
            kisiler.Sort();
            kisiler.Reverse();
            listBox1.DataSource = kisiler.ToList();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < kisiler.Count; i++)
            {
                if (kisiler[i].Length == 5)
                {
                    sayac++;
                }
                MessageBox.Show("5 karekterli;" + sayac + "tane ogrenci var");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int sayac = 0;
            for (int i = 0; i < kisiler.Count; i++)
            {
                if (kisiler[i][0] == 'm')
                {
                    sayac++;
                }
                MessageBox.Show("m karekterli;" + sayac + "tane ogrenci var");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kisiler.Clear();
            listBox1.DataSource = kisiler.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < kisiler.Count; i++)
            {
                string kisi = kisiler[i];

                if (kisi[kisi.Length-1] == 'a')
                {
                    sayac++;
                }
              
            } 
            MessageBox.Show("a karekterli   " + sayac + "     tane ogrenci var");
        }

     
    }
}
