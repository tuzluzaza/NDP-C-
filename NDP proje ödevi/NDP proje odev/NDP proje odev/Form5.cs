/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2023-2024 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: PROJE Ödevi
**				ÖĞRENCİ ADI............: Abdullah Anıl Çobaner
**				ÖĞRENCİ NUMARASI.......: B231210097
**              DERSİN ALINDIĞI GRUP...: B
****************************************************************************/




using NDP_proje_odev;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDP_proje_odev
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1ac = new Form1();
            this.Hide();
            form1ac.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 form1ac = new Form1();
            this.Hide();
            form1ac.Show();
        }

        private void goruntuleRandevuButton_Click(object sender, EventArgs e)
        {
            
            musterilerimiz musteri = new musterilerimiz();

           
            musteri.DosyadanOkuVeListviewEkle(listView1);


            goruntuleRandevuButton.Enabled = false;

        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     
    }
}
