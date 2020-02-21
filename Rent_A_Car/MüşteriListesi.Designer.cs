namespace Rent_A_Car
{
    partial class MüşteriListesi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnDüzenle = new System.Windows.Forms.Button();
            this.btnvazgec = new System.Windows.Forms.Button();
            this.tbMusteriArama = new System.Windows.Forms.TextBox();
            this.lblMusteriArama = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnrapor = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnKapat);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(999, 40);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(13, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Müşteri Listesi";
            // 
            // btnKapat
            // 
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(971, 7);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(28, 30);
            this.btnKapat.TabIndex = 6;
            this.btnKapat.Text = "X";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(663, 392);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSil.Location = new System.Drawing.Point(673, 126);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(227, 35);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Müşteri Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEkle.ImageIndex = 0;
            this.btnEkle.Location = new System.Drawing.Point(673, 44);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(225, 35);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Yeni Müşteri";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnDüzenle
            // 
            this.btnDüzenle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnDüzenle.FlatAppearance.BorderSize = 0;
            this.btnDüzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDüzenle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDüzenle.Location = new System.Drawing.Point(673, 85);
            this.btnDüzenle.Name = "btnDüzenle";
            this.btnDüzenle.Size = new System.Drawing.Size(225, 35);
            this.btnDüzenle.TabIndex = 5;
            this.btnDüzenle.Text = "Müşteri Bİlgileri Düzenle";
            this.btnDüzenle.UseVisualStyleBackColor = false;
            this.btnDüzenle.Click += new System.EventHandler(this.btnDüzenle_Click);
            // 
            // btnvazgec
            // 
            this.btnvazgec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnvazgec.FlatAppearance.BorderSize = 0;
            this.btnvazgec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvazgec.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnvazgec.Location = new System.Drawing.Point(783, 401);
            this.btnvazgec.Name = "btnvazgec";
            this.btnvazgec.Size = new System.Drawing.Size(204, 35);
            this.btnvazgec.TabIndex = 6;
            this.btnvazgec.Text = "Vazgeç";
            this.btnvazgec.UseVisualStyleBackColor = false;
            this.btnvazgec.Click += new System.EventHandler(this.btnvazgec_Click);
            // 
            // tbMusteriArama
            // 
            this.tbMusteriArama.Enabled = false;
            this.tbMusteriArama.Location = new System.Drawing.Point(834, 215);
            this.tbMusteriArama.Multiline = true;
            this.tbMusteriArama.Name = "tbMusteriArama";
            this.tbMusteriArama.Size = new System.Drawing.Size(154, 22);
            this.tbMusteriArama.TabIndex = 8;
            this.tbMusteriArama.TextChanged += new System.EventHandler(this.tbMusteriArama_TextChanged);
            // 
            // lblMusteriArama
            // 
            this.lblMusteriArama.AutoSize = true;
            this.lblMusteriArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriArama.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMusteriArama.Location = new System.Drawing.Point(689, 216);
            this.lblMusteriArama.Name = "lblMusteriArama";
            this.lblMusteriArama.Size = new System.Drawing.Size(121, 18);
            this.lblMusteriArama.TabIndex = 7;
            this.lblMusteriArama.Text = "TC NO ARAMA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(689, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "AD ARAMA";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(834, 259);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 22);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(834, 303);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(153, 22);
            this.textBox2.TabIndex = 11;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(689, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "SOYAD ARAMA";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(673, 265);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(17, 16);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(673, 309);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(17, 16);
            this.radioButton3.TabIndex = 15;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(673, 218);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(17, 16);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // btnrapor
            // 
            this.btnrapor.BackColor = System.Drawing.Color.White;
            this.btnrapor.FlatAppearance.BorderSize = 0;
            this.btnrapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrapor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnrapor.Location = new System.Drawing.Point(673, 167);
            this.btnrapor.Name = "btnrapor";
            this.btnrapor.Size = new System.Drawing.Size(227, 35);
            this.btnrapor.TabIndex = 17;
            this.btnrapor.Text = "Raoprlama";
            this.btnrapor.UseVisualStyleBackColor = false;
            this.btnrapor.Click += new System.EventHandler(this.btnrapor_Click);
            // 
            // MüşteriListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(999, 448);
            this.Controls.Add(this.btnrapor);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDüzenle);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.btnvazgec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMusteriArama);
            this.Controls.Add(this.lblMusteriArama);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MüşteriListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MüşteriListesi";
            this.Load += new System.EventHandler(this.MüşteriListesi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnvazgec;
        private System.Windows.Forms.Button btnDüzenle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox tbMusteriArama;
        private System.Windows.Forms.Label lblMusteriArama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnrapor;
    }
}