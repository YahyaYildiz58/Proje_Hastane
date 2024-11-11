namespace Proje_Hastane
{
    partial class FrmSekreterDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblAdSoyad = new System.Windows.Forms.Label();
            this.LblTCNO = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnDuyuruOlustur = new System.Windows.Forms.Button();
            this.RTboxDuyuru = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.ChboxDurum = new System.Windows.Forms.CheckBox();
            this.MtxtTCNO = new System.Windows.Forms.MaskedTextBox();
            this.CboxDoktor = new System.Windows.Forms.ComboBox();
            this.CboxBrans = new System.Windows.Forms.ComboBox();
            this.MboxSaat = new System.Windows.Forms.MaskedTextBox();
            this.MboxTarih = new System.Windows.Forms.MaskedTextBox();
            this.Txtid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.BtnRandevuPaneli = new System.Windows.Forms.Button();
            this.BtnBransPaneli = new System.Windows.Forms.Button();
            this.BtnDoktorPaneli = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblAdSoyad);
            this.groupBox1.Controls.Add(this.LblTCNO);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Bilgi";
            // 
            // LblAdSoyad
            // 
            this.LblAdSoyad.AutoSize = true;
            this.LblAdSoyad.Location = new System.Drawing.Point(79, 57);
            this.LblAdSoyad.Name = "LblAdSoyad";
            this.LblAdSoyad.Size = new System.Drawing.Size(46, 13);
            this.LblAdSoyad.TabIndex = 3;
            this.LblAdSoyad.Text = "Null Null";
            // 
            // LblTCNO
            // 
            this.LblTCNO.AutoSize = true;
            this.LblTCNO.Location = new System.Drawing.Point(79, 29);
            this.LblTCNO.Name = "LblTCNO";
            this.LblTCNO.Size = new System.Drawing.Size(73, 13);
            this.LblTCNO.TabIndex = 2;
            this.LblTCNO.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC No: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnDuyuruOlustur);
            this.groupBox2.Controls.Add(this.RTboxDuyuru);
            this.groupBox2.Location = new System.Drawing.Point(17, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 123);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // BtnDuyuruOlustur
            // 
            this.BtnDuyuruOlustur.Location = new System.Drawing.Point(6, 87);
            this.BtnDuyuruOlustur.Name = "BtnDuyuruOlustur";
            this.BtnDuyuruOlustur.Size = new System.Drawing.Size(171, 26);
            this.BtnDuyuruOlustur.TabIndex = 1;
            this.BtnDuyuruOlustur.Text = "Oluştur";
            this.BtnDuyuruOlustur.UseVisualStyleBackColor = true;
            this.BtnDuyuruOlustur.Click += new System.EventHandler(this.BtnDuyuruOlustur_Click);
            // 
            // RTboxDuyuru
            // 
            this.RTboxDuyuru.Location = new System.Drawing.Point(6, 19);
            this.RTboxDuyuru.Name = "RTboxDuyuru";
            this.RTboxDuyuru.Size = new System.Drawing.Size(171, 62);
            this.RTboxDuyuru.TabIndex = 0;
            this.RTboxDuyuru.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnKaydet);
            this.groupBox3.Controls.Add(this.ChboxDurum);
            this.groupBox3.Controls.Add(this.MtxtTCNO);
            this.groupBox3.Controls.Add(this.CboxDoktor);
            this.groupBox3.Controls.Add(this.CboxBrans);
            this.groupBox3.Controls.Add(this.MboxSaat);
            this.groupBox3.Controls.Add(this.MboxTarih);
            this.groupBox3.Controls.Add(this.Txtid);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(209, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(165, 218);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Paneli";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(55, 186);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(67, 26);
            this.BtnKaydet.TabIndex = 15;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // ChboxDurum
            // 
            this.ChboxDurum.AutoSize = true;
            this.ChboxDurum.Location = new System.Drawing.Point(55, 165);
            this.ChboxDurum.Name = "ChboxDurum";
            this.ChboxDurum.Size = new System.Drawing.Size(57, 17);
            this.ChboxDurum.TabIndex = 14;
            this.ChboxDurum.Text = "Durum";
            this.ChboxDurum.UseVisualStyleBackColor = true;
            // 
            // MtxtTCNO
            // 
            this.MtxtTCNO.Location = new System.Drawing.Point(55, 139);
            this.MtxtTCNO.Mask = "00000000000";
            this.MtxtTCNO.Name = "MtxtTCNO";
            this.MtxtTCNO.Size = new System.Drawing.Size(80, 20);
            this.MtxtTCNO.TabIndex = 13;
            this.MtxtTCNO.ValidatingType = typeof(int);
            // 
            // CboxDoktor
            // 
            this.CboxDoktor.FormattingEnabled = true;
            this.CboxDoktor.Location = new System.Drawing.Point(55, 114);
            this.CboxDoktor.Name = "CboxDoktor";
            this.CboxDoktor.Size = new System.Drawing.Size(80, 21);
            this.CboxDoktor.TabIndex = 12;
            // 
            // CboxBrans
            // 
            this.CboxBrans.FormattingEnabled = true;
            this.CboxBrans.Location = new System.Drawing.Point(55, 89);
            this.CboxBrans.Name = "CboxBrans";
            this.CboxBrans.Size = new System.Drawing.Size(80, 21);
            this.CboxBrans.TabIndex = 11;
            this.CboxBrans.SelectedIndexChanged += new System.EventHandler(this.CboxBrans_SelectedIndexChanged);
            // 
            // MboxSaat
            // 
            this.MboxSaat.Location = new System.Drawing.Point(55, 65);
            this.MboxSaat.Mask = "00:00";
            this.MboxSaat.Name = "MboxSaat";
            this.MboxSaat.Size = new System.Drawing.Size(80, 20);
            this.MboxSaat.TabIndex = 10;
            this.MboxSaat.ValidatingType = typeof(System.DateTime);
            // 
            // MboxTarih
            // 
            this.MboxTarih.Location = new System.Drawing.Point(55, 42);
            this.MboxTarih.Mask = "00/00/0000";
            this.MboxTarih.Name = "MboxTarih";
            this.MboxTarih.Size = new System.Drawing.Size(80, 20);
            this.MboxTarih.TabIndex = 9;
            this.MboxTarih.ValidatingType = typeof(System.DateTime);
            // 
            // Txtid
            // 
            this.Txtid.Location = new System.Drawing.Point(55, 17);
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(80, 20);
            this.Txtid.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "TC No: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Doktor: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Branş: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Saat: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tarih: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "ID: ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(380, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(337, 155);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branşlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(331, 136);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(380, 173);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(337, 132);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktorlar";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(331, 113);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.BtnRandevuPaneli);
            this.groupBox6.Controls.Add(this.BtnBransPaneli);
            this.groupBox6.Controls.Add(this.BtnDoktorPaneli);
            this.groupBox6.Location = new System.Drawing.Point(17, 235);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(357, 70);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hızlı Erişim";
            // 
            // BtnRandevuPaneli
            // 
            this.BtnRandevuPaneli.Location = new System.Drawing.Point(178, 21);
            this.BtnRandevuPaneli.Name = "BtnRandevuPaneli";
            this.BtnRandevuPaneli.Size = new System.Drawing.Size(91, 41);
            this.BtnRandevuPaneli.TabIndex = 2;
            this.BtnRandevuPaneli.Text = "Randevu Listesi";
            this.BtnRandevuPaneli.UseVisualStyleBackColor = true;
            this.BtnRandevuPaneli.Click += new System.EventHandler(this.BtnRandevuPaneli_Click);
            // 
            // BtnBransPaneli
            // 
            this.BtnBransPaneli.Location = new System.Drawing.Point(97, 21);
            this.BtnBransPaneli.Name = "BtnBransPaneli";
            this.BtnBransPaneli.Size = new System.Drawing.Size(75, 41);
            this.BtnBransPaneli.TabIndex = 1;
            this.BtnBransPaneli.Text = "Branş Paneli";
            this.BtnBransPaneli.UseVisualStyleBackColor = true;
            this.BtnBransPaneli.Click += new System.EventHandler(this.BtnBransPaneli_Click);
            // 
            // BtnDoktorPaneli
            // 
            this.BtnDoktorPaneli.Location = new System.Drawing.Point(9, 21);
            this.BtnDoktorPaneli.Name = "BtnDoktorPaneli";
            this.BtnDoktorPaneli.Size = new System.Drawing.Size(81, 41);
            this.BtnDoktorPaneli.TabIndex = 0;
            this.BtnDoktorPaneli.Text = "Doktor Paneli";
            this.BtnDoktorPaneli.UseVisualStyleBackColor = true;
            this.BtnDoktorPaneli.Click += new System.EventHandler(this.BtnDoktorPaneli_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Duyurular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmSekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(744, 309);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmSekreterDetay";
            this.Text = "Sekreter Detay";
            this.Load += new System.EventHandler(this.FrmSekreterDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblAdSoyad;
        private System.Windows.Forms.Label LblTCNO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnDuyuruOlustur;
        private System.Windows.Forms.RichTextBox RTboxDuyuru;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox MboxTarih;
        private System.Windows.Forms.TextBox Txtid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.CheckBox ChboxDurum;
        private System.Windows.Forms.MaskedTextBox MtxtTCNO;
        private System.Windows.Forms.ComboBox CboxDoktor;
        private System.Windows.Forms.ComboBox CboxBrans;
        private System.Windows.Forms.MaskedTextBox MboxSaat;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button BtnRandevuPaneli;
        private System.Windows.Forms.Button BtnBransPaneli;
        private System.Windows.Forms.Button BtnDoktorPaneli;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
    }
}