namespace _1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaAcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bicimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapistirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazıTipiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renkToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yazıRengiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zeminRengiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.acilacakDosyaTuruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilgilendirmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetÇıkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çizimKalemiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.richTextBox1.Location = new System.Drawing.Point(0, 63);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1819, 621);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gold;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.bicimToolStripMenuItem,
            this.yazıTipiToolStripMenuItem,
            this.renkToolStripMenuItem1,
            this.acilacakDosyaTuruToolStripMenuItem,
            this.bilgilendirmeToolStripMenuItem,
            this.kaydetÇıkToolStripMenuItem,
            this.çizimKalemiToolStripMenuItem,
            this.cikisToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1817, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripMenuItem,
            this.dosyaAcToolStripMenuItem,
            this.dosyaKaydetToolStripMenuItem});
            this.dosyaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dosyaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dosyaToolStripMenuItem.Image")));
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // yeniToolStripMenuItem
            // 
            this.yeniToolStripMenuItem.BackColor = System.Drawing.Color.Beige;
            this.yeniToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yeniToolStripMenuItem.Image")));
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.yeniToolStripMenuItem.Text = "Yeni";
            this.yeniToolStripMenuItem.Click += new System.EventHandler(this.yeniToolStripMenuItem_Click);
            // 
            // dosyaAcToolStripMenuItem
            // 
            this.dosyaAcToolStripMenuItem.BackColor = System.Drawing.Color.Beige;
            this.dosyaAcToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dosyaAcToolStripMenuItem.Image")));
            this.dosyaAcToolStripMenuItem.Name = "dosyaAcToolStripMenuItem";
            this.dosyaAcToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dosyaAcToolStripMenuItem.Text = "Dosya Aç";
            this.dosyaAcToolStripMenuItem.Click += new System.EventHandler(this.dosyaAcToolStripMenuItem_Click_1);
            // 
            // dosyaKaydetToolStripMenuItem
            // 
            this.dosyaKaydetToolStripMenuItem.AccessibleDescription = "txt";
            this.dosyaKaydetToolStripMenuItem.AccessibleName = "txt";
            this.dosyaKaydetToolStripMenuItem.BackColor = System.Drawing.Color.Beige;
            this.dosyaKaydetToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dosyaKaydetToolStripMenuItem.Image")));
            this.dosyaKaydetToolStripMenuItem.Name = "dosyaKaydetToolStripMenuItem";
            this.dosyaKaydetToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dosyaKaydetToolStripMenuItem.Tag = "txt";
            this.dosyaKaydetToolStripMenuItem.Text = "Dosya Kaydet";
            this.dosyaKaydetToolStripMenuItem.Click += new System.EventHandler(this.dosyaKaydetToolStripMenuItem_Click);
            // 
            // bicimToolStripMenuItem
            // 
            this.bicimToolStripMenuItem.BackColor = System.Drawing.Color.Gold;
            this.bicimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kesToolStripMenuItem,
            this.kopyalaToolStripMenuItem,
            this.yapistirToolStripMenuItem});
            this.bicimToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bicimToolStripMenuItem.Image")));
            this.bicimToolStripMenuItem.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bicimToolStripMenuItem.Name = "bicimToolStripMenuItem";
            this.bicimToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.bicimToolStripMenuItem.Text = "Biçim";
            // 
            // kesToolStripMenuItem
            // 
            this.kesToolStripMenuItem.BackColor = System.Drawing.Color.Beige;
            this.kesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kesToolStripMenuItem.Image")));
            this.kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            this.kesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kesToolStripMenuItem.Text = "Kes";
            this.kesToolStripMenuItem.Click += new System.EventHandler(this.kesToolStripMenuItem_Click);
            // 
            // kopyalaToolStripMenuItem
            // 
            this.kopyalaToolStripMenuItem.BackColor = System.Drawing.Color.Beige;
            this.kopyalaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kopyalaToolStripMenuItem.Image")));
            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kopyalaToolStripMenuItem.Text = "Kopyala";
            this.kopyalaToolStripMenuItem.Click += new System.EventHandler(this.kopyalaToolStripMenuItem_Click);
            // 
            // yapistirToolStripMenuItem
            // 
            this.yapistirToolStripMenuItem.BackColor = System.Drawing.Color.Beige;
            this.yapistirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yapistirToolStripMenuItem.Image")));
            this.yapistirToolStripMenuItem.Name = "yapistirToolStripMenuItem";
            this.yapistirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.yapistirToolStripMenuItem.Text = "Yapistir";
            this.yapistirToolStripMenuItem.Click += new System.EventHandler(this.yapistirToolStripMenuItem_Click);
            // 
            // yazıTipiToolStripMenuItem
            // 
            this.yazıTipiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yazıTipiToolStripMenuItem.Image")));
            this.yazıTipiToolStripMenuItem.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.yazıTipiToolStripMenuItem.Name = "yazıTipiToolStripMenuItem";
            this.yazıTipiToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.yazıTipiToolStripMenuItem.Text = "Yazı Tipi";
            this.yazıTipiToolStripMenuItem.Click += new System.EventHandler(this.yazıTipiToolStripMenuItem_Click);
            // 
            // renkToolStripMenuItem1
            // 
            this.renkToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yazıRengiToolStripMenuItem,
            this.zeminRengiToolStripMenuItem1});
            this.renkToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("renkToolStripMenuItem1.Image")));
            this.renkToolStripMenuItem1.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.renkToolStripMenuItem1.Name = "renkToolStripMenuItem1";
            this.renkToolStripMenuItem1.Size = new System.Drawing.Size(75, 24);
            this.renkToolStripMenuItem1.Text = "Renk";
            // 
            // yazıRengiToolStripMenuItem
            // 
            this.yazıRengiToolStripMenuItem.BackColor = System.Drawing.Color.Beige;
            this.yazıRengiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yazıRengiToolStripMenuItem.Image")));
            this.yazıRengiToolStripMenuItem.Name = "yazıRengiToolStripMenuItem";
            this.yazıRengiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.yazıRengiToolStripMenuItem.Text = "Yazı Rengi";
            this.yazıRengiToolStripMenuItem.Click += new System.EventHandler(this.yazıRengiToolStripMenuItem_Click);
            // 
            // zeminRengiToolStripMenuItem1
            // 
            this.zeminRengiToolStripMenuItem1.BackColor = System.Drawing.Color.Beige;
            this.zeminRengiToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("zeminRengiToolStripMenuItem1.Image")));
            this.zeminRengiToolStripMenuItem1.Name = "zeminRengiToolStripMenuItem1";
            this.zeminRengiToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.zeminRengiToolStripMenuItem1.Text = "Zemin Rengi";
            this.zeminRengiToolStripMenuItem1.Click += new System.EventHandler(this.zeminRengiToolStripMenuItem1_Click);
            // 
            // acilacakDosyaTuruToolStripMenuItem
            // 
            this.acilacakDosyaTuruToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cToolStripMenuItem,
            this.cToolStripMenuItem1,
            this.txtToolStripMenuItem});
            this.acilacakDosyaTuruToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("acilacakDosyaTuruToolStripMenuItem.Image")));
            this.acilacakDosyaTuruToolStripMenuItem.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.acilacakDosyaTuruToolStripMenuItem.Name = "acilacakDosyaTuruToolStripMenuItem";
            this.acilacakDosyaTuruToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.acilacakDosyaTuruToolStripMenuItem.Text = "Dosya Formatı";
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.BackColor = System.Drawing.Color.Beige;
            this.cToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cToolStripMenuItem.Image")));
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cToolStripMenuItem.Text = "C++";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.cppmToolStripMenuItem_Click);
            // 
            // cToolStripMenuItem1
            // 
            this.cToolStripMenuItem1.BackColor = System.Drawing.Color.Beige;
            this.cToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("cToolStripMenuItem1.Image")));
            this.cToolStripMenuItem1.Name = "cToolStripMenuItem1";
            this.cToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.cToolStripMenuItem1.Text = "C#";
            this.cToolStripMenuItem1.Click += new System.EventHandler(this.csToolStripMenuItem1_Click);
            // 
            // txtToolStripMenuItem
            // 
            this.txtToolStripMenuItem.BackColor = System.Drawing.Color.Beige;
            this.txtToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("txtToolStripMenuItem.Image")));
            this.txtToolStripMenuItem.Name = "txtToolStripMenuItem";
            this.txtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.txtToolStripMenuItem.Text = "txt";
            this.txtToolStripMenuItem.Click += new System.EventHandler(this.txtToolStripMenuItem_Click);
            // 
            // bilgilendirmeToolStripMenuItem
            // 
            this.bilgilendirmeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bilgilendirmeToolStripMenuItem.Image")));
            this.bilgilendirmeToolStripMenuItem.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bilgilendirmeToolStripMenuItem.Name = "bilgilendirmeToolStripMenuItem";
            this.bilgilendirmeToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.bilgilendirmeToolStripMenuItem.Text = "Bilgilendirme";
            this.bilgilendirmeToolStripMenuItem.Click += new System.EventHandler(this.bilgilendirmeToolStripMenuItem_Click);
            // 
            // kaydetÇıkToolStripMenuItem
            // 
            this.kaydetÇıkToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kaydetÇıkToolStripMenuItem.Image")));
            this.kaydetÇıkToolStripMenuItem.Margin = new System.Windows.Forms.Padding(360, 0, 0, 0);
            this.kaydetÇıkToolStripMenuItem.Name = "kaydetÇıkToolStripMenuItem";
            this.kaydetÇıkToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.kaydetÇıkToolStripMenuItem.Text = "Kaydet Çık";
            this.kaydetÇıkToolStripMenuItem.Click += new System.EventHandler(this.kaydetÇıkToolStripMenuItem_Click);
            // 
            // çizimKalemiToolStripMenuItem
            // 
            this.çizimKalemiToolStripMenuItem.Name = "çizimKalemiToolStripMenuItem";
            this.çizimKalemiToolStripMenuItem.Size = new System.Drawing.Size(14, 24);
            // 
            // cikisToolStripMenuItem1
            // 
            this.cikisToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("cikisToolStripMenuItem1.Image")));
            this.cikisToolStripMenuItem1.Name = "cikisToolStripMenuItem1";
            this.cikisToolStripMenuItem1.Size = new System.Drawing.Size(73, 24);
            this.cikisToolStripMenuItem1.Text = "Çıkış";
            this.cikisToolStripMenuItem1.Click += new System.EventHandler(this.cikisToolStripMenuItem1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1817, 716);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosyaAcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosyaKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bicimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapistirToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem bilgilendirmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acilacakDosyaTuruToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem cikisToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem txtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetÇıkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çizimKalemiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazıTipiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renkToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem yazıRengiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zeminRengiToolStripMenuItem1;
    }
}

