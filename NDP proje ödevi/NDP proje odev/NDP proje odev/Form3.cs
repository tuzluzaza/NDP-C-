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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace NDP_proje_odev
{
    public partial class Form3 : Form
    {
        public Form3()
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
            bool saatsecildimi2 = true;

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
            else if (radioButton9.Checked == true)
            {
                saat = 20;
            }
            else if (radioButton10.Checked == true)
            {
                saat = 21;
            }
            else
            {
                saatsecildimi2 = false;
            }

            musterilerimiz randevucu = new musterilerimiz();
            int musterino;
            string yeniisim;
            string yenisoyisim;
            int yenitelefonNo;
            string yeniislem;
                 int selectedCount ;
                   string yenipersonel;
                    int ucret ;
            DateTime yenitarih;
            DateTime zamanayarla;


            if (randevukontrolTextbox.Text != "" && guncelleisimTextbox.Text!="" && guncellesoyisimTextbox.Text!=""&& guncelletelefonnoTextbox.Text!="" && guncellepersonelCombobox.SelectedIndex!=-1 && saatsecildimi2 != false && guncelleislemlerListbox.SelectedIndex!=-1)
            {
               musterino = Convert.ToInt32(randevukontrolTextbox.Text);
                yeniisim = guncelleisimTextbox.Text;
              yenisoyisim = guncellesoyisimTextbox.Text;
                yenitelefonNo = Convert.ToInt32(guncelletelefonnoTextbox.Text);
                yeniislem = string.Join("_", guncelleislemlerListbox.CheckedItems.Cast<object>().Select(item => item.ToString()));

                // Mevcut seçilen öğe sayısını hesapla
              selectedCount = guncelleislemlerListbox.CheckedItems.Count;

                // Eğer üç öğeden fazlası seçildiyse
                if (selectedCount > 3)
                {
                    MessageBox.Show("En fazla 3 öğe seçebilirsiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

              yenipersonel = guncellepersonelCombobox.SelectedItem.ToString();

                Dictionary<string, int> islemUcretleri = new Dictionary<string, int>();
                islemUcretleri.Add("Saç kesimi", 500);
                islemUcretleri.Add("Saç boyatma", 600);
                islemUcretleri.Add("Fön çekme", 150);
                islemUcretleri.Add("Yüz maskesi", 250);
                islemUcretleri.Add("Manikür pedikür", 700);
                islemUcretleri.Add("Saç düzleştirme", 100);

                // Seçilen işlemlerin toplam ücretini hesapla
                ucret = 0;
                foreach (var item in guncelleislemlerListbox.CheckedItems)
                {
                    string islemAdi = item.ToString();
                    if (islemUcretleri.ContainsKey(islemAdi))
                    {
                        ucret += islemUcretleri[islemAdi];
                    }
                }

               yenitarih = dateTimePicker1.Value;
               zamanayarla = new DateTime(yenitarih.Year, yenitarih.Month, yenitarih.Day, saat, dakika, 0);


                randevucu.RandevuGuncelle(musterino, yeniisim, yenisoyisim, yenitelefonNo, yeniislem, yenipersonel, ucret, zamanayarla);
                Form1 form1ac = new Form1();
                this.Hide();
                form1ac.Show();

                return; 
            }
            else
            {
                MessageBox.Show("Tüm seçenekleri doldurun.");
            }

          

        }

        private void guncelleisimTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void guncellesoyisimTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }



        private void randevukontrolTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void guncelletelefonnoTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
