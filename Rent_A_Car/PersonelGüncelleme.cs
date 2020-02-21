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
    public partial class PersonelGüncelleme : Form
    {
        public static string personel_id { get; set; }
        public PersonelGüncelleme()
        {
            InitializeComponent();
        }
        
        OleDbConnection con = new OleDbConnection
      ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RentACar.mdb");
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();
        BindingSource bs = new BindingSource();
        OleDbDataReader dr;

        void tcbul()
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update  PERSONEL set TC_KIMLIK_NO=@TC_KIMLIK_NO, ADI=@ADI, SOYADI=@SOYADI, GSM_NO=@GSM_NO," +
                              "CINSIYET=@CINSIYET, ADRES=@ADRES, MAAS=@MAAS where PERSONEL_ID=" + personel_id + "";
            cmd.Parameters.AddWithValue("@TC_KIMLIK_NO", txtTC.Text);
            cmd.Parameters.AddWithValue("@ADI", txtAdi.Text);
            cmd.Parameters.AddWithValue("@SOYADI", txtSoyadi.Text);
            cmd.Parameters.AddWithValue("@GSM_NO", txtGsMNo.Text);
            cmd.Parameters.AddWithValue("@CINSIYET", cmbCinsiyet.Text);
            cmd.Parameters.AddWithValue("@ADRES", txtSelbestAdres.Text);
            cmd.Parameters.AddWithValue("@MAAS", txtmaas.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("KAYIT GÜNCELLEMESİ GERÇEKLEŞTİ");
        }

        void verilericek()
        {
            ds.Clear();
            int b = int.Parse(personel_id);
            string komut = "select * from PERSONEL where PERSONEL_ID=" + personel_id + "";
            OleDbDataAdapter db = new OleDbDataAdapter(komut, con);
            db.Fill(ds, "PERSONEL");
        }

        long kontroltc;
        private void btnGuncelle_Click(object sender, EventArgs e)
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
                        tcbul();
                    }
                }
                else
                {
                    tcbul();
                }
            }            
         }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PersonelGüncelleme_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.Add("Erkek");
            cmbCinsiyet.Items.Add("Kadın");

            if (con.State == ConnectionState.Closed) con.Open();
            verilericek();
            bs.DataSource = ds.Tables["PERSONEL"];
            txtAdi.DataBindings.Clear();
            txtGsMNo.DataBindings.Clear();
            txtmaas.DataBindings.Clear();
            txtSelbestAdres.DataBindings.Clear();
            txtSoyadi.DataBindings.Clear();
            txtTC.DataBindings.Clear();
            cmbCinsiyet.DataBindings.Clear();

            txtTC.DataBindings.Add("Text", bs, "TC_KIMLIK_NO");
            txtSoyadi.DataBindings.Add("Text", bs, "SOYADI");
            txtSelbestAdres.DataBindings.Add("Text", bs, "ADRES");
            txtmaas.DataBindings.Add("Text", bs, "MAAS");
            txtGsMNo.DataBindings.Add("Text", bs, "GSM_NO");
            txtAdi.DataBindings.Add("Text", bs, "ADI");
            cmbCinsiyet.DataBindings.Add("Text", bs, "CINSIYET");
            con.Close();
            kontroltc = long.Parse(txtTC.Text);
        }

        private void PersonelGüncelleme_FormClosed(object sender, FormClosedEventArgs e)
        {
            PersonelListesi personellistesi = (PersonelListesi)Application.OpenForms["PersonelListesi"];
            personellistesi.verilerigoster();
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
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
           
        }

        private void txtSoyadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
            
        }

        private void txtAdi_TextChanged(object sender, EventArgs e)
        {
            txtAdi.Text = txtAdi.Text.ToUpper();
            txtAdi.SelectionStart = txtAdi.Text.Length;
        }

        private void txtSoyadi_TextChanged(object sender, EventArgs e)
        {
            txtAdi.Text = txtAdi.Text.ToUpper();
            txtSoyadi.SelectionStart = txtSoyadi.Text.Length;
        }
    }
}
