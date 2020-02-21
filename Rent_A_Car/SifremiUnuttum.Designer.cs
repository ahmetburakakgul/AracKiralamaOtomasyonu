namespace Rent_A_Car
{
    partial class SifremiUnuttum
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
            this.btnTamam = new System.Windows.Forms.Button();
            this.txtGuvenlikSorusu = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.lblGuvenlikSifUn = new System.Windows.Forms.Label();
            this.lblKullanıcıAdıSifUn = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnKucult = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnTamam);
            this.panel1.Controls.Add(this.txtGuvenlikSorusu);
            this.panel1.Controls.Add(this.txtKullaniciAdi);
            this.panel1.Controls.Add(this.lblGuvenlikSifUn);
            this.panel1.Controls.Add(this.lblKullanıcıAdıSifUn);
            this.panel1.Location = new System.Drawing.Point(2, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 230);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(86, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Bilgileri Doldurunuz";
            // 
            // btnTamam
            // 
            this.btnTamam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnTamam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTamam.Location = new System.Drawing.Point(224, 177);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(177, 37);
            this.btnTamam.TabIndex = 16;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = false;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // txtGuvenlikSorusu
            // 
            this.txtGuvenlikSorusu.Location = new System.Drawing.Point(224, 125);
            this.txtGuvenlikSorusu.Name = "txtGuvenlikSorusu";
            this.txtGuvenlikSorusu.Size = new System.Drawing.Size(177, 22);
            this.txtGuvenlikSorusu.TabIndex = 15;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(224, 84);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(177, 22);
            this.txtKullaniciAdi.TabIndex = 14;
            this.txtKullaniciAdi.TextChanged += new System.EventHandler(this.txtKullaniciAdi_TextChanged);
            // 
            // lblGuvenlikSifUn
            // 
            this.lblGuvenlikSifUn.AutoSize = true;
            this.lblGuvenlikSifUn.BackColor = System.Drawing.Color.Transparent;
            this.lblGuvenlikSifUn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGuvenlikSifUn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGuvenlikSifUn.Location = new System.Drawing.Point(10, 125);
            this.lblGuvenlikSifUn.Name = "lblGuvenlikSifUn";
            this.lblGuvenlikSifUn.Size = new System.Drawing.Size(190, 25);
            this.lblGuvenlikSifUn.TabIndex = 13;
            this.lblGuvenlikSifUn.Text = "Güvenlik Sorusu  :";
            // 
            // lblKullanıcıAdıSifUn
            // 
            this.lblKullanıcıAdıSifUn.AutoSize = true;
            this.lblKullanıcıAdıSifUn.BackColor = System.Drawing.Color.Transparent;
            this.lblKullanıcıAdıSifUn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanıcıAdıSifUn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKullanıcıAdıSifUn.Location = new System.Drawing.Point(10, 84);
            this.lblKullanıcıAdıSifUn.Name = "lblKullanıcıAdıSifUn";
            this.lblKullanıcıAdıSifUn.Size = new System.Drawing.Size(199, 25);
            this.lblKullanıcıAdıSifUn.TabIndex = 12;
            this.lblKullanıcıAdıSifUn.Text = "Kullanıcı Adı         : ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnKapat);
            this.panel2.Controls.Add(this.btnKucult);
            this.panel2.Location = new System.Drawing.Point(-6, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(506, 37);
            this.panel2.TabIndex = 1;
            // 
            // btnKapat
            // 
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(473, 5);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(28, 30);
            this.btnKapat.TabIndex = 5;
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
            this.btnKucult.Location = new System.Drawing.Point(439, 0);
            this.btnKucult.Name = "btnKucult";
            this.btnKucult.Size = new System.Drawing.Size(28, 30);
            this.btnKucult.TabIndex = 4;
            this.btnKucult.Text = "_";
            this.btnKucult.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(18, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sifremi Unuttum";
            // 
            // SifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(497, 260);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SifremiUnuttum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SifremiUnuttum";
            this.Load += new System.EventHandler(this.SifremiUnuttum_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.TextBox txtGuvenlikSorusu;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label lblGuvenlikSifUn;
        private System.Windows.Forms.Label lblKullanıcıAdıSifUn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnKucult;
        private System.Windows.Forms.Label label2;
    }
}