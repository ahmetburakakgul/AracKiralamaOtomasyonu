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
    public partial class MüşteriKaydı : Form
    {
        public MüşteriKaydı()
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
            if (txtTC.Text == "" || txtAdi.Text == "" || txtSoyadi.Text == "" || txtGsmNo.Text == "" || txtIl.Text == "" || txtAdres.Text == "" || cmbCinsiyet.Text == ""||dtDogumTarihi.Text==""||txtDogumYeri.Text=="")
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
                cmd2.CommandText = "select * from MUSTERI where TC='" + txtTC.Text + "'";
                if (con.State == ConnectionState.Closed) con.Open();
                dr = cmd2.ExecuteReader();
                if (dr.Read())
                {
                    DialogResult cc = MessageBox.Show("Aynı TC Kimlik Numarası Bulunmaktadır..", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (cc == DialogResult.OK)
                    {
                        txtTC.Clear();
                    }
                }
                else
                {

                    if (kontroltc == true)
                    {
                        con.Close();
                        con.Open();
                        OleDbCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "INSERT INTO MUSTERI ( ADI, SOYADI, TC, CINSIYET, DOGUM_TARIHI, DOGUM_YERI, GSM_NO, IL, ADRES  ) " +

                        "VALUES (@ADI, @SOYADI, @TC, @CINSIYET,@DOGUM_TARIHI, @DOGUM_YERI, @GSM_NO, @IL, @ADRES)";


                        cmd.Parameters.AddWithValue("@ADI", txtAdi.Text);
                        cmd.Parameters.AddWithValue("@SOYADI", txtSoyadi.Text);
                        cmd.Parameters.AddWithValue("@TC", txtTC.Text);
                        cmd.Parameters.AddWithValue("@CINSIYET", cmbCinsiyet.Text);
                        cmd.Parameters.AddWithValue("@DOGUM_TARIHI", dtDogumTarihi.Text);
                        cmd.Parameters.AddWithValue("@DOGUM_YERI", txtDogumYeri.Text);
                        cmd.Parameters.AddWithValue("@GSM_NO,", txtGsmNo.Text);
                        cmd.Parameters.AddWithValue("@IL", txtIl.Text);
                        cmd.Parameters.AddWithValue("@ADRES", txtAdres.Text);



                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("KAYIT BAŞARIYLA GERÇEKLEŞTİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    if (txtTC.Text.Count() == 11)
                    {
                        kontroltc = true;
                    }
                    else if (txtTC.Text.Count() > 11)
                    {
                        MessageBox.Show("TC no 11 Haneyi Geçemez.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnVazgeç_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtGsmNo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtDogumYeri_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
            
        }

        private void txtIl_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
           
        }

        private void txtAdres_KeyPress(object sender, KeyPressEventArgs e)
        {
            //
        }

        private void MüşteriKaydı_FormClosed(object sender, FormClosedEventArgs e)
        {

            MüşteriListesi musteri = (MüşteriListesi)Application.OpenForms["MüşteriListesi"];
            musteri.GOSTER();
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

        private void txtDogumYeri_TextChanged(object sender, EventArgs e)
        {
            txtDogumYeri.Text = txtDogumYeri.Text.ToUpper();
            txtDogumYeri.SelectionStart = txtDogumYeri.Text.Length;
        }

        private void txtIl_TextChanged(object sender, EventArgs e)
        {
            txtIl.Text = txtIl.Text.ToUpper();
            txtIl.SelectionStart = txtIl.Text.Length;
        }

        private void txtAdres_TextChanged(object sender, EventArgs e)
        {
            txtAdres.Text = txtAdres.Text.ToUpper();
            txtAdres.SelectionStart = txtAdres.Text.Length;
        }

        private void MüşteriKaydı_Load(object sender, EventArgs e)
        {

        }
    }
}
