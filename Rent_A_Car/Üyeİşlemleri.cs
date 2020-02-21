using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent_A_Car
{
    public partial class Üyeİşlemleri : Form
    {
        public static string kulad { get; set; }
        public Üyeİşlemleri()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection
("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RentACar.mdb");
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();
        BindingSource bs = new BindingSource();
        OleDbDataReader dr;

        void verilericek()
        {
            ds.Clear();
            string komut = "select * from UYE_BILGI where UYE_KULLANICI_ADI='" + kulad + "'";
            OleDbDataAdapter da = new OleDbDataAdapter(komut, con);
            da.Fill(ds, "UYE_BILGI");
        }
        void load()
        {
            if (con.State == ConnectionState.Closed) con.Open();
            verilericek();
            bs.DataSource = ds.Tables["UYE_BILGI"];
            txtKullanıcıAdi.DataBindings.Clear(); txtSifre.DataBindings.Clear(); txtAdi.DataBindings.Clear(); txtSoyadi.DataBindings.Clear(); txtGuvenlikSorusu.DataBindings.Clear();
            txtKullanıcıAdi.DataBindings.Add("Text", bs, "UYE_KULLANICI_ADI");
            txtSifre.DataBindings.Add("Text", bs, "UYE_SIFRE");
            txtAdi.DataBindings.Add("Text", bs, "UYE_ADI");
            txtSoyadi.DataBindings.Add("Text", bs, "UYE_SOYADI");
            txtGuvenlikSorusu.DataBindings.Add("Text", bs, "GUVENLIK_SORUSU");
            txtKullanıcıAdi.Enabled = txtSifre.Enabled = txtAdi.Enabled = txtSoyadi.Enabled = txtGuvenlikSorusu.Enabled = false;
        }


        private void btnDüzenle_Click(object sender, EventArgs e)
        {
            if (btnDüzenle.Text == "Kaydet")
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "update  UYE_BILGI set UYE_ADI=@UYE_ADI,UYE_SOYADI=@UYE_SOYADI,UYE_KULLANICI_ADI=@UYE_KULLANICI_ADI,UYE_SIFRE=@UYE_SIFRE,GUVENLIK_SORUSU=@GUVENLIK_SORUSU where UYE_KULLANICI_ADI='" + kulad + "'";
                cmd.Parameters.AddWithValue("@UYE_ADI", txtAdi.Text);
                cmd.Parameters.AddWithValue("@UYE_SOYADI", txtSoyadi.Text);
                cmd.Parameters.AddWithValue("@UYE_KULLANICI_ADI", txtKullanıcıAdi.Text);
                cmd.Parameters.AddWithValue("@UYE_SIFRE", txtSifre.Text);
                cmd.Parameters.AddWithValue("@GUVENLIK_SORUSU", txtGuvenlikSorusu.Text);
                cmd.ExecuteNonQuery();
                DialogResult Soru = MessageBox.Show("Kayıt Güncellendi.Başka Bir İşlem Yapmak İstermisiniz ?", "Soru", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == Soru)
                {
                    load();
                    btnDüzenle.Text = "Kaydet";
                }
                else if (DialogResult.No == Soru)
                {
                    Anasayfa ansayfa = new Anasayfa();
                    this.Hide();

                }
                verilericek();
            }
            else if (btnDüzenle.Text == "Bilgileri Düzenle")
            {
                btnDüzenle.Text = "Kaydet";
                txtKullanıcıAdi.Enabled = txtSifre.Enabled = txtAdi.Enabled = txtSoyadi.Enabled = txtGuvenlikSorusu.Enabled = true;
            }
        }

        private void Üyeİşlemleri_Load(object sender, EventArgs e)
        {
            load();
        }

        private void txtAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
         && !char.IsSeparator(e.KeyChar);
        }

        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
