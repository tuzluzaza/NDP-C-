namespace ndp_2.ödev
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
            this.CarpismaSecenekleriComboBox = new System.Windows.Forms.ComboBox();
            this.ykordinati1 = new System.Windows.Forms.Label();
            this.ykordinattext1 = new System.Windows.Forms.TextBox();
            this.zkordinattext1 = new System.Windows.Forms.TextBox();
            this.zkordinati1 = new System.Windows.Forms.Label();
            this.xkordinattext1 = new System.Windows.Forms.TextBox();
            this.xkordinati1 = new System.Windows.Forms.Label();
            this.derinliktext1 = new System.Windows.Forms.TextBox();
            this.derinlik1 = new System.Windows.Forms.Label();
            this.genisliktext1 = new System.Windows.Forms.TextBox();
            this.genislik1 = new System.Windows.Forms.Label();
            this.yuksekliktext1 = new System.Windows.Forms.TextBox();
            this.yukseklik1 = new System.Windows.Forms.Label();
            this.yuksekliktext2 = new System.Windows.Forms.TextBox();
            this.yukseklik2 = new System.Windows.Forms.Label();
            this.genisliktext2 = new System.Windows.Forms.TextBox();
            this.genislik2 = new System.Windows.Forms.Label();
            this.derinliktext2 = new System.Windows.Forms.TextBox();
            this.derinlik2 = new System.Windows.Forms.Label();
            this.xkordinattext2 = new System.Windows.Forms.TextBox();
            this.zkordinattext2 = new System.Windows.Forms.TextBox();
            this.ykordinattext2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.xkordinati2 = new System.Windows.Forms.Label();
            this.ykordinati2 = new System.Windows.Forms.Label();
            this.zkordinati2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.yaricap1 = new System.Windows.Forms.Label();
            this.yaricaptext1 = new System.Windows.Forms.TextBox();
            this.yaricaptext2 = new System.Windows.Forms.TextBox();
            this.yaricap2 = new System.Windows.Forms.Label();
            this.cisim1grupbox = new System.Windows.Forms.GroupBox();
            this.cisim2grupbox = new System.Windows.Forms.GroupBox();
            this.carpismasecenekleri = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cisim1grupbox.SuspendLayout();
            this.cisim2grupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CarpismaSecenekleriComboBox
            // 
            this.CarpismaSecenekleriComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CarpismaSecenekleriComboBox.BackColor = System.Drawing.Color.DarkGray;
            this.CarpismaSecenekleriComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CarpismaSecenekleriComboBox.DropDownWidth = 1500;
            this.CarpismaSecenekleriComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CarpismaSecenekleriComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CarpismaSecenekleriComboBox.FormattingEnabled = true;
            this.CarpismaSecenekleriComboBox.ItemHeight = 20;
            this.CarpismaSecenekleriComboBox.Items.AddRange(new object[] {
            "1.) Nokta, Dikdörtgen çarpışma denetimi",
            "2.) Nokta, çember çarpışma denetimi",
            "3.) Dikdörtgen, dikdörtgen çarpışma denetimi",
            "4.) Dikdörtgen, çember çarpışma denetimi",
            "5.) Çember, çember çarpışma denetimi",
            "6.) Nokta, Küre çarpışma denetimi",
            "7.) Nokta, dikdörtgen prizma çarpışma denetimi",
            "8.) Nokta, Silindir çarpışma denetimi",
            "9.) Silindir, silindir çarpışma denetimi",
            "10.) Küre, küre çarpışma denetimi",
            "11.) Küre silindir çarpışma denetimi",
            "12.) Yüzey, küre çarpışma denetimi",
            "13.) Yüzey, dikdörtgen prizma çarpışma denetimi",
            "14.) Yüzey silindir çarpışma denetimi",
            "15.) Küre, dikdörtgen prizma çarpışma denetimi",
            "16.) Dikdörtgen prizma, dikdörtgen prizma çarpışma denetimi"});
            this.CarpismaSecenekleriComboBox.Location = new System.Drawing.Point(12, 29);
            this.CarpismaSecenekleriComboBox.Name = "CarpismaSecenekleriComboBox";
            this.CarpismaSecenekleriComboBox.Size = new System.Drawing.Size(1215, 28);
            this.CarpismaSecenekleriComboBox.TabIndex = 2;
            this.CarpismaSecenekleriComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ykordinati1
            // 
            this.ykordinati1.AutoSize = true;
            this.ykordinati1.Location = new System.Drawing.Point(250, 37);
            this.ykordinati1.Name = "ykordinati1";
            this.ykordinati1.Size = new System.Drawing.Size(19, 20);
            this.ykordinati1.TabIndex = 3;
            this.ykordinati1.Text = "Y";
            // 
            // ykordinattext1
            // 
            this.ykordinattext1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ykordinattext1.Location = new System.Drawing.Point(209, 73);
            this.ykordinattext1.Name = "ykordinattext1";
            this.ykordinattext1.Size = new System.Drawing.Size(100, 27);
            this.ykordinattext1.TabIndex = 4;
            // 
            // zkordinattext1
            // 
            this.zkordinattext1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.zkordinattext1.Location = new System.Drawing.Point(359, 73);
            this.zkordinattext1.Name = "zkordinattext1";
            this.zkordinattext1.Size = new System.Drawing.Size(100, 27);
            this.zkordinattext1.TabIndex = 6;
            // 
            // zkordinati1
            // 
            this.zkordinati1.AutoSize = true;
            this.zkordinati1.Location = new System.Drawing.Point(398, 37);
            this.zkordinati1.Name = "zkordinati1";
            this.zkordinati1.Size = new System.Drawing.Size(18, 20);
            this.zkordinati1.TabIndex = 5;
            this.zkordinati1.Text = "Z";
            // 
            // xkordinattext1
            // 
            this.xkordinattext1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.xkordinattext1.Location = new System.Drawing.Point(62, 73);
            this.xkordinattext1.Name = "xkordinattext1";
            this.xkordinattext1.Size = new System.Drawing.Size(100, 27);
            this.xkordinattext1.TabIndex = 8;
            // 
            // xkordinati1
            // 
            this.xkordinati1.AutoSize = true;
            this.xkordinati1.Location = new System.Drawing.Point(100, 37);
            this.xkordinati1.Name = "xkordinati1";
            this.xkordinati1.Size = new System.Drawing.Size(25, 20);
            this.xkordinati1.TabIndex = 7;
            this.xkordinati1.Text = "X ";
            // 
            // derinliktext1
            // 
            this.derinliktext1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.derinliktext1.Location = new System.Drawing.Point(359, 148);
            this.derinliktext1.Name = "derinliktext1";
            this.derinliktext1.Size = new System.Drawing.Size(100, 27);
            this.derinliktext1.TabIndex = 10;
            // 
            // derinlik1
            // 
            this.derinlik1.AutoSize = true;
            this.derinlik1.Location = new System.Drawing.Point(365, 117);
            this.derinlik1.Name = "derinlik1";
            this.derinlik1.Size = new System.Drawing.Size(86, 20);
            this.derinlik1.TabIndex = 9;
            this.derinlik1.Text = "DERİNLİK";
            // 
            // genisliktext1
            // 
            this.genisliktext1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.genisliktext1.Location = new System.Drawing.Point(209, 148);
            this.genisliktext1.Name = "genisliktext1";
            this.genisliktext1.Size = new System.Drawing.Size(100, 27);
            this.genisliktext1.TabIndex = 12;
            // 
            // genislik1
            // 
            this.genislik1.AutoSize = true;
            this.genislik1.Location = new System.Drawing.Point(215, 117);
            this.genislik1.Name = "genislik1";
            this.genislik1.Size = new System.Drawing.Size(85, 20);
            this.genislik1.TabIndex = 11;
            this.genislik1.Text = "GENİŞLİK";
            // 
            // yuksekliktext1
            // 
            this.yuksekliktext1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.yuksekliktext1.Location = new System.Drawing.Point(62, 148);
            this.yuksekliktext1.Name = "yuksekliktext1";
            this.yuksekliktext1.Size = new System.Drawing.Size(100, 27);
            this.yuksekliktext1.TabIndex = 14;
            // 
            // yukseklik1
            // 
            this.yukseklik1.AutoSize = true;
            this.yukseklik1.Location = new System.Drawing.Point(64, 117);
            this.yukseklik1.Name = "yukseklik1";
            this.yukseklik1.Size = new System.Drawing.Size(100, 20);
            this.yukseklik1.TabIndex = 13;
            this.yukseklik1.Text = "YÜKSEKLİK";
            // 
            // yuksekliktext2
            // 
            this.yuksekliktext2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.yuksekliktext2.Location = new System.Drawing.Point(62, 160);
            this.yuksekliktext2.Name = "yuksekliktext2";
            this.yuksekliktext2.Size = new System.Drawing.Size(100, 27);
            this.yuksekliktext2.TabIndex = 26;
            // 
            // yukseklik2
            // 
            this.yukseklik2.AutoSize = true;
            this.yukseklik2.Location = new System.Drawing.Point(64, 130);
            this.yukseklik2.Name = "yukseklik2";
            this.yukseklik2.Size = new System.Drawing.Size(100, 20);
            this.yukseklik2.TabIndex = 25;
            this.yukseklik2.Text = "YÜKSEKLİK";
            // 
            // genisliktext2
            // 
            this.genisliktext2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.genisliktext2.Location = new System.Drawing.Point(209, 160);
            this.genisliktext2.Name = "genisliktext2";
            this.genisliktext2.Size = new System.Drawing.Size(100, 27);
            this.genisliktext2.TabIndex = 24;
            // 
            // genislik2
            // 
            this.genislik2.AutoSize = true;
            this.genislik2.Location = new System.Drawing.Point(215, 130);
            this.genislik2.Name = "genislik2";
            this.genislik2.Size = new System.Drawing.Size(85, 20);
            this.genislik2.TabIndex = 23;
            this.genislik2.Text = "GENİŞLİK";
            // 
            // derinliktext2
            // 
            this.derinliktext2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.derinliktext2.Location = new System.Drawing.Point(359, 160);
            this.derinliktext2.Name = "derinliktext2";
            this.derinliktext2.Size = new System.Drawing.Size(100, 27);
            this.derinliktext2.TabIndex = 22;
            // 
            // derinlik2
            // 
            this.derinlik2.AutoSize = true;
            this.derinlik2.Location = new System.Drawing.Point(365, 130);
            this.derinlik2.Name = "derinlik2";
            this.derinlik2.Size = new System.Drawing.Size(86, 20);
            this.derinlik2.TabIndex = 21;
            this.derinlik2.Text = "DERİNLİK";
            // 
            // xkordinattext2
            // 
            this.xkordinattext2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.xkordinattext2.Location = new System.Drawing.Point(62, 75);
            this.xkordinattext2.Name = "xkordinattext2";
            this.xkordinattext2.Size = new System.Drawing.Size(100, 27);
            this.xkordinattext2.TabIndex = 20;
            // 
            // zkordinattext2
            // 
            this.zkordinattext2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.zkordinattext2.Location = new System.Drawing.Point(359, 75);
            this.zkordinattext2.Name = "zkordinattext2";
            this.zkordinattext2.Size = new System.Drawing.Size(100, 27);
            this.zkordinattext2.TabIndex = 18;
            // 
            // ykordinattext2
            // 
            this.ykordinattext2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ykordinattext2.Location = new System.Drawing.Point(209, 75);
            this.ykordinattext2.Name = "ykordinattext2";
            this.ykordinattext2.Size = new System.Drawing.Size(100, 27);
            this.ykordinattext2.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.Location = new System.Drawing.Point(12, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1215, 778);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // xkordinati2
            // 
            this.xkordinati2.AutoSize = true;
            this.xkordinati2.Location = new System.Drawing.Point(100, 45);
            this.xkordinati2.Name = "xkordinati2";
            this.xkordinati2.Size = new System.Drawing.Size(20, 20);
            this.xkordinati2.TabIndex = 30;
            this.xkordinati2.Text = "X";
            // 
            // ykordinati2
            // 
            this.ykordinati2.AutoSize = true;
            this.ykordinati2.Location = new System.Drawing.Point(250, 45);
            this.ykordinati2.Name = "ykordinati2";
            this.ykordinati2.Size = new System.Drawing.Size(19, 20);
            this.ykordinati2.TabIndex = 31;
            this.ykordinati2.Text = "Y";
            // 
            // zkordinati2
            // 
            this.zkordinati2.AutoSize = true;
            this.zkordinati2.Location = new System.Drawing.Point(398, 45);
            this.zkordinati2.Name = "zkordinati2";
            this.zkordinati2.Size = new System.Drawing.Size(18, 20);
            this.zkordinati2.TabIndex = 32;
            this.zkordinati2.Text = "Z";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Location = new System.Drawing.Point(1471, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 46);
            this.button1.TabIndex = 33;
            this.button1.Text = "ÇARPIŞMAYI BAŞLAT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // yaricap1
            // 
            this.yaricap1.AutoSize = true;
            this.yaricap1.Location = new System.Drawing.Point(73, 191);
            this.yaricap1.Name = "yaricap1";
            this.yaricap1.Size = new System.Drawing.Size(80, 20);
            this.yaricap1.TabIndex = 34;
            this.yaricap1.Text = "YARIÇAP";
            // 
            // yaricaptext1
            // 
            this.yaricaptext1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.yaricaptext1.Location = new System.Drawing.Point(62, 219);
            this.yaricaptext1.Name = "yaricaptext1";
            this.yaricaptext1.Size = new System.Drawing.Size(100, 27);
            this.yaricaptext1.TabIndex = 35;
            // 
            // yaricaptext2
            // 
            this.yaricaptext2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.yaricaptext2.Location = new System.Drawing.Point(62, 231);
            this.yaricaptext2.Name = "yaricaptext2";
            this.yaricaptext2.Size = new System.Drawing.Size(100, 27);
            this.yaricaptext2.TabIndex = 37;
            // 
            // yaricap2
            // 
            this.yaricap2.AutoSize = true;
            this.yaricap2.Location = new System.Drawing.Point(73, 199);
            this.yaricap2.Name = "yaricap2";
            this.yaricap2.Size = new System.Drawing.Size(80, 20);
            this.yaricap2.TabIndex = 36;
            this.yaricap2.Text = "YARIÇAP";
            // 
            // cisim1grupbox
            // 
            this.cisim1grupbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cisim1grupbox.BackColor = System.Drawing.Color.DarkGray;
            this.cisim1grupbox.Controls.Add(this.genisliktext1);
            this.cisim1grupbox.Controls.Add(this.ykordinati1);
            this.cisim1grupbox.Controls.Add(this.ykordinattext1);
            this.cisim1grupbox.Controls.Add(this.zkordinati1);
            this.cisim1grupbox.Controls.Add(this.yaricaptext1);
            this.cisim1grupbox.Controls.Add(this.zkordinattext1);
            this.cisim1grupbox.Controls.Add(this.yaricap1);
            this.cisim1grupbox.Controls.Add(this.xkordinati1);
            this.cisim1grupbox.Controls.Add(this.xkordinattext1);
            this.cisim1grupbox.Controls.Add(this.derinlik1);
            this.cisim1grupbox.Controls.Add(this.derinliktext1);
            this.cisim1grupbox.Controls.Add(this.genislik1);
            this.cisim1grupbox.Controls.Add(this.yukseklik1);
            this.cisim1grupbox.Controls.Add(this.yuksekliktext1);
            this.cisim1grupbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cisim1grupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cisim1grupbox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cisim1grupbox.Location = new System.Drawing.Point(1298, 74);
            this.cisim1grupbox.Name = "cisim1grupbox";
            this.cisim1grupbox.Size = new System.Drawing.Size(523, 286);
            this.cisim1grupbox.TabIndex = 38;
            this.cisim1grupbox.TabStop = false;
            this.cisim1grupbox.Text = "1.CİSİM";
            // 
            // cisim2grupbox
            // 
            this.cisim2grupbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cisim2grupbox.BackColor = System.Drawing.Color.DarkGray;
            this.cisim2grupbox.Controls.Add(this.ykordinattext2);
            this.cisim2grupbox.Controls.Add(this.yaricaptext2);
            this.cisim2grupbox.Controls.Add(this.zkordinattext2);
            this.cisim2grupbox.Controls.Add(this.yaricap2);
            this.cisim2grupbox.Controls.Add(this.xkordinattext2);
            this.cisim2grupbox.Controls.Add(this.derinlik2);
            this.cisim2grupbox.Controls.Add(this.zkordinati2);
            this.cisim2grupbox.Controls.Add(this.derinliktext2);
            this.cisim2grupbox.Controls.Add(this.ykordinati2);
            this.cisim2grupbox.Controls.Add(this.genislik2);
            this.cisim2grupbox.Controls.Add(this.xkordinati2);
            this.cisim2grupbox.Controls.Add(this.genisliktext2);
            this.cisim2grupbox.Controls.Add(this.yukseklik2);
            this.cisim2grupbox.Controls.Add(this.yuksekliktext2);
            this.cisim2grupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cisim2grupbox.Location = new System.Drawing.Point(1298, 557);
            this.cisim2grupbox.Name = "cisim2grupbox";
            this.cisim2grupbox.Size = new System.Drawing.Size(523, 295);
            this.cisim2grupbox.TabIndex = 39;
            this.cisim2grupbox.TabStop = false;
            this.cisim2grupbox.Text = "2. CİSİM";
            // 
            // carpismasecenekleri
            // 
            this.carpismasecenekleri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.carpismasecenekleri.AutoSize = true;
            this.carpismasecenekleri.Location = new System.Drawing.Point(12, 10);
            this.carpismasecenekleri.Name = "carpismasecenekleri";
            this.carpismasecenekleri.Size = new System.Drawing.Size(171, 16);
            this.carpismasecenekleri.TabIndex = 40;
            this.carpismasecenekleri.Text = "ÇARPIŞMA SEÇENEKLERİ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1869, 880);
            this.Controls.Add(this.carpismasecenekleri);
            this.Controls.Add(this.cisim2grupbox);
            this.Controls.Add(this.cisim1grupbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CarpismaSecenekleriComboBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cisim1grupbox.ResumeLayout(false);
            this.cisim1grupbox.PerformLayout();
            this.cisim2grupbox.ResumeLayout(false);
            this.cisim2grupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CarpismaSecenekleriComboBox;
        private System.Windows.Forms.Label ykordinati1;
        private System.Windows.Forms.TextBox ykordinattext1;
        private System.Windows.Forms.TextBox zkordinattext1;
        private System.Windows.Forms.Label zkordinati1;
        private System.Windows.Forms.TextBox xkordinattext1;
        private System.Windows.Forms.Label xkordinati1;
        private System.Windows.Forms.TextBox derinliktext1;
        private System.Windows.Forms.Label derinlik1;
        private System.Windows.Forms.TextBox genisliktext1;
        private System.Windows.Forms.Label genislik1;
        private System.Windows.Forms.TextBox yuksekliktext1;
        private System.Windows.Forms.Label yukseklik1;
        private System.Windows.Forms.TextBox yuksekliktext2;
        private System.Windows.Forms.Label yukseklik2;
        private System.Windows.Forms.TextBox genisliktext2;
        private System.Windows.Forms.Label genislik2;
        private System.Windows.Forms.TextBox derinliktext2;
        private System.Windows.Forms.Label derinlik2;
        private System.Windows.Forms.TextBox xkordinattext2;
        private System.Windows.Forms.TextBox zkordinattext2;
        private System.Windows.Forms.TextBox ykordinattext2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label xkordinati2;
        private System.Windows.Forms.Label ykordinati2;
        private System.Windows.Forms.Label zkordinati2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label yaricap1;
        private System.Windows.Forms.TextBox yaricaptext1;
        private System.Windows.Forms.TextBox yaricaptext2;
        private System.Windows.Forms.Label yaricap2;
        private System.Windows.Forms.GroupBox cisim1grupbox;
        private System.Windows.Forms.GroupBox cisim2grupbox;
        private System.Windows.Forms.Label carpismasecenekleri;
    }
}

