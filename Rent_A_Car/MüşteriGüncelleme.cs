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
    public partial class MüşteriGüncelleme : Form
    {
        public static string musteri_id { get; set; }
        public MüşteriGüncelleme()
        {
            InitializeComponent();
        }


        OleDbConnection con = new OleDbConnection
      ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RentACar.mdb");
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();
        BindingSource bs = new BindingSource();
        OleDbDataReader dr;
        long kontroltc;

        void tcbul()
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update  MUSTERI set ADI=@ADI, SOYADI=@SOYADI, TC=@TC, CINSIYET=@CINSIYET, DOGUM_TARIHI=@DOGUM_TARIHI," +
            "DOGUM_YERI=@DOGUM_YERI, GSM_NO=@GSM_NO, IL=@IL, ADRES=@ADRES where MUSTERI_ID=" + musteri_id + "";


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
            MessageBox.Show("KAYIT GÜNCELLEMESİ GERÇEKLEŞTİ");
        }
        void verilericek()
        {

            ds.Clear();
            int b = int.Parse(musteri_id);
            string komut = "select * from MUSTERI where MUSTERI_ID=" + musteri_id + "";
            OleDbDataAdapter db = new OleDbDataAdapter(komut, con);
            db.Fill(ds, "MUSTERI");

        }


        void guncelle()
        {
            if (txtTC.Text == "")
            {
                MessageBox.Show("TC Kimlik Numarası Boş Geçilemez");
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
                if (kontroltc != long.Parse(txtTC.Text))
                {
                    OleDbCommand cmd2 = new OleDbCommand();
                    cmd2.Connection = con;
                    cmd2.CommandText = "select * from MUSTERI where TC='" + txtTC.Text + "'";
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
                        tcbul();
                    }
                }
                else
                {
                    tcbul();
                }
            }
        }

        private void MüşteriGüncelleme_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed) con.Open();
            verilericek();
            bs.DataSource = ds.Tables["MUSTERI"];
            txtAdi.DataBindings.Clear();
            txtGsmNo.DataBindings.Clear();
            txtIl.DataBindings.Clear();
            txtAdres.DataBindings.Clear();
            txtSoyadi.DataBindings.Clear();
            txtTC.DataBindings.Clear();
            cmbCinsiyet.DataBindings.Clear();
            dtDogumTarihi.DataBindings.Clear();
            txtDogumYeri.DataBindings.Clear();

            txtTC.DataBindings.Add("Text", bs, "TC");
            txtSoyadi.DataBindings.Add("Text", bs, "SOYADI");
            txtAdres.DataBindings.Add("Text", bs, "ADRES");
            txtDogumYeri.DataBindings.Add("Text", bs, "DOGUM_YERI");
            txtGsmNo.DataBindings.Add("Text", bs, "GSM_NO");
            txtAdi.DataBindings.Add("Text", bs, "ADI");
            dtDogumTarihi.DataBindings.Add("Text", bs, "DOGUM_TARIHI");
            txtIl.DataBindings.Add("Text", bs, "IL");
            cmbCinsiyet.DataBindings.Add("Text", bs, "CINSIYET");
            con.Close(); kontroltc = long.Parse(txtTC.Text);
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {

            if (txtTC.Text == "" || txtAdi.Text == "" || txtSoyadi.Text == "" || txtGsmNo.Text == "" || txtIl.Text == "" || txtAdres.Text == "" || cmbCinsiyet.Text == "" || dtDogumTarihi.Text == "" || txtDogumYeri.Text == "")
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
                if (kontroltc != long.Parse(txtTC.Text))
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
                        guncelle();
                    }
                }
                else
                {
                    guncelle();
                }
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
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
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
         && !char.IsSeparator(e.KeyChar);
           
        }

        private void txtSoyadi_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
         && !char.IsSeparator(e.KeyChar);
           
        }

        private void txtIl_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
        && !char.IsSeparator(e.KeyChar);
           
        }

        private void txtDogumYeri_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
        && !char.IsSeparator(e.KeyChar);
           
        }

        private void txtAdres_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void MüşteriGüncelleme_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            MüşteriListesi musterilistesi = (MüşteriListesi)Application.OpenForms["MüşteriListesi"];
            musterilistesi.GOSTER();

            
        }

        private void txtAdres_TextChanged(object sender, EventArgs e)
        {
            txtAdres.Text = txtAdres.Text.ToUpper();
            txtAdres.SelectionStart = txtAdres.Text.Length;
        }

        private void txtIl_TextChanged(object sender, EventArgs e)
        {
            txtIl.Text = txtIl.Text.ToUpper();
            txtIl.SelectionStart = txtIl.Text.Length;
        }

        private void txtSoyadi_TextChanged(object sender, EventArgs e)
        {
            txtSoyadi.Text = txtSoyadi.Text.ToUpper();
            txtSoyadi.SelectionStart = txtSoyadi.Text.Length;
        }

        private void txtAdi_TextChanged(object sender, EventArgs e)
        {
            txtAdi.Text = txtAdi.Text.ToUpper();
            txtAdi.SelectionStart = txtAdi.Text.Length;
        }

        private void btnVazgeç_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

