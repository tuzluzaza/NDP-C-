namespace NDP_proje_odev
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            musterisilTextbox = new TextBox();
            label7 = new Label();
            geri4 = new Button();
            randevusilButton = new Button();
            label1 = new Label();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            button1 = new Button();
            cikis = new Button();
            SuspendLayout();
            // 
            // musterisilTextbox
            // 
            musterisilTextbox.Anchor = AnchorStyles.None;
            musterisilTextbox.Location = new Point(1117, 285);
            musterisilTextbox.Name = "musterisilTextbox";
            musterisilTextbox.Size = new Size(125, 27);
            musterisilTextbox.TabIndex = 29;
            musterisilTextbox.KeyPress += musterisilTextbox_KeyPress;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(765, 281);
            label7.Name = "label7";
            label7.Size = new Size(321, 31);
            label7.TabIndex = 30;
            label7.Text = "SİLİNECEK MÜŞTERİ NO GİRİN";
            // 
            // geri4
            // 
            geri4.Anchor = AnchorStyles.None;
            geri4.Location = new Point(31, 40);
            geri4.Name = "geri4";
            geri4.Size = new Size(173, 40);
            geri4.TabIndex = 31;
            geri4.Text = "GERİ GİT";
            geri4.UseVisualStyleBackColor = true;
            geri4.Click += button2_Click_1;
            // 
            // randevusilButton
            // 
            randevusilButton.Anchor = AnchorStyles.None;
            randevusilButton.Location = new Point(1117, 382);
            randevusilButton.Name = "randevusilButton";
            randevusilButton.Size = new Size(125, 53);
            randevusilButton.TabIndex = 32;
            randevusilButton.Text = "RANDEVUYU SİL";
            randevusilButton.UseVisualStyleBackColor = true;
            randevusilButton.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(466, 40);
            label1.Name = "label1";
            label1.Size = new Size(459, 46);
            label1.TabIndex = 33;
            label1.Text = "MENEKŞE GÜZELLİK MERKEZİ";
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.None;
            listView1.BackColor = Color.LightSeaGreen;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            listView1.GridLines = true;
            listView1.Location = new Point(202, 216);
            listView1.Name = "listView1";
            listView1.Size = new Size(482, 388);
            listView1.TabIndex = 34;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "MÜŞTERİ NO";
            columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "İSİM";
            columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "SOYİSİM";
            columnHeader3.Width = 160;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "TELEFON NO";
            columnHeader4.Width = 160;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "İŞLEM";
            columnHeader5.Width = 160;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "PERSONEL";
            columnHeader6.Width = 160;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "ÜCRET";
            columnHeader7.Width = 160;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "TARİH";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(526, 632);
            button1.Name = "button1";
            button1.Size = new Size(158, 56);
            button1.TabIndex = 35;
            button1.Text = "RANDEVULARI GÖSTER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // cikis
            // 
            cikis.Location = new Point(1224, 48);
            cikis.Name = "cikis";
            cikis.Size = new Size(94, 38);
            cikis.TabIndex = 45;
            cikis.Text = "ÇIKIŞ";
            cikis.UseVisualStyleBackColor = true;
            cikis.Click += cikis_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1400, 765);
            Controls.Add(cikis);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(label1);
            Controls.Add(randevusilButton);
            Controls.Add(geri4);
            Controls.Add(musterisilTextbox);
            Controls.Add(label7);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
        
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox musterisilTextbox;
        private Label label7;
        private Button geri4;
        private Button randevusilButton;
        private Label label1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private Button button1;
        private Button cikis;
    }
}