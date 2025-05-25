/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2014-2015 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:  1
**				ÖĞRENCİ ADI............:  ABDULLAH ANIL ÇOBANER
**				ÖĞRENCİ NUMARASI.......:  B231210097
**              DERSİN ALINDIĞI GRUP...:  B
****************************************************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace _1

{
    public partial class Form1 : Form 

    {

        bool cpp= false;       //program ilk calistirildiginda program formatıni sadece txt desteklemesi adına duzenlıyoruz
        bool cs = false;
        bool txt = true;

        public Form1()
        {

            InitializeComponent();  

        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            richTextBox1.Cut();    

        }
        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            richTextBox1.Copy();

        }
        private void yapistirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            richTextBox1.Paste();

        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {

            richTextBox1.Clear();

        }

        private void kaydet()
        {

            if (txt == true)
            {

                saveFileDialog1.Filter = "Metin Dosyaları|*.txt";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                    this.Text = saveFileDialog1.FileName;

                }

            }

            if (cpp == true)
            {

                saveFileDialog1.Filter = "C++ Dosya Formati|*.cpp";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                    this.Text = saveFileDialog1.FileName;

                }

            }

            if (cs == true)
            {
                saveFileDialog1.Filter = "C# Dosya Formati|*.cs";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                    this.Text = saveFileDialog1.FileName;

                }

            }

        }
        private void dosyaKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {

            kaydet();

        }

        private void bilgilendirmeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Abdullah Anıl Çobaner B231210097");

        }

        private void cppmToolStripMenuItem_Click(object sender, EventArgs e)
        {

            cpp = true;
            cs = false;
            txt = false;
            MessageBox.Show("Uygulama formatı cpp olmuştur");
            richTextBox1.Text = "include<iostream>" + Environment.NewLine + "using namespace std ;" + Environment.NewLine + "int main () " + Environment.NewLine + "  {" + Environment.NewLine + " string oyun= cs2 ;" + Environment.NewLine + "  cout<<oyun<<endl ; " + Environment.NewLine + "  }";

        }

        private void csToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            cpp = false;
            cs = true;
            txt = false;
            MessageBox.Show("Uygulama formatı cs olmuştur");
            richTextBox1.Text = "using System;" + Environment.NewLine + "namespace basitornek" + Environment.NewLine + "{" + Environment.NewLine + " cs2  // oyun turnuvasi" + Environment.NewLine + "  {" + Environment.NewLine + "   static void Main(string[] args)" + Environment.NewLine + "    {" + Environment.NewLine + "     Console.WriteLine(\" Selamun Aleykum”);" + Environment.NewLine + "    }" + Environment.NewLine + "   }" + Environment.NewLine + "}";

        }

        private void dosyaAcToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();                         //açılacak dosyanın hangi format seçilmiş ise ona göre filtreleme işlemi yapması için kurulan if döngüsü
            if (txt == true)
            {

                open.Filter = "txt files |*.txt";
                if (open.ShowDialog() == DialogResult.OK)
                {

                    string oku = File.ReadAllText(open.FileName);
                    richTextBox1.Text = oku;

                }
            }

            if (cpp == true)
            {

                 open.Filter = "cpp files |*.cpp";
                if (open.ShowDialog() == DialogResult.OK)
                {

                    string oku = File.ReadAllText(open.FileName);
                    richTextBox1.Text = oku;

                }
            }

            if (cs == true)
            {

                open.Filter = "cs files |*.cs";
                if (open.ShowDialog() == DialogResult.OK)
                {

                    string oku = File.ReadAllText(open.FileName);
                    richTextBox1.Text = oku;

                }

            }

        }

        private void txtToolStripMenuItem_Click(object sender, EventArgs e)
        {

            cpp = false;
            cs = false;
            txt = true;
            MessageBox.Show("Uygulama formatı txt olmuştur");
            richTextBox1.Text = "";

        }

        private void kaydetÇıkToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (txt == true)
            {

                saveFileDialog1.Filter = "Metin Dosyaları|*.txt";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                    this.Text = saveFileDialog1.FileName;

                }

            }

            if (cpp == true)
            {

                saveFileDialog1.Filter = "C++ Dosya Formati|*.cpp";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                    this.Text = saveFileDialog1.FileName;

                }

            }

            if (cs == true)
            {
                saveFileDialog1.Filter = "C# Dosya Formati|*.cs";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                    this.Text = saveFileDialog1.FileName;

                }

            }

            Application.Exit();

        }

        private void yazıTipiToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (fontDialog1.ShowDialog() == DialogResult.OK)  //secılen ıslemde kullanıcının tamam a yada ıptale basmasına gore if döngüsüne girer 
                richTextBox1.SelectionFont = fontDialog1.Font;

        }

        private void yazıRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (colorDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionColor = colorDialog1.Color;

        }

        private void zeminRengiToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            DialogResult arkaplan = colorDialog1.ShowDialog();
            if (arkaplan == DialogResult.OK)
            {

                richTextBox1.BackColor = colorDialog1.Color;

            }

        }
        private void cikisToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

    }

}
