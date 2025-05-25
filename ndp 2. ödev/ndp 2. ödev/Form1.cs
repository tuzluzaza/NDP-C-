/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**		  BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**			   BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**		      NESNEYE DAYALI PROGRAMLAMA DERSİ
**	 
**				ÖDEV NUMARASI   : 2.Ödev
**				ÖĞRENCİ ADI     : Abdullah Anıl Çobaner
**				ÖĞRENCİ NUMARASI: B231210097
**				DERS GRUBU      : B
****************************************************************************/



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ndp_2.ödev
{
    public partial class Form1 : Form
    {

        nokta<int> n=new nokta<int>();                                          //cisimler sınıfını kullanarak yenı nesneler tanımlama oluşturma bölümü

        Dikdortgen1<int> D1 = new Dikdortgen1<int>();
        Dikdortgen2<int> D2 = new Dikdortgen2<int>();

        cember1<int> c1 = new cember1<int>();
        cember2<int> c2 = new cember2<int>();

        kure1<int> k1 = new kure1<int>();
        kure2<int> k2 = new kure2<int>();

        dikdortgenprizma1<int> p1 = new dikdortgenprizma1<int>();
        dikdortgenprizma2<int> p2 = new dikdortgenprizma2<int>();

        silindir1<int> s1 = new silindir1<int>();
        silindir2<int> s2 = new silindir2<int>();

        yuzey<int> y = new yuzey<int>();


        public bool ihtimal1;                                                 //çarpışma sonuçlarını tayin ederken gerçekleşebilmesi muhtemel olayları tanımlamak için kullanılan ihtimallerin tanımlanması
        public bool ihtimal2;
        public bool ihtimal3;

        public void carpismadenetimi()                                       //disaridan girilen verilere gore cisimleri cizerek carpisip carpismadigina karar verip sonucu ekrana yazdiran fonksiyon.
        {

            if (CarpismaSecenekleriComboBox.SelectedIndex == 0) 
            {

                n.x1 = Convert.ToInt32(xkordinattext1.Text);
                n.y1 = Convert.ToInt32(ykordinattext1.Text);

                D2.x2 = Convert.ToInt32(xkordinattext2.Text);
                D2.y2 = Convert.ToInt32(ykordinattext2.Text);
                D2.h2 = Convert.ToInt32(yuksekliktext2.Text);
                D2.w2 = Convert.ToInt32(genisliktext2.Text);

                n.nokta_ciz(pictureBox1);
                D2.dikdortgen2_ciz(pictureBox1);

                int dmerkez_x = D2.x2 + D2.w2 / 2;
                int dmerkez_y = D2.y2 + D2.h2 / 2;

                int x_uzaklik = Math.Abs(dmerkez_x - n.x1);
                int y_uzaklik = Math.Abs(dmerkez_y - n.y1);

                ihtimal1 = x_uzaklik <= D2.w2 / 2;
                ihtimal2 = y_uzaklik <= D2.h2 / 2;
                
                if(ihtimal1 && ihtimal2)
                {

                    MessageBox.Show("ÇARPIŞMA GERÇEKLEŞİR", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {

                    MessageBox.Show("ÇARPIŞMA GERÇEKLEŞMEZ", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }

            if (CarpismaSecenekleriComboBox.SelectedIndex == 1)
            {
             
                n.x1 = Convert.ToInt32(xkordinattext1.Text);
                n.y1 = Convert.ToInt32(ykordinattext1.Text);

                c2.x2 = Convert.ToInt32(xkordinattext2.Text);
                c2.y2 = Convert.ToInt32(ykordinattext2.Text);
                c2.r2 = Convert.ToInt32(yaricaptext2.Text);
              

                n.nokta_ciz(pictureBox1);
                c2.cember2_ciz(pictureBox1);

                ihtimal1 = Math.Pow(n.x1 - c2.x2, 2) + Math.Pow(n.y1 - c2.y2, 2) == Math.Pow(c2.r2, 2);

                if (ihtimal1)
                {

                    MessageBox.Show("ÇARPIŞMA GERÇEKLEŞİR", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {

                    MessageBox.Show("ÇARPIŞMA GERÇEKLEŞMEZ", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }

            if (CarpismaSecenekleriComboBox.SelectedIndex == 2)
            {

                D1.x1 = Convert.ToInt32(xkordinattext1.Text);
                D1.y1 = Convert.ToInt32(ykordinattext1.Text);
                D1.h1 = Convert.ToInt32(yuksekliktext1.Text);
                D1.w1 = Convert.ToInt32(genisliktext1.Text);

                D2.x2 = Convert.ToInt32(xkordinattext2.Text);
                D2.y2 = Convert.ToInt32(ykordinattext2.Text);
                D2.h2 = Convert.ToInt32(yuksekliktext2.Text);
                D2.w2 = Convert.ToInt32(genisliktext2.Text);

                D1.dikdortgen1_ciz(pictureBox1);
                D2.dikdortgen2_ciz(pictureBox1);

                ihtimal1 = D1.x1 <= D2.x2 + D2.w2 && D1.x1 + D1.w1 >= D2.x2 && D1.y1 <= D2.y2 + D2.h2 && D1.y1 + D1.h1 >= D2.y2;
                ihtimal1 = D2.x2 <= D1.x1 + D1.w1 && D2.x2 + D2.w2 >= D1.x1 && D2.y2 <= D1.y1 + D1.h1 && D2.y2 + D2.h2 >= D1.y1;

                if (ihtimal1 || ihtimal2) 
                {

                    MessageBox.Show("ÇARPIŞMA GERÇEKLEŞİR", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {

                    MessageBox.Show("ÇARPIŞMA GERÇEKLEŞMEZ", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }

            if (CarpismaSecenekleriComboBox.SelectedIndex == 3)
            {

                D1.x1 = Convert.ToInt32(xkordinattext1.Text);
                D1.y1 = Convert.ToInt32(ykordinattext1.Text);
                D1.h1 = Convert.ToInt32(yuksekliktext1.Text);
                D1.w1 = Convert.ToInt32(genisliktext1.Text);

                c2.x2 = Convert.ToInt32(xkordinattext2.Text);
                c2.y2 = Convert.ToInt32(ykordinattext2.Text);
                c2.r2 = Convert.ToInt32(yaricaptext2.Text);

                D1.dikdortgen1_ciz(pictureBox1);
                c2.cember2_ciz(pictureBox1);

                ihtimal1 = c2.x2 + c2.r2 >= D1.x1 && c2.x2 - c2.r2 <= D1.w1;
                ihtimal2 = c2.y2 + c2.r2 >= D1.y1 && c2.y2 - c2.r2 <= D1.h1;

                if (ihtimal1 && ihtimal2)
                {

                    MessageBox.Show("ÇARPIŞMA GERÇEKLEŞİR", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {

                    MessageBox.Show("ÇARPIŞMA GERÇEKLEŞMEZ", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }

            if (CarpismaSecenekleriComboBox.SelectedIndex == 4)
            {

                c1.x1 = Convert.ToInt32(xkordinattext1.Text);
                c1.y1 = Convert.ToInt32(ykordinattext1.Text);
                c1.r1 = Convert.ToInt32(yaricaptext1.Text);

                c2.x2 = Convert.ToInt32(xkordinattext2.Text);
                c2.y2 = Convert.ToInt32(ykordinattext2.Text);
                c2.r2 = Convert.ToInt32(yaricaptext2.Text);

                c1.cember1_ciz(pictureBox1);
                c2.cember2_ciz(pictureBox1);


                double merkezler_uzaklik = Math.Sqrt(Math.Pow(c1.x1 - c2.x2, 2) + Math.Pow(c1.y1 - c2.y2, 2));
                int r_toplam = c1.r1 + c2.r2;

                if(merkezler_uzaklik<=r_toplam)
                {

                    MessageBox.Show("ÇARPIŞMA GERÇEKLEŞİR", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {

                    MessageBox.Show("ÇARPIŞMA GERÇEKLEŞMEZ", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }

            if (CarpismaSecenekleriComboBox.SelectedIndex == 5)
            {

                n.x1 = Convert.ToInt32(xkordinattext1.Text);
                n.y1 = Convert.ToInt32(ykordinattext1.Text);
                n.z1 = Convert.ToInt32(ykordinattext1.Text);

                k2.x2 = Convert.ToInt32(xkordinattext2.Text);
                k2.y2 = Convert.ToInt32(ykordinattext2.Text);
                k2.z2 = Convert.ToInt32(zkordinattext2.Text);
                k2.r2 = Convert.ToInt32(yaricaptext2.Text);

                n.nokta_ciz(pictureBox1);
                k2.kure2_ciz(pictureBox1);

                double mesafe = Math.Sqrt(Math.Pow(n.x1 - k2.x2, 2) + Math.Pow(n.y1 - k2.y2, 2)  + Math.Pow(n.z1 - k2.z2, 2));

                if(mesafe<=k2.r2)
                {

                    MessageBox.Show("ÇARPIŞMA GERÇEKLEŞİR", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {

                    MessageBox.Show("ÇARPIŞMA GERÇEKLEŞMEZ", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }

            if (CarpismaSecenekleriComboBox.SelectedIndex == 6)
            {

                n.x1 = Convert.ToInt32(xkordinattext1.Text);
                n.y1 = Convert.ToInt32(ykordinattext1.Text);
                n.z1 = Convert.ToInt32(ykordinattext1.Text);

                p2.x2 = Convert.ToInt32(xkordinattext2.Text);
                p2.y2 = Convert.ToInt32(ykordinattext2.Text);
                p2.z2 = Convert.ToInt32(zkordinattext2.Text);
                p2.h2 = Convert.ToInt32(yuksekliktext2.Text);
                p2.w2 = Convert.ToInt32(genisliktext2.Text);
                p2.d2 = Convert.ToInt32(derinliktext2.Text);

                n.nokta_ciz(pictureBox1);
                p2.dikdortgenprizma2_ciz(pictureBox1);

                ihtimal1 = n.x1 >= p2.x2 && n.x1 <= p2.x2 + p2.d2 + p2.h2;
                ihtimal2 = n.y1 >= p2.y2 && n.y1 <= p2.y2 + p2.h2 + p2.d2;


                if (ihtimal1 && ihtimal2)
                {

                    MessageBox.Show("ÇARPIŞMA GERÇEKLEŞİR", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {

                    MessageBox.Show("ÇARPIŞMA GERÇEKLEŞMEZ", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }

            if (CarpismaSecenekleriComboBox.SelectedIndex == 7)
            {

                n.x1 = Convert.ToInt32(xkordinattext1.Text);
                n.y1 = Convert.ToInt32(ykordinattext1.Text);
                n.z1 = Convert.ToInt32(ykordinattext1.Text);

                s2.x2 = Convert.ToInt32(xkordinattext2.Text);
                s2.y2 = Convert.ToInt32(ykordinattext2.Text);
                s2.h2 = Convert.ToInt32(yuksekliktext2.Text);
                s2.r2 = Convert.ToInt32(yaricaptext2.Text);

                n.nokta_ciz(pictureBox1);
                s2.silindir2_ciz(pictureBox1);

                int x_uzaklik = Math.Abs(n.x1 - s2.x2);
                int y_uzaklik = Math.Abs(n.y1 - s2.y2);
                int z_uzaklik = Math.Abs(n.z1 - s2.z2);

                ihtimal1 = x_uzaklik <= s2.r2;
                ihtimal2 = y_uzaklik <= s2.h2;
                ihtimal3 = z_uzaklik <= s2.r2;

                if (ihtimal1 && ihtimal2 && ihtimal3)
                {

                    MessageBox.Show("ÇARPIŞMA GERÇEKLEŞİR", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {

                    MessageBox.Show("ÇARPIŞMA GERÇEKLEŞMEZ", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            if (CarpismaSecenekleriComboBox.SelectedIndex == 8)
            {

                s1.x1 = Convert.ToInt32(xkordinattext1.Text);
                s1.y1 = Convert.ToInt32(ykordinattext1.Text);
                s1.h1 = Convert.ToInt32(yuksekliktext1.Text);
                s1.r1 = Convert.ToInt32(yaricaptext1.Text);

                s2.x2 = Convert.ToInt32(xkordinattext2.Text);
                s2.y2 = Convert.ToInt32(ykordinattext2.Text);
                s2.h2 = Convert.ToInt32(yuksekliktext2.Text);
                s2.r2 = Convert.ToInt32(yaricaptext2.Text);

                s1.silindir1_ciz(pictureBox1);
                s2.silindir2_ciz(pictureBox1);

                double xz_merkez_uzaklik;

                xz_merkez_uzaklik = Math.Sqrt(Math.Pow(s1.x1 - s2.x2, 2) + Math.Pow(s1.z1 - s2.z2, 2));

                double yz_merkez_uzaklik;

                yz_merkez_uzaklik=Math.Abs(s1.y1-s2.y2);

                ihtimal1 = xz_merkez_uzaklik <= s1.r1 + s2.r2;

                ihtimal2 = yz_merkez_uzaklik <= s1.h1 / 2 + s2.h2 / 2;

                if (ihtimal1 && ihtimal2)
                {

                    MessageBox.Show("ÇARPIŞMA GERÇEKLEŞİR", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {

                    MessageBox.Show("ÇARPIŞMA GERÇEKLEŞMEZ", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }

            if (CarpismaSecenekleriComboBox.SelectedIndex == 9)
            {

                k1.x1 = Convert.ToInt32(xkordinattext1.Text);
                k1.y1 = Convert.ToInt32(ykordinattext1.Text);
                k1.z1 = Convert.ToInt32(zkordinattext1.Text);
                k1.r1 = Convert.ToInt32(yaricaptext1.Text);

                k2.x2 = Convert.ToInt32(xkordinattext2.Text);
                k2.y2 = Convert.ToInt32(ykordinattext2.Text);
                k2.z2 = Convert.ToInt32(zkordinattext2.Text);
                k2.r2 = Convert.ToInt32(yaricaptext2.Text);

                k1.kure1_ciz(pictureBox1);
                k2.kure2_ciz(pictureBox1);

                double mesafe= Math.Sqrt(Math.Pow(k1.x1 - k2.x2, 2) + Math.Pow(k1.y1 - k2.y2, 2) + Math.Pow(k1.z1 - k2.z2, 2));

                if(mesafe<=k1.r1+k2.r2)
                {

                    MessageBox.Show("ÇARPIŞMA GERÇEKLEŞİR", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {

                    MessageBox.Show("ÇARPIŞMA GERÇEKLEŞMEZ", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }

            if (CarpismaSecenekleriComboBox.SelectedIndex == 10)
            {

                k1.x1 = Convert.ToInt32(xkordinattext1.Text);
                k1.y1 = Convert.ToInt32(ykordinattext1.Text);
                k1.z1 = Convert.ToInt32(zkordinattext1.Text);
                k1.r1 = Convert.ToInt32(yaricaptext1.Text);

                s2.x2 = Convert.ToInt32(xkordinattext2.Text);
                s2.y2 = Convert.ToInt32(ykordinattext2.Text);
                s2.h2= Convert.ToInt32(yuksekliktext2.Text);
                s2.r2 = Convert.ToInt32(yaricaptext2.Text);

                k1.kure1_ciz(pictureBox1);
                s2.silindir2_ciz(pictureBox1);

                double xz_merkez_uzaklik;

                xz_merkez_uzaklik = Math.Sqrt(Math.Pow(k1.x1 - s2.x2, 2) + Math.Pow(k1.z1 - s2.z2, 2));

                double yz_merkez_uzaklik;

                yz_merkez_uzaklik = Math.Abs(k1.y1 - s2.y2);

                ihtimal1 = xz_merkez_uzaklik <= k1.r1 + s2.r2;

                ihtimal2 = yz_merkez_uzaklik <= s2.h2 / 2 + k1.r1;


                if (ihtimal1 && ihtimal2)
                {

                    MessageBox.Show("ÇARPIŞMA GERÇEKLEŞİR", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else
                {

                    MessageBox.Show("ÇARPIŞMA GERÇEKLEŞMEZ", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }

            if (CarpismaSecenekleriComboBox.SelectedIndex == 11)
            {

                y.x1 = Convert.ToInt32(xkordinattext1.Text);
                y.y1 = Convert.ToInt32(ykordinattext1.Text);
                y.z1 = Convert.ToInt32(zkordinattext1.Text);
                y.h1 = 1;
                y.w1 = Convert.ToInt32(genisliktext1.Text);
                y.d1 = Convert.ToInt32(derinliktext1.Text);

                k2.x2 = Convert.ToInt32(xkordinattext2.Text);
                k2.y2 = Convert.ToInt32(ykordinattext2.Text);
                k2.z2 = Convert.ToInt32(zkordinattext2.Text);
                k2.r2 = Convert.ToInt32(yaricaptext2.Text);

                y.yuzey_ciz(pictureBox1);
                k2.kure2_ciz(pictureBox1);


                ihtimal1 = y.x1 - k2.r2 <= k2.x2 && y.x1 + y.w1 + y.d1 + k2.r2 >= k2.x2;

                ihtimal2 = y.y1 - k2.r2 - y.d1 <= k2.y2 && y.y1 + k2.r2 >= k2.y2;

                if (ihtimal1 && ihtimal2)
                {

                    MessageBox.Show("ÇARPIŞMA GERÇEKLEŞİR", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else
                {

                    MessageBox.Show("ÇARPIŞMA GERÇEKLEŞMEZ", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }

            if (CarpismaSecenekleriComboBox.SelectedIndex == 12)
            {

                y.x1 = Convert.ToInt32(xkordinattext1.Text);
                y.y1 = Convert.ToInt32(ykordinattext1.Text);
                y.z1 = Convert.ToInt32(zkordinattext1.Text);
                y.h1 = 1;
                y.w1 = Convert.ToInt32(genisliktext1.Text);
                y.d1 = Convert.ToInt32(derinliktext1.Text);

                p2.x2 = Convert.ToInt32(xkordinattext2.Text);
                p2.y2 = Convert.ToInt32(ykordinattext2.Text);
                p2.z2 = Convert.ToInt32(zkordinattext2.Text);
                p2.h2 = Convert.ToInt32(yuksekliktext2.Text);
                p2.w2 = Convert.ToInt32(genisliktext2.Text);
                p2.d2 = Convert.ToInt32(derinliktext2.Text);

                y.yuzey_ciz(pictureBox1);
                p2.dikdortgenprizma2_ciz(pictureBox1);

                ihtimal1 = y.x1 - p2.w2 <= p2.x2 && y.x1 + y.w1 + y.d1 >= p2.x2;
                ihtimal2 = p2.y2 + p2.h2 >= y.y1 - y.d1 && p2.y2 <= y.y1;

                if (ihtimal1 && ihtimal2)
                {

                    MessageBox.Show("ÇARPIŞMA GERÇEKLEŞİR", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else
                {

                    MessageBox.Show("ÇARPIŞMA GERÇEKLEŞMEZ", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }

            if (CarpismaSecenekleriComboBox.SelectedIndex == 13)
            {

                y.x1 = Convert.ToInt32(xkordinattext1.Text);
                y.y1 = Convert.ToInt32(ykordinattext1.Text);
                y.z1 = Convert.ToInt32(zkordinattext1.Text);
                y.h1 = 1;
                y.w1 = Convert.ToInt32(genisliktext1.Text);
                y.d1 = Convert.ToInt32(derinliktext1.Text);

                s2.x2 = Convert.ToInt32(xkordinattext2.Text);
                s2.y2 = Convert.ToInt32(ykordinattext2.Text);
                s2.h2 = Convert.ToInt32(yuksekliktext2.Text);
                s2.r2 = Convert.ToInt32(yaricaptext2.Text);

                y.yuzey_ciz(pictureBox1);
                s2.silindir2_ciz(pictureBox1);

                ihtimal1 = y.x1 - s2.r2 <= y.x2 && y.x1 + y.w1 + y.d1 + s2.r2 >= s2.x2;

                ihtimal2 = y.y1 - s2.h2 / 2 - y.d1 <= s2.y2 && y.y1 + s2.h2 / 2 >= s2.y2;

                if (ihtimal1 && ihtimal2)
                {

                    MessageBox.Show("ÇARPIŞMA GERÇEKLEŞİR", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else
                {

                    MessageBox.Show("ÇARPIŞMA GERÇEKLEŞMEZ", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }

            if (CarpismaSecenekleriComboBox.SelectedIndex == 14)
            {

                k1.x1 = Convert.ToInt32(xkordinattext1.Text);
                k1.y1 = Convert.ToInt32(ykordinattext1.Text);
                k1.z1 = Convert.ToInt32(zkordinattext1.Text);
                k1.r1 = Convert.ToInt32(yaricaptext1.Text);

                p2.x2 = Convert.ToInt32(xkordinattext2.Text);
                p2.y2 = Convert.ToInt32(ykordinattext2.Text);
                p2.z2 = Convert.ToInt32(zkordinattext2.Text);
                p2.h2 = Convert.ToInt32(yuksekliktext2.Text);
                p2.w2 = Convert.ToInt32(genisliktext2.Text);
                p2.d2 = Convert.ToInt32(derinliktext2.Text);

                k1.kure1_ciz(pictureBox1);
                p2.dikdortgenprizma2_ciz(pictureBox1);


                ihtimal1=p2.x2 - k1.r1 <= k1.x1 && p2.x2 + p2.d2 + p2.w2 >= k1.x1;
                ihtimal2 = k1.y1 + k1.r1 >= p2.y2 && k1.y1 - k1.r1 <= p2.y2 + p2.h2 + p2.d2;

                if (ihtimal1 && ihtimal2)
                {

                    MessageBox.Show("ÇARPIŞMA GERÇEKLEŞİR", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else
                {

                    MessageBox.Show("ÇARPIŞMA GERÇEKLEŞMEZ", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }



            }

            if (CarpismaSecenekleriComboBox.SelectedIndex == 15)
            {

                p1.x1 = Convert.ToInt32(xkordinattext1.Text);
                p1.y1 = Convert.ToInt32(ykordinattext1.Text);
                p1.z1 = Convert.ToInt32(zkordinattext1.Text);
                p1.h1 = Convert.ToInt32(yuksekliktext1.Text);
                p1.w1 = Convert.ToInt32(genisliktext1.Text);
                p1.d1 = Convert.ToInt32(derinliktext1.Text);
              


                p2.x2 = Convert.ToInt32(xkordinattext2.Text);
                p2.y2 = Convert.ToInt32(ykordinattext2.Text);
                p2.z2 = Convert.ToInt32(zkordinattext2.Text);
                p2.h2 = Convert.ToInt32(yuksekliktext2.Text);
                p2.w2 = Convert.ToInt32(genisliktext2.Text);
                p2.d2 = Convert.ToInt32(derinliktext2.Text);

                p1.dikdortgenprizma1_ciz(pictureBox1);
                p2.dikdortgenprizma2_ciz(pictureBox1);

                ihtimal1 = p1.x1 <= p2.x2 + p2.w2 && p1.x1 + p1.w1 >= p2.x2 && p1.y1 <= p2.y2 + p2.h2 && p1.y1 + p1.h1 >= p2.y2 && p1.x1 + p1.d1 <= p2.x2 + p2.w2 + p2.d2 && p1.x1 + p1.d1 + p1.w1 >= p2.x2 + p2.d2 && p1.y1 + p1.d1 <= p2.y2 + p2.d2 + p2.h2 && p1.y1 + p1.d1 + p1.h1 >= p2.y2 + p2.d2;

                ihtimal2 = p2.x2 <= p1.x1 + p1.w1 && p2.x2 + p2.w2 >= p1.x1 && p2.y2 <= p1.y1 + p1.h1 && p2.y2 + p2.h2 >= p1.y1 && p2.x2 + p2.d2 <= p1.x1 + p1.w1 + p1.d1 && p2.x2 + p2.d2 + p2.w2 >= p1.x1 + p1.d1 && p2.y2 + p2.d2 <= p1.y1 + p1.d1 + p1.h1 && p2.y2 + p2.d2 + p2.h2 >= p1.y1 + p1.d1;


                if (ihtimal1 || ihtimal2)
                {

                    MessageBox.Show("ÇARPIŞMA GERÇEKLEŞİR", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else
                {

                    MessageBox.Show("ÇARPIŞMA GERÇEKLEŞMEZ", "SONUÇ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }



        public Form1()
        {
            InitializeComponent();
        }
      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (CarpismaSecenekleriComboBox.SelectedIndex == 0)               //seçilen çarpışma seçeneğine göre arayüzde gerekli textboların ve butonların görünmesini sağlayan bölüm
            {

                pictureBox1.Refresh();
                cisim1grupbox.Text = "Nokta";
                cisim2grupbox.Text = "Dikdörtgen";

                xkordinati1.Visible = true;
                ykordinati1.Visible = true;
                zkordinati1.Visible = false;
                yukseklik1.Visible = false;
                genislik1.Visible = false;
                derinlik1.Visible = false;
                yaricap1.Visible = false;
                xkordinattext1.Visible = true;
                ykordinattext1.Visible = true;
                zkordinattext1.Visible = false;
                yuksekliktext1.Visible = false;
                genisliktext1.Visible = false;
                derinliktext1.Visible = false;
                yaricaptext1.Visible = false;

                xkordinati2.Visible = true;
                ykordinati2.Visible = true;
                zkordinati2.Visible = false;
                yukseklik2.Visible = true;
                genislik2.Visible = true;
                derinlik2.Visible = false;
                yaricap2.Visible = false;
                xkordinattext2.Visible = true;
                ykordinattext2.Visible = true;
                zkordinattext2.Visible = false;
                yuksekliktext2.Visible = true;
                genisliktext2.Visible = true;
                derinliktext2.Visible = false;
                yaricaptext2.Visible = false;

            }

            else if (CarpismaSecenekleriComboBox.SelectedIndex == 1) 
            {

                pictureBox1.Refresh();
                cisim1grupbox.Text = "Nokta";
                cisim2grupbox.Text = "Çember";

                xkordinati1.Visible = true;
                ykordinati1.Visible = true;
                zkordinati1.Visible = false;
                yukseklik1.Visible = false;
                genislik1.Visible = false;
                derinlik1.Visible = false;
                yaricap1.Visible = false;
                xkordinattext1.Visible = true;
                ykordinattext1.Visible = true;
                zkordinattext1.Visible = false;
                yuksekliktext1.Visible = false;
                genisliktext1.Visible = false;
                derinliktext1.Visible = false;
                yaricaptext1.Visible = false;

                xkordinati2.Visible = true;
                ykordinati2.Visible = true;
                zkordinati2.Visible = false;
                yukseklik2.Visible = false;
                genislik2.Visible = false;
                derinlik2.Visible = false;
                yaricap2.Visible = true;
                xkordinattext2.Visible = true;
                ykordinattext2.Visible = true;
                zkordinattext2.Visible = false;
                yuksekliktext2.Visible = false;
                genisliktext2.Visible = false;
                derinliktext2.Visible = false;
                yaricaptext2.Visible = true;

            }

            else if (CarpismaSecenekleriComboBox.SelectedIndex == 2)
            {

                pictureBox1.Refresh();
                cisim1grupbox.Text = "Dikdörtgen";
                cisim2grupbox.Text = "Dikdörtgen";

                xkordinati1.Visible = true;
                ykordinati1.Visible = true;
                zkordinati1.Visible = false;
                yukseklik1.Visible = true;
                genislik1.Visible = true;
                derinlik1.Visible = false;
                yaricap1.Visible = false;
                xkordinattext1.Visible = true;
                ykordinattext1.Visible = true;
                zkordinattext1.Visible = false;
                yuksekliktext1.Visible = true;
                genisliktext1.Visible = true;
                derinliktext1.Visible = false;
                yaricaptext1.Visible = false;

                xkordinati2.Visible = true;
                ykordinati2.Visible = true;
                zkordinati2.Visible = false;
                yukseklik2.Visible = true;
                genislik2.Visible = true;
                derinlik2.Visible = false;
                yaricap2.Visible = false;
                xkordinattext2.Visible = true;
                ykordinattext2.Visible = true;
                zkordinattext2.Visible = false;
                yuksekliktext2.Visible = true;
                genisliktext2.Visible = true;
                derinliktext2.Visible = false;
                yaricaptext2.Visible = false;

            }

            else if (CarpismaSecenekleriComboBox.SelectedIndex == 3)
            {

                pictureBox1.Refresh();
                cisim1grupbox.Text = "Dikdörtgen";
                cisim2grupbox.Text = "Çember";

                xkordinati1.Visible = true;
                ykordinati1.Visible = true;
                zkordinati1.Visible = false;
                yukseklik1.Visible = true;
                genislik1.Visible = true;
                derinlik1.Visible = false;
                yaricap1.Visible = false;
                xkordinattext1.Visible = true;
                ykordinattext1.Visible = true;
                zkordinattext1.Visible = false;
                yuksekliktext1.Visible = true;
                genisliktext1.Visible = true;
                derinliktext1.Visible = false;
                yaricaptext1.Visible = false;

                xkordinati2.Visible = true;
                ykordinati2.Visible = true;
                zkordinati2.Visible = false;
                yukseklik2.Visible = false;
                genislik2.Visible = false;
                derinlik2.Visible = false;
                yaricap2.Visible = true;
                xkordinattext2.Visible = true;
                ykordinattext2.Visible = true;
                zkordinattext2.Visible = false;
                yuksekliktext2.Visible = false;
                genisliktext2.Visible = false;
                derinliktext2.Visible = false;
                yaricaptext2.Visible = true;

            }
            else if (CarpismaSecenekleriComboBox.SelectedIndex == 4)
            {

                pictureBox1.Refresh();

                cisim1grupbox.Text = "Çember";
                cisim2grupbox.Text = "Çember";

                xkordinati1.Visible = true;
                ykordinati1.Visible = true;
                zkordinati1.Visible = false;
                yukseklik1.Visible = false;
                genislik1.Visible = false;
                derinlik1.Visible = false;
                yaricap1.Visible = true;
                xkordinattext1.Visible = true;
                ykordinattext1.Visible = true;
                zkordinattext1.Visible = false;
                yuksekliktext1.Visible = false;
                genisliktext1.Visible = false;
                derinliktext1.Visible = false;
                yaricaptext1.Visible = true;

                xkordinati2.Visible = true;
                ykordinati2.Visible = true;
                zkordinati2.Visible = false;
                yukseklik2.Visible = false;
                genislik2.Visible = false;
                derinlik2.Visible = false;
                yaricap2.Visible = true;
                xkordinattext2.Visible = true;
                ykordinattext2.Visible = true;
                zkordinattext2.Visible = false;
                yuksekliktext2.Visible = false;
                genisliktext2.Visible = false;
                derinliktext2.Visible = false;
                yaricaptext2.Visible = true;

            }

            else if (CarpismaSecenekleriComboBox.SelectedIndex == 5)
            {

                pictureBox1.Refresh();

                cisim1grupbox.Text = "Nokta";
                cisim2grupbox.Text = "Küre";

                xkordinati1.Visible = true;
                ykordinati1.Visible = true;
                zkordinati1.Visible = true;
                yukseklik1.Visible = false;
                genislik1.Visible = false;
                derinlik1.Visible = false;
                yaricap1.Visible = false;
                xkordinattext1.Visible = true;
                ykordinattext1.Visible = true;
                zkordinattext1.Visible = true;
                yuksekliktext1.Visible = false;
                genisliktext1.Visible = false;
                derinliktext1.Visible = false;
                yaricaptext1.Visible = false;

                xkordinati2.Visible = true;
                ykordinati2.Visible = true;
                zkordinati2.Visible = true;
                yukseklik2.Visible = false;
                genislik2.Visible = false;
                derinlik2.Visible = false;
                yaricap2.Visible = true;
                xkordinattext2.Visible = true;
                ykordinattext2.Visible = true;
                zkordinattext2.Visible = true;
                yuksekliktext2.Visible = false;
                genisliktext2.Visible = false;
                derinliktext2.Visible = false;
                yaricaptext2.Visible = true;

            }

            else if (CarpismaSecenekleriComboBox.SelectedIndex == 6)
            {

                pictureBox1.Refresh();

                cisim1grupbox.Text = "Nokta";
                cisim2grupbox.Text = "Dikdörtgen prizma";

                xkordinati1.Visible = true;
                ykordinati1.Visible = true;
                zkordinati1.Visible = false;
                yukseklik1.Visible = false;
                genislik1.Visible = false;
                derinlik1.Visible = false;
                yaricap1.Visible = false;
                xkordinattext1.Visible = true;
                ykordinattext1.Visible = true;
                zkordinattext1.Visible = false;
                yuksekliktext1.Visible = false;
                genisliktext1.Visible = false;
                derinliktext1.Visible = false;
                yaricaptext1.Visible = false;

                xkordinati2.Visible = true;
                ykordinati2.Visible = true;
                zkordinati2.Visible = true;
                yukseklik2.Visible = true;
                genislik2.Visible = true;
                derinlik2.Visible = true;
                yaricap2.Visible = false;
                xkordinattext2.Visible = true;
                ykordinattext2.Visible = true;
                zkordinattext2.Visible = true;
                yuksekliktext2.Visible = true;
                genisliktext2.Visible = true;
                derinliktext2.Visible = true;
                yaricaptext2.Visible = false;

            }

            else if (CarpismaSecenekleriComboBox.SelectedIndex == 7)
            {

                pictureBox1.Refresh();

                cisim1grupbox.Text = "Nokta";
                cisim2grupbox.Text = "Silindir";

                xkordinati1.Visible = true;
                ykordinati1.Visible = true;
                zkordinati1.Visible = true;
                yukseklik1.Visible = false;
                genislik1.Visible = false;
                derinlik1.Visible = false;
                yaricap1.Visible = false;
                xkordinattext1.Visible = true;
                ykordinattext1.Visible = true;
                zkordinattext1.Visible = true;
                yuksekliktext1.Visible = false;
                genisliktext1.Visible = false;
                derinliktext1.Visible = false;
                yaricaptext1.Visible = false;

                xkordinati2.Visible = true;
                ykordinati2.Visible = true;
                zkordinati2.Visible = false;
                yukseklik2.Visible = true;
                genislik2.Visible = false;
                derinlik2.Visible = false;
                yaricap2.Visible = true;
                xkordinattext2.Visible = true;
                ykordinattext2.Visible = true;
                zkordinattext2.Visible = false;
                yuksekliktext2.Visible = true;
                genisliktext2.Visible = false;
                derinliktext2.Visible = false;
                yaricaptext2.Visible = true;

            }

            else if (CarpismaSecenekleriComboBox.SelectedIndex == 8)
            {

                pictureBox1.Refresh();

                cisim1grupbox.Text = "Silindir";
                cisim2grupbox.Text = "Silindir";

                xkordinati1.Visible = true;
                ykordinati1.Visible = true;
                zkordinati1.Visible = false;
                yukseklik1.Visible = true;
                genislik1.Visible = false;
                derinlik1.Visible = false;
                yaricap1.Visible = true;
                xkordinattext1.Visible = true;
                ykordinattext1.Visible = true;
                zkordinattext1.Visible = false;
                yuksekliktext1.Visible = true;
                genisliktext1.Visible = false;
                derinliktext1.Visible = false;
                yaricaptext1.Visible = true;

                xkordinati2.Visible = true;
                ykordinati2.Visible = true;
                zkordinati2.Visible = false;
                yukseklik2.Visible = true;
                genislik2.Visible = false;
                derinlik2.Visible = false;
                yaricap2.Visible = true;
                xkordinattext2.Visible = true;
                ykordinattext2.Visible = true;
                zkordinattext2.Visible = false;
                yuksekliktext2.Visible = true;
                genisliktext2.Visible = false;
                derinliktext2.Visible = false;
                yaricaptext2.Visible = true;

            }

            else if (CarpismaSecenekleriComboBox.SelectedIndex == 9)
            {

                pictureBox1.Refresh();

                cisim1grupbox.Text = "Küre";
                cisim2grupbox.Text = "Küre";

                xkordinati1.Visible = true;
                ykordinati1.Visible = true;
                zkordinati1.Visible = true;
                yukseklik1.Visible = false;
                genislik1.Visible = false;
                derinlik1.Visible = false;
                yaricap1.Visible = true;
                xkordinattext1.Visible = true;
                ykordinattext1.Visible = true;
                zkordinattext1.Visible = true;
                yuksekliktext1.Visible = false;
                genisliktext1.Visible = false;
                derinliktext1.Visible = false;
                yaricaptext1.Visible = true;

                xkordinati2.Visible = true;
                ykordinati2.Visible = true;
                zkordinati2.Visible = true;
                yukseklik2.Visible = false;
                genislik2.Visible = false;
                derinlik2.Visible = false;
                yaricap2.Visible = true;
                xkordinattext2.Visible = true;
                ykordinattext2.Visible = true;
                zkordinattext2.Visible = true;
                yuksekliktext2.Visible = false;
                genisliktext2.Visible = false;
                derinliktext2.Visible = false;
                yaricaptext2.Visible = true;

            }

            else if (CarpismaSecenekleriComboBox.SelectedIndex == 10)
            {

                pictureBox1.Refresh();

                cisim1grupbox.Text = "Küre";
                cisim2grupbox.Text = "Silindir";

                xkordinati1.Visible = true;
                ykordinati1.Visible = true;
                zkordinati1.Visible = true;
                yukseklik1.Visible = false;
                genislik1.Visible = false;
                derinlik1.Visible = false;
                yaricap1.Visible = true;
                xkordinattext1.Visible = true;
                ykordinattext1.Visible = true;
                zkordinattext1.Visible = true;
                yuksekliktext1.Visible = false;
                genisliktext1.Visible = false;
                derinliktext1.Visible = false;
                yaricaptext1.Visible = true;

                xkordinati2.Visible = true;
                ykordinati2.Visible = true;
                zkordinati2.Visible = false;
                yukseklik2.Visible = true;
                genislik2.Visible = false;
                derinlik2.Visible = false;
                yaricap2.Visible = true;
                xkordinattext2.Visible = true;
                ykordinattext2.Visible = true;
                zkordinattext2.Visible = false;
                yuksekliktext2.Visible = true;
                genisliktext2.Visible = false;
                derinliktext2.Visible = false;
                yaricaptext2.Visible = true;

            }

            else if (CarpismaSecenekleriComboBox.SelectedIndex == 11)
            {

                pictureBox1.Refresh();

                cisim1grupbox.Text = "Yüzey";
                cisim2grupbox.Text = "Küre";

                xkordinati1.Visible = true;
                ykordinati1.Visible = true;
                zkordinati1.Visible = true;
                yukseklik1.Visible = false;
                genislik1.Visible = true;
                derinlik1.Visible = true;
                yaricap1.Visible = false;
                xkordinattext1.Visible = true;
                ykordinattext1.Visible = true;
                zkordinattext1.Visible = true;
                yuksekliktext1.Visible = false;
                genisliktext1.Visible = true;
                derinliktext1.Visible = true;
                yaricaptext1.Visible = false;

                xkordinati2.Visible = true;
                ykordinati2.Visible = true;
                zkordinati2.Visible = true;
                yukseklik2.Visible = false;
                genislik2.Visible = false;
                derinlik2.Visible = false;
                yaricap2.Visible = true;
                xkordinattext2.Visible = true;
                ykordinattext2.Visible = true;
                zkordinattext2.Visible = true;
                yuksekliktext2.Visible = false;
                genisliktext2.Visible = false;
                derinliktext2.Visible = false;
                yaricaptext2.Visible = true;

            }

            else if (CarpismaSecenekleriComboBox.SelectedIndex == 12)
            {

                pictureBox1.Refresh();

                cisim1grupbox.Text = "Yüzey";
                cisim2grupbox.Text = "Dikdörtgen prizma";

                xkordinati1.Visible = true;
                ykordinati1.Visible = true;
                zkordinati1.Visible = true;
                yukseklik1.Visible = false;
                genislik1.Visible = true;
                derinlik1.Visible = true;
                yaricap1.Visible = false;
                xkordinattext1.Visible = true;
                ykordinattext1.Visible = true;
                zkordinattext1.Visible = true;
                yuksekliktext1.Visible = false;
                genisliktext1.Visible = true;
                derinliktext1.Visible = true;
                yaricaptext1.Visible = false;

                xkordinati2.Visible = true;
                ykordinati2.Visible = true;
                zkordinati2.Visible = true;
                yukseklik2.Visible = true;
                genislik2.Visible = true;
                derinlik2.Visible = true;
                yaricap2.Visible = false;
                xkordinattext2.Visible = true;
                ykordinattext2.Visible = true;
                zkordinattext2.Visible = true;
                yuksekliktext2.Visible = true;
                genisliktext2.Visible = true;
                derinliktext2.Visible = true;
                yaricaptext2.Visible = false;

            }

            else if (CarpismaSecenekleriComboBox.SelectedIndex == 13)
            {

                pictureBox1.Refresh();

                cisim1grupbox.Text = "Yüzey";
                cisim2grupbox.Text = "Silindir";

                xkordinati1.Visible = true;
                ykordinati1.Visible = true;
                zkordinati1.Visible = true;
                yukseklik1.Visible = false;
                genislik1.Visible = true;
                derinlik1.Visible = true;
                yaricap1.Visible = false;
                xkordinattext1.Visible = true;
                ykordinattext1.Visible = true;
                zkordinattext1.Visible = true;
                yuksekliktext1.Visible = false;
                genisliktext1.Visible = true;
                derinliktext1.Visible = true;
                yaricaptext1.Visible = false;

                xkordinati2.Visible = true;
                ykordinati2.Visible = true;
                zkordinati2.Visible = false;
                yukseklik2.Visible = true;
                genislik2.Visible = false;
                derinlik2.Visible = false;
                yaricap2.Visible = true;
                xkordinattext2.Visible = true;
                ykordinattext2.Visible = true;
                zkordinattext2.Visible = false;
                yuksekliktext2.Visible = true;
                genisliktext2.Visible = false;
                derinliktext2.Visible = false;
                yaricaptext2.Visible = true;

            }

            else if (CarpismaSecenekleriComboBox.SelectedIndex == 14)
            {

                pictureBox1.Refresh();

                cisim1grupbox.Text = "Küre";
                cisim2grupbox.Text = "Dikdörtgen prizma";

                xkordinati1.Visible = true;
                ykordinati1.Visible = true;
                zkordinati1.Visible = true;
                yukseklik1.Visible = false;
                genislik1.Visible = false;
                derinlik1.Visible = false;
                yaricap1.Visible = true;
                xkordinattext1.Visible = true;
                ykordinattext1.Visible = true;
                zkordinattext1.Visible = true;
                yuksekliktext1.Visible = false;
                genisliktext1.Visible = false;
                derinliktext1.Visible = false;
                yaricaptext1.Visible = true;

                xkordinati2.Visible = true;
                ykordinati2.Visible = true;
                zkordinati2.Visible = true;
                yukseklik2.Visible = true;
                genislik2.Visible = true;
                derinlik2.Visible = true;
                yaricap2.Visible = false;
                xkordinattext2.Visible = true;
                ykordinattext2.Visible = true;
                zkordinattext2.Visible = true;
                yuksekliktext2.Visible = true;
                genisliktext2.Visible = true;
                derinliktext2.Visible = true;
                yaricaptext2.Visible = false;

            }

            else if (CarpismaSecenekleriComboBox.SelectedIndex == 15)
            {

                pictureBox1.Refresh();

                cisim1grupbox.Text = "Dikdörtgen prizma";
                cisim2grupbox.Text = "Dikdörtgen prizma";

                xkordinati1.Visible = true;
                ykordinati1.Visible = true;
                zkordinati1.Visible = true;
                yukseklik1.Visible = true;
                genislik1.Visible = true;
                derinlik1.Visible = true;
                yaricap1.Visible = false;
                xkordinattext1.Visible = true;
                ykordinattext1.Visible = true;
                zkordinattext1.Visible = true;
                yuksekliktext1.Visible = true;
                genisliktext1.Visible = true;
                derinliktext1.Visible = true;
                yaricaptext1.Visible = false;

                xkordinati2.Visible = true;
                ykordinati2.Visible = true;
                zkordinati2.Visible = true;
                yukseklik2.Visible = true;
                genislik2.Visible = true;
                derinlik2.Visible = true;
                yaricap2.Visible = false;
                xkordinattext2.Visible = true;
                ykordinattext2.Visible = true;
                zkordinattext2.Visible = true;
                yuksekliktext2.Visible = true;
                genisliktext2.Visible = true;
                derinliktext2.Visible = true;
                yaricaptext2.Visible = false;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            pictureBox1.Refresh();

            carpismadenetimi();          //cisimlerin çarpışmasını kontrol eden fonksiyonun çağırıldığı yer

        }

    }

}
