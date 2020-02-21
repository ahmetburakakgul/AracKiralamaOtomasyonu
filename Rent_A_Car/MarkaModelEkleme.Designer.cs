namespace Rent_A_Car
{
    partial class MarkaModelEkleme
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
            this.btnKapat = new System.Windows.Forms.Button();
            this.gbModel = new System.Windows.Forms.GroupBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMarka = new System.Windows.Forms.Label();
            this.gbMarka = new System.Windows.Forms.GroupBox();
            this.btnEkle2 = new System.Windows.Forms.Button();
            this.btnGeri2 = new System.Windows.Forms.Button();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblModelEkle = new System.Windows.Forms.Label();
            this.lblMarkaEkle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gbModel.SuspendLayout();
            this.gbMarka.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnKapat);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 38);
            this.panel1.TabIndex = 0;
            // 
            // btnKapat
            // 
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(290, 5);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(31, 30);
            this.btnKapat.TabIndex = 9;
            this.btnKapat.Text = "X";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // gbModel
            // 
            this.gbModel.Controls.Add(this.btnEkle);
            this.gbModel.Controls.Add(this.btnGeri);
            this.gbModel.Controls.Add(this.txtModel);
            this.gbModel.Controls.Add(this.cmbMarka);
            this.gbModel.Controls.Add(this.lblModel);
            this.gbModel.Controls.Add(this.lblMarka);
            this.gbModel.Location = new System.Drawing.Point(0, 67);
            this.gbModel.Name = "gbModel";
            this.gbModel.Size = new System.Drawing.Size(319, 205);
            this.gbModel.TabIndex = 8;
            this.gbModel.TabStop = false;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEkle.Location = new System.Drawing.Point(9, 161);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(98, 34);
            this.btnEkle.TabIndex = 11;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGeri.FlatAppearance.BorderSize = 0;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGeri.Location = new System.Drawing.Point(216, 161);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(97, 34);
            this.btnGeri.TabIndex = 10;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // txtModel
            // 
            this.txtModel.BackColor = System.Drawing.SystemColors.Window;
            this.txtModel.Location = new System.Drawing.Point(135, 74);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(121, 22);
            this.txtModel.TabIndex = 9;
            this.txtModel.TextChanged += new System.EventHandler(this.txtModel_TextChanged);
            // 
            // cmbMarka
            // 
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Location = new System.Drawing.Point(135, 38);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(121, 24);
            this.cmbMarka.TabIndex = 8;
            this.cmbMarka.SelectedIndexChanged += new System.EventHandler(this.cmbMarka_SelectedIndexChanged);
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblModel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblModel.Location = new System.Drawing.Point(37, 77);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(59, 20);
            this.lblModel.TabIndex = 7;
            this.lblModel.Text = "Model";
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMarka.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMarka.Location = new System.Drawing.Point(37, 38);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(60, 20);
            this.lblMarka.TabIndex = 6;
            this.lblMarka.Text = "Marka";
            // 
            // gbMarka
            // 
            this.gbMarka.Controls.Add(this.btnEkle2);
            this.gbMarka.Controls.Add(this.btnGeri2);
            this.gbMarka.Controls.Add(this.txtMarka);
            this.gbMarka.Controls.Add(this.label1);
            this.gbMarka.Location = new System.Drawing.Point(3, 67);
            this.gbMarka.Name = "gbMarka";
            this.gbMarka.Size = new System.Drawing.Size(302, 205);
            this.gbMarka.TabIndex = 7;
            this.gbMarka.TabStop = false;
            // 
            // btnEkle2
            // 
            this.btnEkle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEkle2.FlatAppearance.BorderSize = 0;
            this.btnEkle2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEkle2.Location = new System.Drawing.Point(9, 149);
            this.btnEkle2.Name = "btnEkle2";
            this.btnEkle2.Size = new System.Drawing.Size(85, 41);
            this.btnEkle2.TabIndex = 3;
            this.btnEkle2.Text = "Ekle";
            this.btnEkle2.UseVisualStyleBackColor = false;
            this.btnEkle2.Click += new System.EventHandler(this.btnEkle2_Click);
            // 
            // btnGeri2
            // 
            this.btnGeri2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGeri2.FlatAppearance.BorderSize = 0;
            this.btnGeri2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGeri2.Location = new System.Drawing.Point(213, 149);
            this.btnGeri2.Name = "btnGeri2";
            this.btnGeri2.Size = new System.Drawing.Size(83, 41);
            this.btnGeri2.TabIndex = 2;
            this.btnGeri2.Text = "Geri";
            this.btnGeri2.UseVisualStyleBackColor = false;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(97, 51);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(143, 22);
            this.txtMarka.TabIndex = 1;
            this.txtMarka.TextChanged += new System.EventHandler(this.txtMarka_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(15, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka ";
            // 
            // lblModelEkle
            // 
            this.lblModelEkle.AutoSize = true;
            this.lblModelEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblModelEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblModelEkle.Location = new System.Drawing.Point(215, 44);
            this.lblModelEkle.Name = "lblModelEkle";
            this.lblModelEkle.Size = new System.Drawing.Size(101, 20);
            this.lblModelEkle.TabIndex = 6;
            this.lblModelEkle.Text = "Model Ekle";
            this.lblModelEkle.Click += new System.EventHandler(this.lblModelEkle_Click);
            // 
            // lblMarkaEkle
            // 
            this.lblMarkaEkle.AutoSize = true;
            this.lblMarkaEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMarkaEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMarkaEkle.Location = new System.Drawing.Point(8, 44);
            this.lblMarkaEkle.Name = "lblMarkaEkle";
            this.lblMarkaEkle.Size = new System.Drawing.Size(102, 20);
            this.lblMarkaEkle.TabIndex = 5;
            this.lblMarkaEkle.Text = "Marka Ekle";
            this.lblMarkaEkle.Click += new System.EventHandler(this.lblMarkaEkle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "MARKA/MODEL EKLE";
            // 
            // MarkaModelEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(322, 278);
            this.Controls.Add(this.gbModel);
            this.Controls.Add(this.gbMarka);
            this.Controls.Add(this.lblModelEkle);
            this.Controls.Add(this.lblMarkaEkle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MarkaModelEkleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.MarkaModelEkleme_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbModel.ResumeLayout(false);
            this.gbModel.PerformLayout();
            this.gbMarka.ResumeLayout(false);
            this.gbMarka.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbModel;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.GroupBox gbMarka;
        private System.Windows.Forms.Button btnEkle2;
        private System.Windows.Forms.Button btnGeri2;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblModelEkle;
        private System.Windows.Forms.Label lblMarkaEkle;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label label2;
    }
}