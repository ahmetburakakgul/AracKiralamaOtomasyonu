namespace Rent_A_Car
{
    partial class Form1
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
            this.lblKullanıcıGirisi = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnKucult = new System.Windows.Forms.Button();
            this.txtKullanıcıAdı = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.panelKullanıcı = new System.Windows.Forms.Panel();
            this.panelParola = new System.Windows.Forms.Panel();
            this.lblsiremiunuttum = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnKullanıcıKayıt = new System.Windows.Forms.Button();
            this.pbKilit = new System.Windows.Forms.PictureBox();
            this.pbKullanıcı = new System.Windows.Forms.PictureBox();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKilit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKullanıcı)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.lblKullanıcıGirisi);
            this.panel1.Controls.Add(this.btnKapat);
            this.panel1.Controls.Add(this.btnKucult);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 35);
            this.panel1.TabIndex = 0;
            // 
            // lblKullanıcıGirisi
            // 
            this.lblKullanıcıGirisi.AutoSize = true;
            this.lblKullanıcıGirisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lblKullanıcıGirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanıcıGirisi.ForeColor = System.Drawing.Color.White;
            this.lblKullanıcıGirisi.Location = new System.Drawing.Point(27, 8);
            this.lblKullanıcıGirisi.Name = "lblKullanıcıGirisi";
            this.lblKullanıcıGirisi.Size = new System.Drawing.Size(117, 20);
            this.lblKullanıcıGirisi.TabIndex = 9;
            this.lblKullanıcıGirisi.Text = "Kullanıcı Girişi";
            this.lblKullanıcıGirisi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblKullanıcıGirisi_MouseDown);
            // 
            // btnKapat
            // 
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(269, 3);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(28, 30);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = "X";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnKucult
            // 
            this.btnKucult.FlatAppearance.BorderSize = 0;
            this.btnKucult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKucult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKucult.ForeColor = System.Drawing.Color.White;
            this.btnKucult.Location = new System.Drawing.Point(235, -2);
            this.btnKucult.Name = "btnKucult";
            this.btnKucult.Size = new System.Drawing.Size(28, 30);
            this.btnKucult.TabIndex = 0;
            this.btnKucult.Text = "_";
            this.btnKucult.UseVisualStyleBackColor = true;
            this.btnKucult.Click += new System.EventHandler(this.btnKucult_Click);
            // 
            // txtKullanıcıAdı
            // 
            this.txtKullanıcıAdı.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtKullanıcıAdı.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKullanıcıAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullanıcıAdı.ForeColor = System.Drawing.Color.White;
            this.txtKullanıcıAdı.Location = new System.Drawing.Point(62, 203);
            this.txtKullanıcıAdı.Name = "txtKullanıcıAdı";
            this.txtKullanıcıAdı.Size = new System.Drawing.Size(202, 20);
            this.txtKullanıcıAdı.TabIndex = 5;
            this.txtKullanıcıAdı.Text = "ahmetburak";
            this.txtKullanıcıAdı.TextChanged += new System.EventHandler(this.txtKullanıcıAdı_TextChanged);
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.ForeColor = System.Drawing.Color.White;
            this.txtSifre.Location = new System.Drawing.Point(61, 259);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(202, 20);
            this.txtSifre.TabIndex = 6;
            this.txtSifre.Text = "159357246";
            this.txtSifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSifre_KeyPress);
            // 
            // panelKullanıcı
            // 
            this.panelKullanıcı.BackColor = System.Drawing.Color.White;
            this.panelKullanıcı.ForeColor = System.Drawing.Color.White;
            this.panelKullanıcı.Location = new System.Drawing.Point(61, 229);
            this.panelKullanıcı.Name = "panelKullanıcı";
            this.panelKullanıcı.Size = new System.Drawing.Size(202, 1);
            this.panelKullanıcı.TabIndex = 7;
            // 
            // panelParola
            // 
            this.panelParola.BackColor = System.Drawing.Color.White;
            this.panelParola.ForeColor = System.Drawing.Color.White;
            this.panelParola.Location = new System.Drawing.Point(61, 285);
            this.panelParola.Name = "panelParola";
            this.panelParola.Size = new System.Drawing.Size(202, 1);
            this.panelParola.TabIndex = 8;
            // 
            // lblsiremiunuttum
            // 
            this.lblsiremiunuttum.AutoSize = true;
            this.lblsiremiunuttum.ForeColor = System.Drawing.Color.White;
            this.lblsiremiunuttum.Location = new System.Drawing.Point(85, 289);
            this.lblsiremiunuttum.Name = "lblsiremiunuttum";
            this.lblsiremiunuttum.Size = new System.Drawing.Size(120, 17);
            this.lblsiremiunuttum.TabIndex = 9;
            this.lblsiremiunuttum.Text = "Parolamı Unuttum";
            this.lblsiremiunuttum.DoubleClick += new System.EventHandler(this.lblsiremiunuttum_DoubleClick);
            // 
            // btnGiris
            // 
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.ForeColor = System.Drawing.Color.White;
            this.btnGiris.Location = new System.Drawing.Point(31, 367);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(232, 40);
            this.btnGiris.TabIndex = 10;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnKullanıcıKayıt
            // 
            this.btnKullanıcıKayıt.BackgroundImage = global::Rent_A_Car.Properties.Resources.uye_ol;
            this.btnKullanıcıKayıt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKullanıcıKayıt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKullanıcıKayıt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnKullanıcıKayıt.Location = new System.Drawing.Point(135, 151);
            this.btnKullanıcıKayıt.Name = "btnKullanıcıKayıt";
            this.btnKullanıcıKayıt.Size = new System.Drawing.Size(33, 33);
            this.btnKullanıcıKayıt.TabIndex = 11;
            this.btnKullanıcıKayıt.Text = "button2";
            this.btnKullanıcıKayıt.UseVisualStyleBackColor = true;
            this.btnKullanıcıKayıt.Click += new System.EventHandler(this.btnKullanıcıKayıt_Click);
            // 
            // pbKilit
            // 
            this.pbKilit.Image = global::Rent_A_Car.Properties.Resources._115_512;
            this.pbKilit.Location = new System.Drawing.Point(31, 259);
            this.pbKilit.Name = "pbKilit";
            this.pbKilit.Size = new System.Drawing.Size(25, 27);
            this.pbKilit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbKilit.TabIndex = 4;
            this.pbKilit.TabStop = false;
            // 
            // pbKullanıcı
            // 
            this.pbKullanıcı.Image = global::Rent_A_Car.Properties.Resources.login_user_password_username;
            this.pbKullanıcı.Location = new System.Drawing.Point(31, 203);
            this.pbKullanıcı.Name = "pbKullanıcı";
            this.pbKullanıcı.Size = new System.Drawing.Size(25, 27);
            this.pbKullanıcı.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbKullanıcı.TabIndex = 3;
            this.pbKullanıcı.TabStop = false;
            // 
            // pbResim
            // 
            this.pbResim.Image = global::Rent_A_Car.Properties.Resources.personel;
            this.pbResim.Location = new System.Drawing.Point(112, 70);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(75, 75);
            this.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbResim.TabIndex = 2;
            this.pbResim.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(300, 419);
            this.Controls.Add(this.btnKullanıcıKayıt);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.lblsiremiunuttum);
            this.Controls.Add(this.panelParola);
            this.Controls.Add(this.panelKullanıcı);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullanıcıAdı);
            this.Controls.Add(this.pbKilit);
            this.Controls.Add(this.pbKullanıcı);
            this.Controls.Add(this.pbResim);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKilit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKullanıcı)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnKucult;
        private System.Windows.Forms.PictureBox pbResim;
        private System.Windows.Forms.PictureBox pbKullanıcı;
        private System.Windows.Forms.PictureBox pbKilit;
        private System.Windows.Forms.TextBox txtKullanıcıAdı;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblKullanıcıGirisi;
        private System.Windows.Forms.Panel panelKullanıcı;
        private System.Windows.Forms.Panel panelParola;
        private System.Windows.Forms.Label lblsiremiunuttum;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnKullanıcıKayıt;
    }
}

