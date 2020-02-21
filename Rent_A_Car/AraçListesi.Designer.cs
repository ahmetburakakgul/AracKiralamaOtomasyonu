namespace Rent_A_Car
{
    partial class AraçListesi
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnAracSil = new System.Windows.Forms.Button();
            this.btnvazgec = new System.Windows.Forms.Button();
            this.btnAracDüzenle = new System.Windows.Forms.Button();
            this.btnAracEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbAra = new System.Windows.Forms.ComboBox();
            this.tbAracArama = new System.Windows.Forms.TextBox();
            this.lblAracArama = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.btnMarkaEkle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnKapat);
            this.panel1.Location = new System.Drawing.Point(-1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1256, 36);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 24);
            this.label3.TabIndex = 59;
            this.label3.Text = "ARAÇ LİSTESİ";
            // 
            // btnKapat
            // 
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(1222, 6);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(31, 30);
            this.btnKapat.TabIndex = 8;
            this.btnKapat.Text = "X";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnAracSil
            // 
            this.btnAracSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAracSil.FlatAppearance.BorderSize = 0;
            this.btnAracSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAracSil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAracSil.Location = new System.Drawing.Point(491, 39);
            this.btnAracSil.Name = "btnAracSil";
            this.btnAracSil.Size = new System.Drawing.Size(251, 35);
            this.btnAracSil.TabIndex = 7;
            this.btnAracSil.Text = "Araç Sil";
            this.btnAracSil.UseVisualStyleBackColor = false;
            this.btnAracSil.Click += new System.EventHandler(this.btnAracSil_Click);
            // 
            // btnvazgec
            // 
            this.btnvazgec.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnvazgec.FlatAppearance.BorderSize = 0;
            this.btnvazgec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvazgec.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnvazgec.Location = new System.Drawing.Point(1022, 575);
            this.btnvazgec.Name = "btnvazgec";
            this.btnvazgec.Size = new System.Drawing.Size(233, 46);
            this.btnvazgec.TabIndex = 6;
            this.btnvazgec.Text = "Vazgeç";
            this.btnvazgec.UseVisualStyleBackColor = false;
            this.btnvazgec.Click += new System.EventHandler(this.btnvazgec_Click);
            // 
            // btnAracDüzenle
            // 
            this.btnAracDüzenle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAracDüzenle.FlatAppearance.BorderSize = 0;
            this.btnAracDüzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAracDüzenle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAracDüzenle.Location = new System.Drawing.Point(258, 39);
            this.btnAracDüzenle.Name = "btnAracDüzenle";
            this.btnAracDüzenle.Size = new System.Drawing.Size(227, 35);
            this.btnAracDüzenle.TabIndex = 5;
            this.btnAracDüzenle.Text = "Araç Düzenle";
            this.btnAracDüzenle.UseVisualStyleBackColor = false;
            this.btnAracDüzenle.Click += new System.EventHandler(this.btnAracDüzenle_Click);
            // 
            // btnAracEkle
            // 
            this.btnAracEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAracEkle.FlatAppearance.BorderSize = 0;
            this.btnAracEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAracEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAracEkle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAracEkle.ImageIndex = 0;
            this.btnAracEkle.Location = new System.Drawing.Point(5, 39);
            this.btnAracEkle.Name = "btnAracEkle";
            this.btnAracEkle.Size = new System.Drawing.Size(240, 35);
            this.btnAracEkle.TabIndex = 4;
            this.btnAracEkle.Text = "Araç Ekle ";
            this.btnAracEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAracEkle.UseVisualStyleBackColor = false;
            this.btnAracEkle.Click += new System.EventHandler(this.btnAracEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1011, 530);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // cmbAra
            // 
            this.cmbAra.FormattingEnabled = true;
            this.cmbAra.Items.AddRange(new object[] {
            "Tüm Araçlar",
            "Boş Araçlar",
            "Dolu Araçlar"});
            this.cmbAra.Location = new System.Drawing.Point(1123, 50);
            this.cmbAra.Name = "cmbAra";
            this.cmbAra.Size = new System.Drawing.Size(121, 24);
            this.cmbAra.TabIndex = 11;
            this.cmbAra.SelectedIndexChanged += new System.EventHandler(this.cmbAra_SelectedIndexChanged);
            // 
            // tbAracArama
            // 
            this.tbAracArama.Location = new System.Drawing.Point(101, 137);
            this.tbAracArama.Multiline = true;
            this.tbAracArama.Name = "tbAracArama";
            this.tbAracArama.Size = new System.Drawing.Size(121, 22);
            this.tbAracArama.TabIndex = 10;
            this.tbAracArama.TextChanged += new System.EventHandler(this.tbAracArama_TextChanged);
            // 
            // lblAracArama
            // 
            this.lblAracArama.AutoSize = true;
            this.lblAracArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAracArama.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAracArama.Location = new System.Drawing.Point(4, 142);
            this.lblAracArama.Name = "lblAracArama";
            this.lblAracArama.Size = new System.Drawing.Size(48, 17);
            this.lblAracArama.TabIndex = 9;
            this.lblAracArama.Text = "Plaka";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbAracArama);
            this.panel2.Controls.Add(this.lblAracArama);
            this.panel2.Controls.Add(this.btnGeri);
            this.panel2.Controls.Add(this.btnAra);
            this.panel2.Controls.Add(this.cmbModel);
            this.panel2.Controls.Add(this.cmbMarka);
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(1022, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 497);
            this.panel2.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(44, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 42);
            this.button1.TabIndex = 14;
            this.button1.Text = "Raporla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(3, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Marka";
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.White;
            this.btnGeri.FlatAppearance.BorderSize = 0;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.Location = new System.Drawing.Point(116, 340);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(106, 30);
            this.btnGeri.TabIndex = 11;
            this.btnGeri.Text = "Yenile";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.White;
            this.btnAra.FlatAppearance.BorderSize = 0;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Location = new System.Drawing.Point(10, 340);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(100, 30);
            this.btnAra.TabIndex = 10;
            this.btnAra.Text = "Arama";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // cmbModel
            // 
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(101, 243);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(121, 24);
            this.cmbModel.TabIndex = 9;
            this.cmbModel.SelectedIndexChanged += new System.EventHandler(this.cmbModel_SelectedIndexChanged);
            // 
            // cmbMarka
            // 
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Location = new System.Drawing.Point(101, 181);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(121, 24);
            this.cmbMarka.TabIndex = 8;
            this.cmbMarka.SelectedIndexChanged += new System.EventHandler(this.cmbMarka_SelectedIndexChanged);
            // 
            // btnMarkaEkle
            // 
            this.btnMarkaEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnMarkaEkle.FlatAppearance.BorderSize = 0;
            this.btnMarkaEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkaEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMarkaEkle.Location = new System.Drawing.Point(748, 39);
            this.btnMarkaEkle.Name = "btnMarkaEkle";
            this.btnMarkaEkle.Size = new System.Drawing.Size(268, 35);
            this.btnMarkaEkle.TabIndex = 58;
            this.btnMarkaEkle.Text = "Marka/Model Ekle";
            this.btnMarkaEkle.UseVisualStyleBackColor = false;
            this.btnMarkaEkle.Click += new System.EventHandler(this.btnMarkaEkle_Click);
            // 
            // AraçListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1256, 622);
            this.Controls.Add(this.btnMarkaEkle);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmbAra);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAracSil);
            this.Controls.Add(this.btnvazgec);
            this.Controls.Add(this.btnAracDüzenle);
            this.Controls.Add(this.btnAracEkle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AraçListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AraçListesi";
            this.Load += new System.EventHandler(this.AraçListesi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnAracSil;
        private System.Windows.Forms.Button btnvazgec;
        private System.Windows.Forms.Button btnAracDüzenle;
        private System.Windows.Forms.Button btnAracEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbAra;
        private System.Windows.Forms.TextBox tbAracArama;
        private System.Windows.Forms.Label lblAracArama;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.Button btnMarkaEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}