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
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ndp_2.ödev
{

    class cisimler<cisim>                    //cisimlerin çizdirilebilmesi için gerekli bütün faktörlerin sınıf içerisinde tanımlanması
    {

        public int x1;     //çarpışacak cisimlerden ilkinin bilgileri            
        public int y1;
        public int z1;
        public int w1;
        public int h1;
        public int d1;
        public int r1;


        public int x2;     //çarpışacak cisimlerden ikincisinin bilgileri  
        public int y2;
        public int z2;
        public int w2;
        public int h2;
        public int d2;
        public int r2;

    }

    //çarpışmalarda kullanılacak olan cisimlerin çizdirilirken kullanılacak olan özelliklerinin ve bu özelliklerle nasıl çizileceğinin belirleyen işlemlerin yapıldığı, cisimlerin tanımlandığı bölüm
    class nokta<cisim> : cisimler<cisim>                        
    {

        public void nokta_ciz(PictureBox pictureBox)
        {

            Graphics g = pictureBox.CreateGraphics();
            Pen kalem = new Pen(Color.Black);
            g.DrawEllipse(kalem, x1, y1, 1, 1);



            Pen koordinat = new Pen(Color.FromArgb(18, Color.Black));
            g.DrawLine(koordinat, 1, 1, 1, 685);
            g.DrawLine(koordinat, 1, 685, 810, 685);

        }

    }

    class Dikdortgen1<cisim> : cisimler<cisim>
    {
            
         public void dikdortgen1_ciz(PictureBox pictureBox)
         {

             Graphics g = pictureBox.CreateGraphics();

             SolidBrush firca = new SolidBrush(Color.FromArgb(50, Color.Orange));

             g.FillRectangle(firca, x1, y1, w1, h1);

         }

    }


    class Dikdortgen2<cisim> : cisimler<cisim>
    {

        public void dikdortgen2_ciz(PictureBox pictureBox)
        {

            Graphics g = pictureBox.CreateGraphics();

            SolidBrush firca = new SolidBrush(Color.FromArgb(50, Color.Red));

            g.FillRectangle(firca, x2, y2, w2, h2);

        }

    }


    class cember1<cisim> : cisimler<cisim>
    {

        public void cember1_ciz(PictureBox pictureBox)
        {

            Graphics g = pictureBox.CreateGraphics();
            Pen kalem = new Pen(Color.Purple);

            g.DrawEllipse(kalem, x1 - r1, y1 - r1, 2 * r1, 2 * r1);

        }

    }


    class cember2<cisim> : cisimler<cisim>
    {

        public void cember2_ciz(PictureBox pictureBox)
        {

            Graphics g = pictureBox.CreateGraphics();
            Pen kalem = new Pen(Color.DeepPink);

            g.DrawEllipse(kalem, x2 - r2, y2 - r2, 2 * r2, 2 * r2);

        }

    }


    class kure1<cisim> : cisimler<cisim>
    {

        public void kure1_ciz(PictureBox pictureBox)
        {

            Graphics g = pictureBox.CreateGraphics();

            Pen kalem = new Pen(Color.FromArgb(128,Color.Green)); 

            SolidBrush firca = new SolidBrush(Color.FromArgb(128, Color.DarkSeaGreen));

            g.FillEllipse(firca, x1 - r1, y1 - r1, 2 * r1, 2 * r1);
            g.DrawEllipse(kalem, x1-r1,y1-r1/3,2*r1,r1/2);

        }

    }


    class kure2<cisim> : cisimler<cisim>
    {

        public void kure2_ciz(PictureBox pictureBox)
        {

            Graphics g = pictureBox.CreateGraphics();

            Pen kalem = new Pen(Color.FromArgb(128, Color.Turquoise));

            SolidBrush firca = new SolidBrush(Color.FromArgb(128, Color.DarkTurquoise));

            g.FillEllipse(firca, x2 - r2, y2 - r2, 2 * r2, 2 * r2);
            g.DrawEllipse(kalem, x2 - r2, y2 - r2 / 3, 2 * r2, r2 / 2);

        }

    }


    class dikdortgenprizma1<cisim> : cisimler<cisim>
    {

        public void dikdortgenprizma1_ciz(PictureBox pictureBox)
        {

            Graphics g = pictureBox.CreateGraphics();

            Pen kalem = new Pen(Color.FromArgb(128, Color.Red));

            g.DrawRectangle(kalem, x1, y1, w1, h1);
            g.DrawRectangle(kalem, x1 + d1, y1 + d1, w1, h1);

            g.DrawLine(kalem, x1, y1, x1 + d1, y1 + d1);
            g.DrawLine(kalem, x1 + w1, y1, x1 + w1 + d1, y1 + d1);
            g.DrawLine(kalem, x1, y1 + h1, x1 + d1, y1 + h1 + d1);
            g.DrawLine(kalem, x1 + w1, y1 + h1, x1 + w1 + d1, y1 + h1 + d1);

        }

    }


    class dikdortgenprizma2<cisim> : cisimler<cisim>
    {

        public void dikdortgenprizma2_ciz(PictureBox pictureBox)
        {
            Graphics g = pictureBox.CreateGraphics();

            Pen kalem = new Pen(Color.FromArgb(128, Color.DarkBlue));

            g.DrawRectangle(kalem, x2, y2, w2, h2);
            g.DrawRectangle(kalem, x2 + d2, y2 + d2, w2, h2);

            g.DrawLine(kalem, x2, y2, x2 + d2, y2 + d2);
            g.DrawLine(kalem, x2 + w2, y2, x2 + w2 + d2, y2 + d2);
            g.DrawLine(kalem, x2, y2 + h2, x2 + d2, y2 + h2 + d2);
            g.DrawLine(kalem, x2 + w2, y2 + h2, x2 + w2 + d2, y2 + h2 + d2);

        }

    }


    class silindir1<cisim> : cisimler<cisim>
    {

        public void silindir1_ciz(PictureBox pictureBox) 
        {

            Graphics g = pictureBox.CreateGraphics();

            Pen kalem = new Pen(Color.FromArgb(128, Color.Brown));


            g.DrawEllipse(kalem, x1 - r1, y1 + h1 / 2, r1 * 2, r1 / 2);

            g.DrawEllipse(kalem, x1 - r1, y1 - h1 / 2, r1 * 2, r1 / 2);

            g.DrawLine(kalem, x1 - r1, y1 - h1 / 2 + r1 / 4, x1 - r1, y1 + h1 / 2 + r1 / 4);

            g.DrawLine(kalem, x1 + r1, y1 - h1 / 2 + r1 / 4, x1 + r1, y1 + h1 / 2 + r1 / 4);

        }

    }


    class silindir2<cisim> : cisimler<cisim>
    {

        public void silindir2_ciz(PictureBox pictureBox)
        {

            Graphics g = pictureBox.CreateGraphics();

            Pen kalem = new Pen(Color.FromArgb(128, Color.Black));


            g.DrawEllipse(kalem, x2 - r2, y2 + h2 / 2, r2 * 2, r2 / 2);

            g.DrawEllipse(kalem, x2 - r2, y2 - h2 / 2, r2 * 2, r2 / 2);

            g.DrawLine(kalem, x2 - r2, y2 - h2 / 2 + r2 / 4, x2 - r2, y2 + h2 / 2 + r2 / 4);

            g.DrawLine(kalem, x2 + r2, y2 - h2 / 2 + r2 / 4, x2 + r2, y2 + h2 / 2 + r2 / 4);

        }

    }


    class yuzey <cisim> : cisimler<cisim>
    {

        public void yuzey_ciz(PictureBox pictureBox) 
        { 

            Graphics g = pictureBox.CreateGraphics();

            Pen kalem = new Pen(Color.FromArgb(128, Color.Yellow));

            g.DrawRectangle(kalem, x1, y1, w1, h1);
            g.DrawLine(kalem, x1, y1, x1 + d1, y1 - d1);
            g.DrawLine(kalem, x1 + w1, y1, x1 + w1 + d1, y1 - d1);
            g.DrawLine(kalem, x1 + d1, y1 - d1, x1 + w1 + d1, y1 - d1);

            g.DrawLine(kalem, x1 + w1 / 3, y1, x1 + d1 + w1 / 3, y1 - d1);
            g.DrawLine(kalem, x1 + 2 * w1 / 3, y1, x1 + d1 + 2 * w1 / 3, y1 - d1);
            g.DrawLine(kalem, x1 + d1 / 2, y1 - d1 / 2, x1 + w1 + d1 / 2, y1 - d1 / 2);


        }

    }

}
