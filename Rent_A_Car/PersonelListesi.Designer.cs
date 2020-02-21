namespace Rent_A_Car
{
    partial class PersonelListesi
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
            this.btnsil = new System.Windows.Forms.Button();
            this.btnvazgec = new System.Windows.Forms.Button();
            this.btnduzenle = new System.Windows.Forms.Button();
            this.btnyenikayit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbpersonelarama = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMusteriArama = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnKapat);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 35);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Personel Listesi";
            // 
            // btnKapat
            // 
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(946, 3);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(28, 30);
            this.btnKapat.TabIndex = 4;
            this.btnKapat.Text = "X";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnsil.FlatAppearance.BorderSize = 0;
            this.btnsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsil.Location = new System.Drawing.Point(646, 139);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(244, 42);
            this.btnsil.TabIndex = 7;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnvazgec
            // 
            this.btnvazgec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnvazgec.FlatAppearance.BorderSize = 0;
            this.btnvazgec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvazgec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnvazgec.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnvazgec.Location = new System.Drawing.Point(828, 399);
            this.btnvazgec.Name = "btnvazgec";
            this.btnvazgec.Size = new System.Drawing.Size(144, 35);
            this.btnvazgec.TabIndex = 6;
            this.btnvazgec.Text = "Vazgeç";
            this.btnvazgec.UseVisualStyleBackColor = false;
            this.btnvazgec.Click += new System.EventHandler(this.btnvazgec_Click);
            // 
            // btnduzenle
            // 
            this.btnduzenle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnduzenle.FlatAppearance.BorderSize = 0;
            this.btnduzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnduzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnduzenle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnduzenle.Location = new System.Drawing.Point(646, 93);
            this.btnduzenle.Name = "btnduzenle";
            this.btnduzenle.Size = new System.Drawing.Size(244, 40);
            this.btnduzenle.TabIndex = 5;
            this.btnduzenle.Text = "Düzenle";
            this.btnduzenle.UseVisualStyleBackColor = false;
            this.btnduzenle.Click += new System.EventHandler(this.btnduzenle_Click);
            // 
            // btnyenikayit
            // 
            this.btnyenikayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnyenikayit.FlatAppearance.BorderSize = 0;
            this.btnyenikayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnyenikayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnyenikayit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnyenikayit.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnyenikayit.ImageIndex = 0;
            this.btnyenikayit.Location = new System.Drawing.Point(646, 39);
            this.btnyenikayit.Name = "btnyenikayit";
            this.btnyenikayit.Size = new System.Drawing.Size(244, 48);
            this.btnyenikayit.TabIndex = 4;
            this.btnyenikayit.Text = "Yeni Kayıt Ekle";
            this.btnyenikayit.UseVisualStyleBackColor = false;
            this.btnyenikayit.Click += new System.EventHandler(this.btnyenikayit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(626, 395);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tbpersonelarama
            // 
            this.tbpersonelarama.Enabled = false;
            this.tbpersonelarama.Location = new System.Drawing.Point(807, 209);
            this.tbpersonelarama.Multiline = true;
            this.tbpersonelarama.Name = "tbpersonelarama";
            this.tbpersonelarama.Size = new System.Drawing.Size(153, 22);
            this.tbpersonelarama.TabIndex = 11;
            this.tbpersonelarama.TextChanged += new System.EventHandler(this.tbpersonelarama_TextChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(646, 215);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(17, 16);
            this.radioButton1.TabIndex = 25;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(646, 306);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(17, 16);
            this.radioButton3.TabIndex = 24;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(646, 262);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(17, 16);
            this.radioButton2.TabIndex = 23;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(662, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "SOYAD ARAMA";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(807, 300);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(153, 22);
            this.textBox2.TabIndex = 21;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(807, 256);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 22);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(662, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "AD ARAMA";
            // 
            // lblMusteriArama
            // 
            this.lblMusteriArama.AutoSize = true;
            this.lblMusteriArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriArama.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMusteriArama.Location = new System.Drawing.Point(662, 213);
            this.lblMusteriArama.Name = "lblMusteriArama";
            this.lblMusteriArama.Size = new System.Drawing.Size(121, 18);
            this.lblMusteriArama.TabIndex = 17;
            this.lblMusteriArama.Text = "TC NO ARAMA";
            // 
            // PersonelListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(974, 446);
            this.Controls.Add(this.btnyenikayit);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnduzenle);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMusteriArama);
            this.Controls.Add(this.btnvazgec);
            this.Controls.Add(this.tbpersonelarama);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonelListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonelListesi";
            this.Load += new System.EventHandler(this.PersonelListesi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnvazgec;
        private System.Windows.Forms.Button btnduzenle;
        private System.Windows.Forms.Button btnyenikayit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbpersonelarama;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMusteriArama;
        private System.Windows.Forms.Label label3;
    }
}