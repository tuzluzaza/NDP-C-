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





using System;
using System.IO;
using System.Windows.Forms;

namespace NDP_proje_odev
{
    interface IClass1
    {
        string isim { get; set; }
        string soyisim { get; set; }
        int musterino { get; set; }
        int ucret { get; set; }
        DateTime tarih { get; set; }
        int telefonno { get; set; }
        string islem { get; set; }

        void DosyadanOkuVeListviewEkle(ListView listView);
        void DosyaYaz(int musterino, string isim, string soyisim, int telefonno, string islem, string personel, int ucret, DateTime tarih);

    }

    abstract class Class1 : IClass1
    {
        public string isim { get; set; }
        public string soyisim { get; set; }
        public int musterino { get; set; }
        public int ucret { get; set; }
        public DateTime tarih { get; set; }
        public int telefonno { get; set; }
        public string islem { get; set; }

        public abstract void DosyaYaz(int musterino, string isim, string soyisim, int telefonno, string islem, string personel, int ucret, DateTime tarih);
        public abstract void DosyadanOkuVeListviewEkle(ListView listView);

    }

    class musterilerimiz : Class1
    {
        public override void DosyaYaz(int musterino, string isim, string soyisim, int telefonno, string islem, string personel, int ucret, DateTime tarih)
        {
            string dosyaYolu = "randevu.txt";

            string veri = musterino.ToString() + "," + isim + "," + soyisim + "," + telefonno.ToString() + "," + islem + "," + personel + "," + ucret.ToString() + "," + tarih.ToString();

            using (StreamWriter writer = new StreamWriter(dosyaYolu, true))
            {
                writer.WriteLine(veri);
            }
        }

        public override void DosyadanOkuVeListviewEkle(ListView listView)
        {
            string dosyaYolu = "randevu.txt";

            if (!File.Exists(dosyaYolu))
            {
                MessageBox.Show("Dosya bulunamadı.");
                return;
            }

           
            using (StreamReader reader = new StreamReader(dosyaYolu))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] veri = line.Split(',');

                    ListViewItem item = new ListViewItem(veri);
                    listView.Items.Add(item);
                }
            }


        }

        public void RandevuSil(int musterino)
        {
            string dosyaYolu = "randevu.txt";
            string geciciDosyaYolu = "gecici_randevu.txt";
            bool randevuBulundu = false;

            if (!File.Exists(dosyaYolu))
            {
                MessageBox.Show("Randevu dosyası bulunamadı.");
                return;
            }

         
            using (StreamWriter geciciDosya = new StreamWriter(geciciDosyaYolu))
            {
              
                using (StreamReader dosya = new StreamReader(dosyaYolu))
                {
                    string satir;
                    while ((satir = dosya.ReadLine()) != null)
                    {
                        string[] veri = satir.Split(',');

                        int dosyaMusteriNo;
                        if (int.TryParse(veri[0], out dosyaMusteriNo) && dosyaMusteriNo == musterino)
                        {
                          
                            MessageBox.Show("Randevu başarıyla silindi.");
                            randevuBulundu = true;
                            continue;
                        }

                        geciciDosya.WriteLine(satir);
                    }
                }
            }

            if (!randevuBulundu)
            {
                MessageBox.Show("Belirtilen randevu numarasına sahip bir randevu bulunamadı.");
            }

         
            File.Delete(dosyaYolu);
            File.Move(geciciDosyaYolu, dosyaYolu);
        }
        public bool RandevuKontrolEt(int musterino)
        {
            string dosyaYolu = "randevu.txt";

           
            if (!File.Exists(dosyaYolu))
            {
                MessageBox.Show("Randevu dosyası bulunamadı.");
                return false;
            }

        
            using (StreamReader reader = new StreamReader(dosyaYolu))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] veri = line.Split(',');

                    int dosyaMusteriNo;
                    if (int.TryParse(veri[0], out dosyaMusteriNo) && dosyaMusteriNo == musterino)
                    {
                        
                        return true;
                    }
                }
            }

           
            return false;
        }
        public void RandevuGuncelle(int musterino, string yeniisim, string yenisoyisim, int yenitelefonno, string yeniislem, string yenipersonel, int yeniucret, DateTime yenitarih)
        {
            string dosyaYolu = "randevu.txt";
            string geciciDosyaYolu = "gecici_randevu.txt";
            bool randevuBulundu = false;

            if (!File.Exists(dosyaYolu))
            {
                MessageBox.Show("Randevu dosyası bulunamadı.");
                return;
            }

            
            using (StreamWriter geciciDosya = new StreamWriter(geciciDosyaYolu))
            {
                
                using (StreamReader dosya = new StreamReader(dosyaYolu))
                {
                    string satir;
                    while ((satir = dosya.ReadLine()) != null)
                    {
                        string[] veri = satir.Split(',');

                        int dosyaMusteriNo;
                        if (int.TryParse(veri[0], out dosyaMusteriNo) && dosyaMusteriNo == musterino)
                        {
                         
                            string guncellenmisSatir = musterino + "," + yeniisim + "," + yenisoyisim + "," + yenitelefonno + "," + yeniislem + "," + yenipersonel + "," + yeniucret + "," + yenitarih.ToString("yyyy-MM-dd HH:mm");
                            geciciDosya.WriteLine(guncellenmisSatir);
                            randevuBulundu = true;
                            MessageBox.Show("Randevu başarıyla güncellendi.");
                        }
                        else
                        {
                          
                            geciciDosya.WriteLine(satir);
                        }
                    }
                }
            }

            if (!randevuBulundu)
            {
                MessageBox.Show("Belirtilen randevu numarasına sahip bir randevu bulunamadı.");
            }

           
            File.Delete(dosyaYolu);
            File.Move(geciciDosyaYolu, dosyaYolu);
        }

    }

   
}
