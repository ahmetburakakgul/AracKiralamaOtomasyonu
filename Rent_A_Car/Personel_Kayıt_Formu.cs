using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Rent_A_Car
{
    public partial class Personel_Kayıt_Formu : Form
    {
        public Personel_Kayıt_Formu()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection
       ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RentACar.mdb");
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();
        BindingSource bs = new BindingSource();
        OleDbDataReader dr;

        bool kontroltc = false;
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtTC.Text == "" || txtAdi.Text == "" || txtSoyadi.Text == "" || txtGsMNo.Text == "" || txtmaas.Text == "" || txtSelbestAdres.Text == "" || cmbCinsiyet.Text == "")
            {
                MessageBox.Show("Tüm Kısımları doldurunuz");
            }
            else if (txtTC.Text.Count() > 11)
            {
                MessageBox.Show("TC NO 11 HANEDEN BÜYÜK OLAMAZ");
            }
            else if (txtTC.Text.Count() < 11)
            {
                MessageBox.Show("TC NO 11 HANEDEN KÜÇÜK OLAMAZ");
            }
            else
            {
                OleDbCommand cmd2 = new OleDbCommand();
                cmd2.Connection = con;
                cmd2.CommandText = "select * from PERSONEL where TC_KIMLIK_NO='" + txtTC.Text + "'";
                if (con.State == ConnectionState.Closed) con.Open();
                dr = cmd2.ExecuteReader();
                if (dr.Read())
                {
                    DialogResult cc = MessageBox.Show("Aynı TC Kimlik Numarası Bulnmaktadır..", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (cc == DialogResult.OK)
                    {
                        txtTC.Clear();
                    }
                }
                else
                {
                    if (kontroltc == true)
                    {
                        if (con.State == ConnectionState.Closed) con.Open();
                        OleDbCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "INSERT INTO PERSONEL (TC_KIMLIK_NO, ADI, SOYADI, GSM_NO,  CINSIYET, ADRES, MAAS) " +

            "VALUES (@TC_KIMLIK_NO, @ADI, @SOYADI,  @GSM_NO, @CINSIYET, @ADRES, @MAAS)";


                        cmd.Parameters.AddWithValue("@TC_KIMLIK_NO", txtTC.Text);

                        cmd.Parameters.AddWithValue("@ADI", txtAdi.Text);

                        cmd.Parameters.AddWithValue("@SOYADI", txtSoyadi.Text);

                        cmd.Parameters.AddWithValue("@GSM_NO,", txtGsMNo.Text);

                        cmd.Parameters.AddWithValue("@CINSIYET", cmbCinsiyet.Text);

                        cmd.Parameters.AddWithValue("@ADRES", txtSelbestAdres.Text);

                        cmd.Parameters.AddWithValue("@MAAS", txtmaas.Text);

                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("KAYIT BAŞARIYLA GERÇEKLEŞTİ");
                    }
                    if (txtTC.Text.Count() == 11)
                    {
                        kontroltc = true;
                    }
                    else if (txtTC.Text.Count() > 11)
                    {
                        MessageBox.Show("TC no 11 Haneyi Geçemez.");
                    }
                }
            }
        }

        private void Personel_Kayıt_Formu_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.Add("ERKEK");
            cmbCinsiyet.Items.Add("KADIN");
        }

        private void Personel_Kayıt_Formu_FormClosed(object sender, FormClosedEventArgs e)
        {
            PersonelListesi personel = (PersonelListesi)Application.OpenForms["PersonelListesi"];
            personel.verilerigoster();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtGsMNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtmaas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
           

        }

        private void txtSoyadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
            
        }

        private void txtAdi_TextChanged(object sender, EventArgs e)
        {
            txtAdi.Text = txtAdi.Text.ToUpper();
            txtAdi.SelectionStart = txtAdi.Text.Length;
        }

        private void txtSoyadi_TextChanged(object sender, EventArgs e)
        {
            txtSoyadi.Text = txtSoyadi.Text.ToUpper();
            txtSoyadi.SelectionStart = txtSoyadi.Text.Length;
        }
    }
}
