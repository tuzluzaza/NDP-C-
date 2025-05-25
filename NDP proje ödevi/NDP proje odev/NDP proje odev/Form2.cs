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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NDP_proje_odev
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1ac = new Form1();
            this.Hide();
            form1ac.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1ac = new Form1();
            this.Hide();
            form1ac.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 form1ac = new Form1();
            this.Hide();
            form1ac.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int saat = 0;
            int dakika = 0;
            bool saatsecildimi = true;

            if (radioButton1.Checked == true)
            {
                saat = 12;
            }
            else if (radioButton2.Checked == true)
            {
                saat = 13;
            }
            else if (radioButton3.Checked == true)
            {
                saat = 14;
            }
            else if (radioButton4.Checked == true)
            {
                saat = 15;
            }
            else if (radioButton5.Checked == true)
            {
                saat = 16;
            }
            else if (radioButton6.Checked == true)
            {
                saat = 17;
            }
            else if (radioButton7.Checked == true)
            {
                saat = 18;
            }
            else if (radioButton8.Checked == true)
            {
                saat = 19;
            }
            else if(radioButton9.Checked == true)
            {
                saat = 20;
            }
            else if (radioButton10.Checked == true)
            {
                saat = 21;
            }
            else
            {
                saatsecildimi = false;
            }


           
            int musteriNo;
            string isim;
            string soyisim;
            int telefonNo;
            string islem;

         
            int selectedCount;
            string personel;
            int ucret;
            DateTime tarih;
            DateTime zamanayarla;

            if (musterinoTextbox.Text != "" && isimTextbox.Text != "" && soyisimTextbox.Text!="" && telefonnoTextbox.Text!=""&& personelCombobox.SelectedIndex !=-1 && saatsecildimi != false && islemlerListbox.SelectedIndex!=-1)
            {
                musteriNo = Convert.ToInt32(musterinoTextbox.Text);
               

                isim = isimTextbox.Text;
                soyisim = soyisimTextbox.Text;
                telefonNo = Convert.ToInt32(telefonnoTextbox.Text);
                islem = string.Join("_", islemlerListbox.CheckedItems.Cast<object>().Select(item => item.ToString()));

             
                selectedCount = islemlerListbox.CheckedItems.Count;

             
                if (selectedCount > 3)
                {
                    MessageBox.Show("En fazla 3 öğe seçebilirsiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }

                personel = personelCombobox.SelectedItem.ToString();



                Dictionary<string, int> islemUcretleri = new Dictionary<string, int>();
                islemUcretleri.Add("Saç kesimi", 500);
                islemUcretleri.Add("Saç boyatma", 600);
                islemUcretleri.Add("Fön çekme", 150);
                islemUcretleri.Add("Yüz maskesi", 250);
                islemUcretleri.Add("Manikür pedikür", 700);
                islemUcretleri.Add("Saç düzleştirme", 100);

          
                ucret = 0;
                foreach (var item in islemlerListbox.CheckedItems)
                {
                    string islemAdi = item.ToString();
                    if (islemUcretleri.ContainsKey(islemAdi))
                    {
                        ucret += islemUcretleri[islemAdi];
                    }
                }

                tarih = dateTimePicker1.Value;
                zamanayarla = new DateTime(tarih.Year, tarih.Month, tarih.Day, saat, dakika, 0);

                musterilerimiz randevuIslemleri = new musterilerimiz();
                if (randevuIslemleri.RandevuKontrolEt(musteriNo))
                {
                    MessageBox.Show("Bu müşteri numarası ile zaten bir randevu bulunmaktadır. Lütfen başka bir müşteri numarası deneyin.");
                    return; 
                }

             
                musterilerimiz musteri = new musterilerimiz();

               
                musteri.DosyaYaz(musteriNo, isim, soyisim, telefonNo, islem, personel, ucret, zamanayarla);

               
                MessageBox.Show("Bilgiler dosyaya kaydedildi.");
                Form1 form1ac = new Form1();
                this.Hide();
                form1ac.Show();
            }
            else
            {
                MessageBox.Show("Tüm seçenekleri doldurun.");

            }



        }

        private void musterinoTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void geri2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void soyisimTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void telefonnoTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void isimTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
