/****************************************************************************
**					SAKARYA �N�VERS�TES�
**				B�LG�SAYAR VE B�L���M B�L�MLER� FAK�LTES�
**				    B�LG�SAYAR M�HEND�SL��� B�L�M�
**				   NESNEYE DAYALI PROGRAMLAMA DERS�
**					2023-2024 BAHAR D�NEM�
**	
**				�DEV NUMARASI..........: PROJE �devi
**				��RENC� ADI............: Abdullah An�l �obaner
**				��RENC� NUMARASI.......: B231210097
**              DERS�N ALINDI�I GRUP...: B
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NDP_proje_odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2ac = new Form2();
            this.Hide();
            form2ac.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3ac = new Form3();
            this.Hide();
            form3ac.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4ac = new Form4();
            this.Hide();
            form4ac.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 form5ac = new Form5();
            this.Hide();
            form5ac.Show();


        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
    }
}
