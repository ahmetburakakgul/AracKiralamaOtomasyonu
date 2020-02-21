namespace Rent_A_Car
{
    partial class YeniAraçKaydı
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
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.txtKira = new System.Windows.Forms.TextBox();
            this.lblKira = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnVazgeç = new System.Windows.Forms.Button();
            this.cmbRenk = new System.Windows.Forms.ComboBox();
            this.dtGüncellemeTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtEklemeTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtModelYılı = new System.Windows.Forms.TextBox();
            this.cmbVites = new System.Windows.Forms.ComboBox();
            this.cmbYakıt = new System.Windows.Forms.ComboBox();
            this.txtMotorHacmi = new System.Windows.Forms.TextBox();
            this.txtPlakaNo = new System.Windows.Forms.TextBox();
            this.lblRenk = new System.Windows.Forms.Label();
            this.lblGuncellemeTarihi = new System.Windows.Forms.Label();
            this.lblEklemeTarihi = new System.Windows.Forms.Label();
            this.lblModelYili = new System.Windows.Forms.Label();
            this.lblVitesTuru = new System.Windows.Forms.Label();
            this.lblYakıtTuru = new System.Windows.Forms.Label();
            this.lblMotorHacim = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMarka = new System.Windows.Forms.Label();
            this.lblPLakaNo = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnyakıttürü = new System.Windows.Forms.Button();
            this.btnvitestürü = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnKapat);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 35);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(11, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Araç Kayıt";
            // 
            // btnKapat
            // 
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(536, 2);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(28, 30);
            this.btnKapat.TabIndex = 6;
            this.btnKapat.Text = "X";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // cmbModel
            // 
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(188, 131);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(200, 24);
            this.cmbModel.TabIndex = 56;
            this.cmbModel.SelectedIndexChanged += new System.EventHandler(this.cmbModel_SelectedIndexChanged);
            // 
            // cmbMarka
            // 
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Location = new System.Drawing.Point(188, 95);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(200, 24);
            this.cmbMarka.TabIndex = 55;
            this.cmbMarka.SelectedIndexChanged += new System.EventHandler(this.cmbMarka_SelectedIndexChanged);
            // 
            // txtKira
            // 
            this.txtKira.Location = new System.Drawing.Point(188, 411);
            this.txtKira.Name = "txtKira";
            this.txtKira.Size = new System.Drawing.Size(200, 22);
            this.txtKira.TabIndex = 54;
            // 
            // lblKira
            // 
            this.lblKira.AutoSize = true;
            this.lblKira.BackColor = System.Drawing.Color.Transparent;
            this.lblKira.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKira.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKira.Location = new System.Drawing.Point(18, 413);
            this.lblKira.Name = "lblKira";
            this.lblKira.Size = new System.Drawing.Size(100, 20);
            this.lblKira.TabIndex = 53;
            this.lblKira.Text = "Kira Ücreti";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(425, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 52;
            this.button1.Text = "Resim Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKaydet.Location = new System.Drawing.Point(12, 516);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(114, 40);
            this.btnKaydet.TabIndex = 50;
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
            this.btnVazgeç.Location = new System.Drawing.Point(429, 516);
            this.btnVazgeç.Name = "btnVazgeç";
            this.btnVazgeç.Size = new System.Drawing.Size(120, 40);
            this.btnVazgeç.TabIndex = 49;
            this.btnVazgeç.Text = "Vazgeç";
            this.btnVazgeç.UseVisualStyleBackColor = false;
            this.btnVazgeç.Click += new System.EventHandler(this.btnVazgeç_Click);
            // 
            // cmbRenk
            // 
            this.cmbRenk.FormattingEnabled = true;
            this.cmbRenk.Items.AddRange(new object[] {
            "Beyaz",
            "Siyah",
            "Kırmızı",
            "Mor ",
            "Pembe",
            "Sarı",
            "Kahverengi",
            "Lacivert",
            "Gri",
            "Turuncu",
            "Yeşil ",
            "Bordo",
            "Turkuaz ",
            "Açık mavi",
            "Mavi"});
            this.cmbRenk.Location = new System.Drawing.Point(188, 371);
            this.cmbRenk.Name = "cmbRenk";
            this.cmbRenk.Size = new System.Drawing.Size(200, 24);
            this.cmbRenk.TabIndex = 48;
            // 
            // dtGüncellemeTarihi
            // 
            this.dtGüncellemeTarihi.Location = new System.Drawing.Point(188, 337);
            this.dtGüncellemeTarihi.Name = "dtGüncellemeTarihi";
            this.dtGüncellemeTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtGüncellemeTarihi.TabIndex = 47;
            // 
            // dtEklemeTarihi
            // 
            this.dtEklemeTarihi.Location = new System.Drawing.Point(188, 303);
            this.dtEklemeTarihi.Name = "dtEklemeTarihi";
            this.dtEklemeTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtEklemeTarihi.TabIndex = 46;
            // 
            // txtModelYılı
            // 
            this.txtModelYılı.Location = new System.Drawing.Point(188, 270);
            this.txtModelYılı.Name = "txtModelYılı";
            this.txtModelYılı.Size = new System.Drawing.Size(200, 22);
            this.txtModelYılı.TabIndex = 45;
            this.txtModelYılı.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtModelYılı_KeyPress);
            // 
            // cmbVites
            // 
            this.cmbVites.FormattingEnabled = true;
            this.cmbVites.Location = new System.Drawing.Point(188, 234);
            this.cmbVites.Name = "cmbVites";
            this.cmbVites.Size = new System.Drawing.Size(200, 24);
            this.cmbVites.TabIndex = 44;
            this.cmbVites.SelectedIndexChanged += new System.EventHandler(this.cmbVites_SelectedIndexChanged);
            // 
            // cmbYakıt
            // 
            this.cmbYakıt.FormattingEnabled = true;
            this.cmbYakıt.Location = new System.Drawing.Point(188, 201);
            this.cmbYakıt.Name = "cmbYakıt";
            this.cmbYakıt.Size = new System.Drawing.Size(200, 24);
            this.cmbYakıt.TabIndex = 43;
            this.cmbYakıt.SelectedIndexChanged += new System.EventHandler(this.cmbYakıt_SelectedIndexChanged);
            // 
            // txtMotorHacmi
            // 
            this.txtMotorHacmi.Location = new System.Drawing.Point(188, 165);
            this.txtMotorHacmi.Name = "txtMotorHacmi";
            this.txtMotorHacmi.Size = new System.Drawing.Size(200, 22);
            this.txtMotorHacmi.TabIndex = 42;
            this.txtMotorHacmi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMotorHacmi_KeyPress);
            // 
            // txtPlakaNo
            // 
            this.txtPlakaNo.Location = new System.Drawing.Point(188, 64);
            this.txtPlakaNo.Name = "txtPlakaNo";
            this.txtPlakaNo.Size = new System.Drawing.Size(200, 22);
            this.txtPlakaNo.TabIndex = 41;
            this.txtPlakaNo.TextChanged += new System.EventHandler(this.txtPlakaNo_TextChanged);
            // 
            // lblRenk
            // 
            this.lblRenk.AutoSize = true;
            this.lblRenk.BackColor = System.Drawing.Color.Transparent;
            this.lblRenk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRenk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRenk.Location = new System.Drawing.Point(15, 373);
            this.lblRenk.Name = "lblRenk";
            this.lblRenk.Size = new System.Drawing.Size(51, 20);
            this.lblRenk.TabIndex = 40;
            this.lblRenk.Text = "Renk";
            // 
            // lblGuncellemeTarihi
            // 
            this.lblGuncellemeTarihi.AutoSize = true;
            this.lblGuncellemeTarihi.BackColor = System.Drawing.Color.Transparent;
            this.lblGuncellemeTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGuncellemeTarihi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGuncellemeTarihi.Location = new System.Drawing.Point(15, 339);
            this.lblGuncellemeTarihi.Name = "lblGuncellemeTarihi";
            this.lblGuncellemeTarihi.Size = new System.Drawing.Size(153, 20);
            this.lblGuncellemeTarihi.TabIndex = 39;
            this.lblGuncellemeTarihi.Text = "Son Bakım Tarihi";
            // 
            // lblEklemeTarihi
            // 
            this.lblEklemeTarihi.AutoSize = true;
            this.lblEklemeTarihi.BackColor = System.Drawing.Color.Transparent;
            this.lblEklemeTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEklemeTarihi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEklemeTarihi.Location = new System.Drawing.Point(15, 305);
            this.lblEklemeTarihi.Name = "lblEklemeTarihi";
            this.lblEklemeTarihi.Size = new System.Drawing.Size(124, 20);
            this.lblEklemeTarihi.TabIndex = 38;
            this.lblEklemeTarihi.Text = "Ekleme Tarihi";
            // 
            // lblModelYili
            // 
            this.lblModelYili.AutoSize = true;
            this.lblModelYili.BackColor = System.Drawing.Color.Transparent;
            this.lblModelYili.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblModelYili.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblModelYili.Location = new System.Drawing.Point(15, 272);
            this.lblModelYili.Name = "lblModelYili";
            this.lblModelYili.Size = new System.Drawing.Size(91, 20);
            this.lblModelYili.TabIndex = 37;
            this.lblModelYili.Text = "Model Yılı";
            // 
            // lblVitesTuru
            // 
            this.lblVitesTuru.AutoSize = true;
            this.lblVitesTuru.BackColor = System.Drawing.Color.Transparent;
            this.lblVitesTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVitesTuru.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVitesTuru.Location = new System.Drawing.Point(15, 236);
            this.lblVitesTuru.Name = "lblVitesTuru";
            this.lblVitesTuru.Size = new System.Drawing.Size(96, 20);
            this.lblVitesTuru.TabIndex = 36;
            this.lblVitesTuru.Text = "Vites Türü";
            // 
            // lblYakıtTuru
            // 
            this.lblYakıtTuru.AutoSize = true;
            this.lblYakıtTuru.BackColor = System.Drawing.Color.Transparent;
            this.lblYakıtTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYakıtTuru.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblYakıtTuru.Location = new System.Drawing.Point(15, 203);
            this.lblYakıtTuru.Name = "lblYakıtTuru";
            this.lblYakıtTuru.Size = new System.Drawing.Size(94, 20);
            this.lblYakıtTuru.TabIndex = 35;
            this.lblYakıtTuru.Text = "Yakıt Türü";
            // 
            // lblMotorHacim
            // 
            this.lblMotorHacim.AutoSize = true;
            this.lblMotorHacim.BackColor = System.Drawing.Color.Transparent;
            this.lblMotorHacim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMotorHacim.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMotorHacim.Location = new System.Drawing.Point(15, 172);
            this.lblMotorHacim.Name = "lblMotorHacim";
            this.lblMotorHacim.Size = new System.Drawing.Size(117, 20);
            this.lblMotorHacim.TabIndex = 34;
            this.lblMotorHacim.Text = "Motor Hacmi";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.BackColor = System.Drawing.Color.Transparent;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblModel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblModel.Location = new System.Drawing.Point(15, 136);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(59, 20);
            this.lblModel.TabIndex = 33;
            this.lblModel.Text = "Model";
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.BackColor = System.Drawing.Color.Transparent;
            this.lblMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMarka.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMarka.Location = new System.Drawing.Point(15, 97);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(72, 20);
            this.lblMarka.TabIndex = 32;
            this.lblMarka.Text = "Marka  ";
            // 
            // lblPLakaNo
            // 
            this.lblPLakaNo.AutoSize = true;
            this.lblPLakaNo.BackColor = System.Drawing.Color.Transparent;
            this.lblPLakaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPLakaNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPLakaNo.Location = new System.Drawing.Point(15, 66);
            this.lblPLakaNo.Name = "lblPLakaNo";
            this.lblPLakaNo.Size = new System.Drawing.Size(102, 20);
            this.lblPLakaNo.TabIndex = 31;
            this.lblPLakaNo.Text = "Plaka No   ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(401, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // btnyakıttürü
            // 
            this.btnyakıttürü.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnyakıttürü.FlatAppearance.BorderSize = 0;
            this.btnyakıttürü.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnyakıttürü.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnyakıttürü.Location = new System.Drawing.Point(132, 516);
            this.btnyakıttürü.Name = "btnyakıttürü";
            this.btnyakıttürü.Size = new System.Drawing.Size(145, 40);
            this.btnyakıttürü.TabIndex = 57;
            this.btnyakıttürü.Text = "Yakıt Türü Ekle";
            this.btnyakıttürü.UseVisualStyleBackColor = false;
            this.btnyakıttürü.Click += new System.EventHandler(this.btnyakıttürü_Click);
            // 
            // btnvitestürü
            // 
            this.btnvitestürü.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnvitestürü.FlatAppearance.BorderSize = 0;
            this.btnvitestürü.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvitestürü.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnvitestürü.Location = new System.Drawing.Point(283, 516);
            this.btnvitestürü.Name = "btnvitestürü";
            this.btnvitestürü.Size = new System.Drawing.Size(140, 40);
            this.btnvitestürü.TabIndex = 58;
            this.btnvitestürü.Text = "Vites Türü Ekle";
            this.btnvitestürü.UseVisualStyleBackColor = false;
            this.btnvitestürü.Click += new System.EventHandler(this.btnvitestürü_Click);
            // 
            // YeniAraçKaydı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(561, 568);
            this.Controls.Add(this.btnvitestürü);
            this.Controls.Add(this.btnyakıttürü);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.cmbMarka);
            this.Controls.Add(this.txtKira);
            this.Controls.Add(this.lblKira);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnVazgeç);
            this.Controls.Add(this.cmbRenk);
            this.Controls.Add(this.dtGüncellemeTarihi);
            this.Controls.Add(this.dtEklemeTarihi);
            this.Controls.Add(this.txtModelYılı);
            this.Controls.Add(this.cmbVites);
            this.Controls.Add(this.cmbYakıt);
            this.Controls.Add(this.txtMotorHacmi);
            this.Controls.Add(this.txtPlakaNo);
            this.Controls.Add(this.lblRenk);
            this.Controls.Add(this.lblGuncellemeTarihi);
            this.Controls.Add(this.lblEklemeTarihi);
            this.Controls.Add(this.lblModelYili);
            this.Controls.Add(this.lblVitesTuru);
            this.Controls.Add(this.lblYakıtTuru);
            this.Controls.Add(this.lblMotorHacim);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMarka);
            this.Controls.Add(this.lblPLakaNo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YeniAraçKaydı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YeniAraçKaydı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.YeniAraçKaydı_FormClosed);
            this.Load += new System.EventHandler(this.YeniAraçKaydı_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.TextBox txtKira;
        private System.Windows.Forms.Label lblKira;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnVazgeç;
        private System.Windows.Forms.ComboBox cmbRenk;
        private System.Windows.Forms.DateTimePicker dtGüncellemeTarihi;
        private System.Windows.Forms.DateTimePicker dtEklemeTarihi;
        private System.Windows.Forms.TextBox txtModelYılı;
        private System.Windows.Forms.ComboBox cmbVites;
        private System.Windows.Forms.ComboBox cmbYakıt;
        private System.Windows.Forms.TextBox txtMotorHacmi;
        private System.Windows.Forms.TextBox txtPlakaNo;
        private System.Windows.Forms.Label lblRenk;
        private System.Windows.Forms.Label lblGuncellemeTarihi;
        private System.Windows.Forms.Label lblEklemeTarihi;
        private System.Windows.Forms.Label lblModelYili;
        private System.Windows.Forms.Label lblVitesTuru;
        private System.Windows.Forms.Label lblYakıtTuru;
        private System.Windows.Forms.Label lblMotorHacim;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label lblPLakaNo;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnyakıttürü;
        private System.Windows.Forms.Button btnvitestürü;
    }
}