namespace Rent_A_Car
{
    partial class MüşteriKaydı
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.txtDogumYeri = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtGsmNo = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnVazgeç = new System.Windows.Forms.Button();
            this.dtDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtIl = new System.Windows.Forms.TextBox();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblGsm_No = new System.Windows.Forms.Label();
            this.lblIl = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.lblDogumYeri = new System.Windows.Forms.Label();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.lblSoyadi = new System.Windows.Forms.Label();
            this.lblAdi = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnKapat);
            this.panel1.Location = new System.Drawing.Point(-8, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 32);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Müşteri Kayıt";
            // 
            // btnKapat
            // 
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(375, 2);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(28, 30);
            this.btnKapat.TabIndex = 5;
            this.btnKapat.Text = "X";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // txtDogumYeri
            // 
            this.txtDogumYeri.Location = new System.Drawing.Point(162, 188);
            this.txtDogumYeri.Name = "txtDogumYeri";
            this.txtDogumYeri.Size = new System.Drawing.Size(200, 22);
            this.txtDogumYeri.TabIndex = 44;
            this.txtDogumYeri.TextChanged += new System.EventHandler(this.txtDogumYeri_TextChanged);
            this.txtDogumYeri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDogumYeri_KeyPress);
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(162, 324);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(202, 93);
            this.txtAdres.TabIndex = 43;
            this.txtAdres.TextChanged += new System.EventHandler(this.txtAdres_TextChanged);
            this.txtAdres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdres_KeyPress);
            // 
            // txtGsmNo
            // 
            this.txtGsmNo.Location = new System.Drawing.Point(160, 290);
            this.txtGsmNo.Name = "txtGsmNo";
            this.txtGsmNo.Size = new System.Drawing.Size(202, 22);
            this.txtGsmNo.TabIndex = 42;
            this.txtGsmNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGsmNo_KeyPress);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKaydet.Location = new System.Drawing.Point(266, 457);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(96, 35);
            this.btnKaydet.TabIndex = 41;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnVazgeç
            // 
            this.btnVazgeç.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnVazgeç.FlatAppearance.BorderSize = 0;
            this.btnVazgeç.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVazgeç.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVazgeç.Location = new System.Drawing.Point(162, 457);
            this.btnVazgeç.Name = "btnVazgeç";
            this.btnVazgeç.Size = new System.Drawing.Size(98, 35);
            this.btnVazgeç.TabIndex = 40;
            this.btnVazgeç.Text = "Vazgeç";
            this.btnVazgeç.UseVisualStyleBackColor = false;
            this.btnVazgeç.Click += new System.EventHandler(this.btnVazgeç_Click);
            // 
            // dtDogumTarihi
            // 
            this.dtDogumTarihi.Location = new System.Drawing.Point(162, 152);
            this.dtDogumTarihi.Name = "dtDogumTarihi";
            this.dtDogumTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtDogumTarihi.TabIndex = 39;
            // 
            // txtIl
            // 
            this.txtIl.Location = new System.Drawing.Point(162, 257);
            this.txtIl.Name = "txtIl";
            this.txtIl.Size = new System.Drawing.Size(200, 22);
            this.txtIl.TabIndex = 38;
            this.txtIl.TextChanged += new System.EventHandler(this.txtIl_TextChanged);
            this.txtIl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIl_KeyPress);
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(162, 221);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(200, 24);
            this.cmbCinsiyet.TabIndex = 37;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(162, 116);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(200, 22);
            this.txtSoyadi.TabIndex = 36;
            this.txtSoyadi.TextChanged += new System.EventHandler(this.txtSoyadi_TextChanged);
            this.txtSoyadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoyadi_KeyPress);
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(162, 82);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(200, 22);
            this.txtAdi.TabIndex = 35;
            this.txtAdi.TextChanged += new System.EventHandler(this.txtAdi_TextChanged);
            this.txtAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdi_KeyPress);
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(162, 51);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(200, 22);
            this.txtTC.TabIndex = 34;
            this.txtTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTC_KeyPress);
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAdres.Location = new System.Drawing.Point(3, 324);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(58, 20);
            this.lblAdres.TabIndex = 33;
            this.lblAdres.Text = "Adres";
            // 
            // lblGsm_No
            // 
            this.lblGsm_No.AutoSize = true;
            this.lblGsm_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGsm_No.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGsm_No.Location = new System.Drawing.Point(3, 290);
            this.lblGsm_No.Name = "lblGsm_No";
            this.lblGsm_No.Size = new System.Drawing.Size(77, 20);
            this.lblGsm_No.TabIndex = 32;
            this.lblGsm_No.Text = "Gsm No";
            // 
            // lblIl
            // 
            this.lblIl.AutoSize = true;
            this.lblIl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIl.Location = new System.Drawing.Point(3, 257);
            this.lblIl.Name = "lblIl";
            this.lblIl.Size = new System.Drawing.Size(19, 20);
            this.lblIl.TabIndex = 31;
            this.lblIl.Text = "İl";
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCinsiyet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCinsiyet.Location = new System.Drawing.Point(3, 221);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(77, 20);
            this.lblCinsiyet.TabIndex = 30;
            this.lblCinsiyet.Text = "Cinsiyet";
            // 
            // lblDogumYeri
            // 
            this.lblDogumYeri.AutoSize = true;
            this.lblDogumYeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogumYeri.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDogumYeri.Location = new System.Drawing.Point(3, 188);
            this.lblDogumYeri.Name = "lblDogumYeri";
            this.lblDogumYeri.Size = new System.Drawing.Size(107, 20);
            this.lblDogumYeri.TabIndex = 29;
            this.lblDogumYeri.Text = "Doğum Yeri";
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.AutoSize = true;
            this.lblDogumTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogumTarihi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDogumTarihi.Location = new System.Drawing.Point(3, 157);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(122, 20);
            this.lblDogumTarihi.TabIndex = 28;
            this.lblDogumTarihi.Text = "Doğum Tarihi";
            // 
            // lblSoyadi
            // 
            this.lblSoyadi.AutoSize = true;
            this.lblSoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyadi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSoyadi.Location = new System.Drawing.Point(3, 121);
            this.lblSoyadi.Name = "lblSoyadi";
            this.lblSoyadi.Size = new System.Drawing.Size(77, 20);
            this.lblSoyadi.TabIndex = 27;
            this.lblSoyadi.Text = "SOYADI";
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAdi.Location = new System.Drawing.Point(3, 82);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(40, 20);
            this.lblAdi.TabIndex = 26;
            this.lblAdi.Text = "ADI";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTC.Location = new System.Drawing.Point(3, 51);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(132, 20);
            this.lblTC.TabIndex = 25;
            this.lblTC.Text = "TC KIMLIK NO";
            // 
            // MüşteriKaydı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(396, 499);
            this.Controls.Add(this.txtDogumYeri);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtGsmNo);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnVazgeç);
            this.Controls.Add(this.dtDogumTarihi);
            this.Controls.Add(this.txtIl);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblGsm_No);
            this.Controls.Add(this.lblIl);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.lblDogumYeri);
            this.Controls.Add(this.lblDogumTarihi);
            this.Controls.Add(this.lblSoyadi);
            this.Controls.Add(this.lblAdi);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MüşteriKaydı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MüşteriKaydı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MüşteriKaydı_FormClosed);
            this.Load += new System.EventHandler(this.MüşteriKaydı_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.TextBox txtDogumYeri;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtGsmNo;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnVazgeç;
        private System.Windows.Forms.DateTimePicker dtDogumTarihi;
        private System.Windows.Forms.TextBox txtIl;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblGsm_No;
        private System.Windows.Forms.Label lblIl;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Label lblDogumYeri;
        private System.Windows.Forms.Label lblDogumTarihi;
        private System.Windows.Forms.Label lblSoyadi;
        private System.Windows.Forms.Label lblAdi;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label label1;
    }
}