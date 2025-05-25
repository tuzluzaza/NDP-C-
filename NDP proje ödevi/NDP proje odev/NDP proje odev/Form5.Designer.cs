namespace NDP_proje_odev
{
    partial class Form5
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
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            geri5 = new Button();
            label1 = new Label();
            goruntuleRandevuButton = new Button();
            cikis = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.None;
            listView1.BackColor = Color.LightSeaGreen;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            listView1.GridLines = true;
            listView1.Location = new Point(31, 158);
            listView1.Name = "listView1";
            listView1.Size = new Size(1323, 529);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "MÜŞTERİ NO";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "İSİM";
            columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "SOYİSİM";
            columnHeader3.Width = 140;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "TELEFON NO";
            columnHeader4.Width = 140;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "İŞLEM";
            columnHeader5.Width = 400;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "PERSONEL";
            columnHeader6.Width = 140;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "ÜCRET";
            columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "TARİH";
            columnHeader8.Width = 160;
            // 
            // geri5
            // 
            geri5.Anchor = AnchorStyles.None;
            geri5.Location = new Point(31, 40);
            geri5.Name = "geri5";
            geri5.Size = new Size(173, 40);
            geri5.TabIndex = 28;
            geri5.Text = "GERİ GİT";
            geri5.UseVisualStyleBackColor = true;
            geri5.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(466, 40);
            label1.Name = "label1";
            label1.Size = new Size(459, 46);
            label1.TabIndex = 34;
            label1.Text = "MENEKŞE GÜZELLİK MERKEZİ";
            // 
            // goruntuleRandevuButton
            // 
            goruntuleRandevuButton.Location = new Point(1191, 716);
            goruntuleRandevuButton.Name = "goruntuleRandevuButton";
            goruntuleRandevuButton.Size = new Size(121, 37);
            goruntuleRandevuButton.TabIndex = 35;
            goruntuleRandevuButton.Text = "GORUNTULE";
            goruntuleRandevuButton.UseVisualStyleBackColor = true;
            goruntuleRandevuButton.Click += goruntuleRandevuButton_Click;
            // 
            // cikis
            // 
            cikis.Location = new Point(1260, 48);
            cikis.Name = "cikis";
            cikis.Size = new Size(94, 38);
            cikis.TabIndex = 45;
            cikis.Text = "ÇIKIŞ";
            cikis.UseVisualStyleBackColor = true;
            cikis.Click += cikis_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1400, 765);
            Controls.Add(cikis);
            Controls.Add(goruntuleRandevuButton);
            Controls.Add(label1);
            Controls.Add(geri5);
            Controls.Add(listView1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
           
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button geri5;
        private Label label1;
        private ColumnHeader columnHeader7;
        private Button goruntuleRandevuButton;
        private ColumnHeader columnHeader8;
        private Button cikis;
    }
}