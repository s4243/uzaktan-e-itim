namespace Uzaktan_Egitim_Ogrenci_Takip_Sistemi
{
    partial class Ogrenci_Secimi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Panel panel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ogrenci_Secimi));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Orange;
            panel1.Controls.Add(this.label1);
            panel1.Controls.Add(this.comboBox1);
            panel1.Controls.Add(this.pictureBox1);
            panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Document, ((byte)(162)));
            panel1.ForeColor = System.Drawing.Color.DarkCyan;
            panel1.Location = new System.Drawing.Point(256, 78);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(447, 440);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(69, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Öğrenci Seçimi";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Tomato;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "110   Mehmet Kılıç",
            "112    Şifanur Keleş",
            "114    Ahmet Bulut",
            "116    Sebiha Dilek",
            "118    Cihat Arslan",
            "120    Kübra Güneş",
            "122    Ali Vefa",
            "124    Nurbanu Dilce",
            "126    Metin Karabulut",
            "128    İlknur Yılmaz",
            "130    Ayhan Gülbüz",
            "132    Rabia  Kaya",
            "134    Hüseyin Uzun",
            "136    Sacide  Özkan",
            "138    Can Toprak",
            "140    Betül Şahin",
            "142    Yasir  Karakaya",
            "144    Elanur Büyük",
            "146    Utku Durna",
            "148    Esra Sevinç"});
            this.comboBox1.Location = new System.Drawing.Point(69, 372);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(297, 41);
            this.comboBox1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(114, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 214);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Location = new System.Drawing.Point(240, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(21, 474);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkCyan;
            this.panel3.Location = new System.Drawing.Point(700, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 476);
            this.panel3.TabIndex = 4;
            // 
            // Ogrenci_Secimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Ogrenci_Secimi";
            this.Size = new System.Drawing.Size(1014, 563);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}
