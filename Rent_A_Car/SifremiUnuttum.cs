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
    public partial class SifremiUnuttum : Form
    {
        public SifremiUnuttum()
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
            if (con.State == ConnectionState.Closed) con.Open();
            ds.Clear();
            string komut = "select * from UYE_BILGI";
            OleDbDataAdapter da = new OleDbDataAdapter(komut, con);
            da.Fill(ds, "UYE_BILGI");
            con.Close();
        }

        string uyeid;
        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (txtGuvenlikSorusu.Text == "" && txtGuvenlikSorusu.Text == "")
            {
                MessageBox.Show("Eksik Bilgi Girdiniz");
            }
            else
            {
                OleDbCommand cmdd = new OleDbCommand();
                cmdd.Connection = con;
                cmdd.CommandText = "select UYE_SIFRE from UYE_BILGI where UYE_KULLANICI_ADI='" + txtKullaniciAdi.Text + "'and GUVENLIK_SORUSU='" + txtGuvenlikSorusu.Text + "'";
                if (con.State == ConnectionState.Closed) con.Open();
                dr = cmdd.ExecuteReader();
                if (dr.Read())
                {
                    uyeid = dr.GetValue(0).ToString();
                    MessageBox.Show("Şifreniz : " + uyeid);
                }
                else
                {
                    MessageBox.Show("Yanlış Kullanıcı adı yada güvenlik cevabı girdiniz");
                    dr.Close();
                }
            }
        }

        private void SifremiUnuttum_Load(object sender, EventArgs e)
        {
            verilericek();
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            txtKullaniciAdi.Text = txtKullaniciAdi.Text.ToLower();
            txtKullaniciAdi.SelectionStart = txtKullaniciAdi.Text.Length;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
