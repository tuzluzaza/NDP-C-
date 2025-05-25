namespace NDP_proje_odev
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button1 = new Button();
            cikis = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(466, 40);
            label1.Name = "label1";
            label1.Size = new Size(459, 46);
            label1.TabIndex = 0;
            label1.Text = "MENEKŞE GÜZELLİK MERKEZİ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F);
            label2.Location = new Point(46, 267);
            label2.Name = "label2";
            label2.Size = new Size(255, 31);
            label2.TabIndex = 1;
            label2.Text = "RANDEVU GÖRÜNTÜLE";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F);
            label3.Location = new Point(46, 210);
            label3.Name = "label3";
            label3.Size = new Size(153, 31);
            label3.TabIndex = 2;
            label3.Text = "RANDEVU SİL";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F);
            label4.Location = new Point(46, 140);
            label4.Name = "label4";
            label4.Size = new Size(221, 31);
            label4.TabIndex = 3;
            label4.Text = "RANDEVU DÜZENLE";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F);
            label5.Location = new Point(46, 70);
            label5.Name = "label5";
            label5.Size = new Size(222, 31);
            label5.TabIndex = 4;
            label5.Text = "RANDEVU OLUŞTUR";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.BackColor = Color.LightSeaGreen;
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(440, 230);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(521, 379);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Location = new Point(369, 142);
            button2.Name = "button2";
            button2.Size = new Size(110, 27);
            button2.TabIndex = 15;
            button2.Text = "SAYFAYA GİT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Location = new Point(369, 206);
            button3.Name = "button3";
            button3.Size = new Size(110, 27);
            button3.TabIndex = 14;
            button3.Text = "SAYFAYA GİT";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.Location = new Point(369, 269);
            button4.Name = "button4";
            button4.Size = new Size(110, 27);
            button4.TabIndex = 13;
            button4.Text = "SAYFAYA GİT";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(369, 70);
            button1.Name = "button1";
            button1.Size = new Size(110, 27);
            button1.TabIndex = 12;
            button1.Text = "SAYFAYA GİT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cikis
            // 
            cikis.Location = new Point(1244, 48);
            cikis.Name = "cikis";
            cikis.Size = new Size(94, 38);
            cikis.TabIndex = 7;
            cikis.Text = "ÇIKIŞ";
            cikis.UseVisualStyleBackColor = true;
            cikis.Click += cikis_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1400, 765);
            Controls.Add(cikis);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
          
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button cikis;
    }
}
