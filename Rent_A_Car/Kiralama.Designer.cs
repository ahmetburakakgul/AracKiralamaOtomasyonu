namespace Rent_A_Car
{
    partial class Kiralama
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtGsM = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtTCKimlik = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGsmNo = new System.Windows.Forms.Label();
            this.lblSoyadi = new System.Windows.Forms.Label();
            this.lblAdı = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnrapor = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.lblRenk = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtModelyılı = new System.Windows.Forms.TextBox();
            this.txtVitesTuru = new System.Windows.Forms.TextBox();
            this.txtYakıtTuru = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.lblModelYılı = new System.Windows.Forms.Label();
            this.lblVites = new System.Windows.Forms.Label();
            this.lblYakit = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMarka = new System.Windows.Forms.Label();
            this.lblArac = new System.Windows.Forms.Label();
            this.cmbAracPlakası = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.dtDonus = new System.Windows.Forms.DateTimePicker();
            this.dtCıkıs = new System.Windows.Forms.DateTimePicker();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.txtGun = new System.Windows.Forms.TextBox();
            this.txtKiraÜcreti = new System.Windows.Forms.TextBox();
            this.cmbKira = new System.Windows.Forms.ComboBox();
            this.lblDonusTarihi = new System.Windows.Forms.Label();
            this.lblCıkısTarihi = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.lblGun = new System.Windows.Forms.Label();
            this.lblKiraUcreti = new System.Windows.Forms.Label();
            this.lblKiraSekli = new System.Windows.Forms.Label();
            this.btnAracTeslim = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnKapat);
            this.panel1.Location = new System.Drawing.Point(-4, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 34);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kiralama";
            // 
            // btnKapat
            // 
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(1131, 4);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(28, 30);
            this.btnKapat.TabIndex = 7;
            this.btnKapat.Text = "X";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(779, 283);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(168, 186);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(167, 85);
            this.txtAdres.TabIndex = 21;
            // 
            // txtGsM
            // 
            this.txtGsM.Location = new System.Drawing.Point(168, 156);
            this.txtGsM.Name = "txtGsM";
            this.txtGsM.Size = new System.Drawing.Size(167, 24);
            this.txtGsM.TabIndex = 20;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(168, 113);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(167, 24);
            this.txtSoyadi.TabIndex = 19;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(168, 72);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(167, 24);
            this.txtAdi.TabIndex = 18;
            // 
            // txtTCKimlik
            // 
            this.txtTCKimlik.Location = new System.Drawing.Point(168, 32);
            this.txtTCKimlik.Name = "txtTCKimlik";
            this.txtTCKimlik.Size = new System.Drawing.Size(167, 24);
            this.txtTCKimlik.TabIndex = 17;
            this.txtTCKimlik.TextChanged += new System.EventHandler(this.txtTCKimlik_TextChanged);
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(6, 184);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(51, 18);
            this.lblAdres.TabIndex = 16;
            this.lblAdres.Text = "Adres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(4, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "TC Kimlik Numarası";
            // 
            // lblGsmNo
            // 
            this.lblGsmNo.AutoSize = true;
            this.lblGsmNo.Location = new System.Drawing.Point(6, 146);
            this.lblGsmNo.Name = "lblGsmNo";
            this.lblGsmNo.Size = new System.Drawing.Size(71, 18);
            this.lblGsmNo.TabIndex = 14;
            this.lblGsmNo.Text = "Gsm No";
            // 
            // lblSoyadi
            // 
            this.lblSoyadi.AutoSize = true;
            this.lblSoyadi.Location = new System.Drawing.Point(6, 113);
            this.lblSoyadi.Name = "lblSoyadi";
            this.lblSoyadi.Size = new System.Drawing.Size(59, 18);
            this.lblSoyadi.TabIndex = 13;
            this.lblSoyadi.Text = "Soyadı";
            // 
            // lblAdı
            // 
            this.lblAdı.AutoSize = true;
            this.lblAdı.Location = new System.Drawing.Point(6, 78);
            this.lblAdı.Name = "lblAdı";
            this.lblAdı.Size = new System.Drawing.Size(31, 18);
            this.lblAdı.TabIndex = 12;
            this.lblAdı.Text = "Adı";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnrapor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblAdı);
            this.groupBox1.Controls.Add(this.lblSoyadi);
            this.groupBox1.Controls.Add(this.lblGsmNo);
            this.groupBox1.Controls.Add(this.lblAdres);
            this.groupBox1.Controls.Add(this.txtTCKimlik);
            this.groupBox1.Controls.Add(this.txtAdi);
            this.groupBox1.Controls.Add(this.txtSoyadi);
            this.groupBox1.Controls.Add(this.txtGsM);
            this.groupBox1.Controls.Add(this.txtAdres);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 340);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiralayan Bilgileri";
            // 
            // btnrapor
            // 
            this.btnrapor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnrapor.FlatAppearance.BorderSize = 0;
            this.btnrapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrapor.Location = new System.Drawing.Point(168, 305);
            this.btnrapor.Name = "btnrapor";
            this.btnrapor.Size = new System.Drawing.Size(167, 29);
            this.btnrapor.TabIndex = 83;
            this.btnrapor.Text = "Raporlama";
            this.btnrapor.UseVisualStyleBackColor = false;
            this.btnrapor.Click += new System.EventHandler(this.btnrapor_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.txtRenk);
            this.groupBox2.Controls.Add(this.lblRenk);
            this.groupBox2.Controls.Add(this.btnGuncelle);
            this.groupBox2.Controls.Add(this.btnEkle);
            this.groupBox2.Controls.Add(this.txtModelyılı);
            this.groupBox2.Controls.Add(this.txtVitesTuru);
            this.groupBox2.Controls.Add(this.txtYakıtTuru);
            this.groupBox2.Controls.Add(this.txtModel);
            this.groupBox2.Controls.Add(this.txtMarka);
            this.groupBox2.Controls.Add(this.lblModelYılı);
            this.groupBox2.Controls.Add(this.lblVites);
            this.groupBox2.Controls.Add(this.lblYakit);
            this.groupBox2.Controls.Add(this.lblModel);
            this.groupBox2.Controls.Add(this.lblMarka);
            this.groupBox2.Controls.Add(this.lblArac);
            this.groupBox2.Controls.Add(this.cmbAracPlakası);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(359, 325);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(432, 340);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kiralanan Araç Bilgileri";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(276, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 87;
            this.pictureBox1.TabStop = false;
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(103, 247);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(167, 24);
            this.txtRenk.TabIndex = 86;
            // 
            // lblRenk
            // 
            this.lblRenk.AutoSize = true;
            this.lblRenk.Location = new System.Drawing.Point(6, 252);
            this.lblRenk.Name = "lblRenk";
            this.lblRenk.Size = new System.Drawing.Size(47, 18);
            this.lblRenk.TabIndex = 62;
            this.lblRenk.Text = "Renk";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Location = new System.Drawing.Point(224, 292);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(202, 42);
            this.btnGuncelle.TabIndex = 83;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Location = new System.Drawing.Point(9, 292);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(209, 42);
            this.btnEkle.TabIndex = 82;
            this.btnEkle.Text = "Kayıt";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtModelyılı
            // 
            this.txtModelyılı.Location = new System.Drawing.Point(103, 213);
            this.txtModelyılı.Name = "txtModelyılı";
            this.txtModelyılı.Size = new System.Drawing.Size(167, 24);
            this.txtModelyılı.TabIndex = 70;
            // 
            // txtVitesTuru
            // 
            this.txtVitesTuru.Location = new System.Drawing.Point(103, 175);
            this.txtVitesTuru.Name = "txtVitesTuru";
            this.txtVitesTuru.Size = new System.Drawing.Size(167, 24);
            this.txtVitesTuru.TabIndex = 69;
            // 
            // txtYakıtTuru
            // 
            this.txtYakıtTuru.Location = new System.Drawing.Point(103, 137);
            this.txtYakıtTuru.Name = "txtYakıtTuru";
            this.txtYakıtTuru.Size = new System.Drawing.Size(167, 24);
            this.txtYakıtTuru.TabIndex = 68;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(103, 99);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(167, 24);
            this.txtModel.TabIndex = 67;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(103, 64);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(167, 24);
            this.txtMarka.TabIndex = 66;
            // 
            // lblModelYılı
            // 
            this.lblModelYılı.AutoSize = true;
            this.lblModelYılı.Location = new System.Drawing.Point(6, 216);
            this.lblModelYılı.Name = "lblModelYılı";
            this.lblModelYılı.Size = new System.Drawing.Size(81, 18);
            this.lblModelYılı.TabIndex = 65;
            this.lblModelYılı.Text = "Model Yılı";
            // 
            // lblVites
            // 
            this.lblVites.AutoSize = true;
            this.lblVites.Location = new System.Drawing.Point(6, 178);
            this.lblVites.Name = "lblVites";
            this.lblVites.Size = new System.Drawing.Size(84, 18);
            this.lblVites.TabIndex = 59;
            this.lblVites.Text = "Vites Türü";
            // 
            // lblYakit
            // 
            this.lblYakit.AutoSize = true;
            this.lblYakit.Location = new System.Drawing.Point(6, 140);
            this.lblYakit.Name = "lblYakit";
            this.lblYakit.Size = new System.Drawing.Size(84, 18);
            this.lblYakit.TabIndex = 58;
            this.lblYakit.Text = "Yakıt Türü";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(6, 102);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(54, 18);
            this.lblModel.TabIndex = 64;
            this.lblModel.Text = "Model";
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(6, 67);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(55, 18);
            this.lblMarka.TabIndex = 63;
            this.lblMarka.Text = "Marka";
            // 
            // lblArac
            // 
            this.lblArac.AutoSize = true;
            this.lblArac.Location = new System.Drawing.Point(6, 35);
            this.lblArac.Name = "lblArac";
            this.lblArac.Size = new System.Drawing.Size(61, 18);
            this.lblArac.TabIndex = 61;
            this.lblArac.Text = "Araçlar";
            // 
            // cmbAracPlakası
            // 
            this.cmbAracPlakası.FormattingEnabled = true;
            this.cmbAracPlakası.Location = new System.Drawing.Point(103, 32);
            this.cmbAracPlakası.Name = "cmbAracPlakası";
            this.cmbAracPlakası.Size = new System.Drawing.Size(167, 26);
            this.cmbAracPlakası.TabIndex = 57;
            this.cmbAracPlakası.SelectedIndexChanged += new System.EventHandler(this.cmbAracPlakası_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(797, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(341, 33);
            this.button1.TabIndex = 59;
            this.button1.Text = "Kayıtlı Müşteriler";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnHesapla);
            this.groupBox3.Controls.Add(this.btnTemizle);
            this.groupBox3.Controls.Add(this.dtDonus);
            this.groupBox3.Controls.Add(this.dtCıkıs);
            this.groupBox3.Controls.Add(this.txtToplamTutar);
            this.groupBox3.Controls.Add(this.txtGun);
            this.groupBox3.Controls.Add(this.txtKiraÜcreti);
            this.groupBox3.Controls.Add(this.cmbKira);
            this.groupBox3.Controls.Add(this.lblDonusTarihi);
            this.groupBox3.Controls.Add(this.lblCıkısTarihi);
            this.groupBox3.Controls.Add(this.lblToplamTutar);
            this.groupBox3.Controls.Add(this.lblGun);
            this.groupBox3.Controls.Add(this.lblKiraUcreti);
            this.groupBox3.Controls.Add(this.lblKiraSekli);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(798, 325);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 340);
            this.groupBox3.TabIndex = 59;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ücret Bilgileri";
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnHesapla.FlatAppearance.BorderSize = 0;
            this.btnHesapla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHesapla.Location = new System.Drawing.Point(9, 292);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(200, 42);
            this.btnHesapla.TabIndex = 99;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnTemizle.FlatAppearance.BorderSize = 0;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Location = new System.Drawing.Point(215, 292);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(125, 42);
            this.btnTemizle.TabIndex = 98;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            // 
            // dtDonus
            // 
            this.dtDonus.Location = new System.Drawing.Point(140, 209);
            this.dtDonus.Name = "dtDonus";
            this.dtDonus.Size = new System.Drawing.Size(200, 24);
            this.dtDonus.TabIndex = 97;
            // 
            // dtCıkıs
            // 
            this.dtCıkıs.Location = new System.Drawing.Point(140, 168);
            this.dtCıkıs.Name = "dtCıkıs";
            this.dtCıkıs.Size = new System.Drawing.Size(200, 24);
            this.dtCıkıs.TabIndex = 96;
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Location = new System.Drawing.Point(140, 130);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.Size = new System.Drawing.Size(200, 24);
            this.txtToplamTutar.TabIndex = 95;
            // 
            // txtGun
            // 
            this.txtGun.Location = new System.Drawing.Point(140, 95);
            this.txtGun.Name = "txtGun";
            this.txtGun.Size = new System.Drawing.Size(200, 24);
            this.txtGun.TabIndex = 94;
            // 
            // txtKiraÜcreti
            // 
            this.txtKiraÜcreti.Location = new System.Drawing.Point(140, 60);
            this.txtKiraÜcreti.Name = "txtKiraÜcreti";
            this.txtKiraÜcreti.Size = new System.Drawing.Size(200, 24);
            this.txtKiraÜcreti.TabIndex = 93;
            // 
            // cmbKira
            // 
            this.cmbKira.FormattingEnabled = true;
            this.cmbKira.Items.AddRange(new object[] {
            "Günlük",
            "Aylık",
            "Yıllık"});
            this.cmbKira.Location = new System.Drawing.Point(140, 25);
            this.cmbKira.Name = "cmbKira";
            this.cmbKira.Size = new System.Drawing.Size(200, 26);
            this.cmbKira.TabIndex = 92;
            this.cmbKira.SelectedIndexChanged += new System.EventHandler(this.cmbKira_SelectedIndexChanged);
            // 
            // lblDonusTarihi
            // 
            this.lblDonusTarihi.AutoSize = true;
            this.lblDonusTarihi.Location = new System.Drawing.Point(6, 209);
            this.lblDonusTarihi.Name = "lblDonusTarihi";
            this.lblDonusTarihi.Size = new System.Drawing.Size(104, 18);
            this.lblDonusTarihi.TabIndex = 91;
            this.lblDonusTarihi.Text = "Dönüş Tarihi";
            // 
            // lblCıkısTarihi
            // 
            this.lblCıkısTarihi.AutoSize = true;
            this.lblCıkısTarihi.Location = new System.Drawing.Point(6, 171);
            this.lblCıkısTarihi.Name = "lblCıkısTarihi";
            this.lblCıkısTarihi.Size = new System.Drawing.Size(93, 18);
            this.lblCıkısTarihi.TabIndex = 90;
            this.lblCıkısTarihi.Text = "Çıkış Tarihi";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(6, 133);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(113, 18);
            this.lblToplamTutar.TabIndex = 89;
            this.lblToplamTutar.Text = "Toplam Tutar ";
            // 
            // lblGun
            // 
            this.lblGun.AutoSize = true;
            this.lblGun.Location = new System.Drawing.Point(6, 95);
            this.lblGun.Name = "lblGun";
            this.lblGun.Size = new System.Drawing.Size(39, 18);
            this.lblGun.TabIndex = 88;
            this.lblGun.Text = "Gün";
            // 
            // lblKiraUcreti
            // 
            this.lblKiraUcreti.AutoSize = true;
            this.lblKiraUcreti.Location = new System.Drawing.Point(6, 60);
            this.lblKiraUcreti.Name = "lblKiraUcreti";
            this.lblKiraUcreti.Size = new System.Drawing.Size(88, 18);
            this.lblKiraUcreti.TabIndex = 86;
            this.lblKiraUcreti.Text = "Kira Ücreti";
            // 
            // lblKiraSekli
            // 
            this.lblKiraSekli.AutoSize = true;
            this.lblKiraSekli.Location = new System.Drawing.Point(6, 32);
            this.lblKiraSekli.Name = "lblKiraSekli";
            this.lblKiraSekli.Size = new System.Drawing.Size(80, 18);
            this.lblKiraSekli.TabIndex = 87;
            this.lblKiraSekli.Text = "Kira Şekli";
            // 
            // btnAracTeslim
            // 
            this.btnAracTeslim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAracTeslim.FlatAppearance.BorderSize = 0;
            this.btnAracTeslim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAracTeslim.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAracTeslim.Location = new System.Drawing.Point(798, 283);
            this.btnAracTeslim.Name = "btnAracTeslim";
            this.btnAracTeslim.Size = new System.Drawing.Size(340, 36);
            this.btnAracTeslim.TabIndex = 60;
            this.btnAracTeslim.Text = "Araç Teslim";
            this.btnAracTeslim.UseVisualStyleBackColor = false;
            this.btnAracTeslim.Click += new System.EventHandler(this.btnAracTeslim_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(797, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(341, 33);
            this.button2.TabIndex = 61;
            this.button2.Text = "Kayıtlı Araçlar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Kiralama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1155, 677);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAracTeslim);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Kiralama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kiralama";
            this.Load += new System.EventHandler(this.Kiralama_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtGsM;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtTCKimlik;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGsmNo;
        private System.Windows.Forms.Label lblSoyadi;
        private System.Windows.Forms.Label lblAdı;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.Label lblRenk;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtModelyılı;
        private System.Windows.Forms.TextBox txtVitesTuru;
        private System.Windows.Forms.TextBox txtYakıtTuru;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label lblModelYılı;
        private System.Windows.Forms.Label lblVites;
        private System.Windows.Forms.Label lblYakit;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label lblArac;
        private System.Windows.Forms.ComboBox cmbAracPlakası;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.DateTimePicker dtDonus;
        private System.Windows.Forms.DateTimePicker dtCıkıs;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.TextBox txtGun;
        private System.Windows.Forms.TextBox txtKiraÜcreti;
        private System.Windows.Forms.ComboBox cmbKira;
        private System.Windows.Forms.Label lblDonusTarihi;
        private System.Windows.Forms.Label lblCıkısTarihi;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Label lblGun;
        private System.Windows.Forms.Label lblKiraUcreti;
        private System.Windows.Forms.Label lblKiraSekli;
        private System.Windows.Forms.Button btnAracTeslim;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnrapor;
    }
}