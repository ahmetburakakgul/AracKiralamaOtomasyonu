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
    public partial class KullanıcıKayıtFormu : Form
    {
        public KullanıcıKayıtFormu()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection
       ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RentACar.mdb");
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();
        BindingSource bs = new BindingSource();
        OleDbDataReader dr;


        private void btnKayıtOl_Click(object sender, EventArgs e)
        {
            if (txtKullanıcıAdi.Text == "" || txtSifre.Text == "" || txtAdi.Text == "" || txtSoyadi.Text == "" || txtTekrarSifre.Text == "" || txtGuvenlikSorusu.Text == "")
            {
                MessageBox.Show("Tüm Kısımları doldurunuz");
            }
            else
            {
                if (lblUyariSifre.Visible == true || lblUyariAdi.Visible == true || lblUyariKullaniciAdi.Visible == true || lblUyariSoyadi.Visible == true || lblUyariTekrarSifre.Visible == true)
                {
                    MessageBox.Show("Lütfen Uyarılara Dikkat ediniz");
                }
                else
                {
                    OleDbCommand cmd2 = new OleDbCommand();
                    cmd2.Connection = con;
                    cmd2.CommandText = "select * from UYE_BILGI where UYE_KULLANICI_ADI='" + txtKullanıcıAdi.Text + "'";
                    if (con.State == ConnectionState.Closed) con.Open();
                    dr = cmd2.ExecuteReader();
                    if (dr.Read())
                    {
                        DialogResult cc = MessageBox.Show("Aynı Kullanıcı adı kullanılmaktadır.Lütfen farklı kullanıcı adı seçiniz...");
                        if (cc == DialogResult.OK)
                        {
                            txtKullanıcıAdi.Clear();
                        }
                    }
                    else
                    {
                        if (con.State == ConnectionState.Closed) con.Open();
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "insert into UYE_BILGI (UYE_ADI,UYE_SOYADI,UYE_KULLANICI_ADI,UYE_SIFRE,GUVENLIK_SORUSU) Values(@UYE_ADI,@UYE_SOYADI,@UYE_KULLANICI_ADI,@UYE_SIFRE,@GUVENLIK_SORUSU)";
                        cmd.Parameters.AddWithValue("@UYE_ADI", txtAdi.Text);
                        cmd.Parameters.AddWithValue("@UYE_SOYADI", txtSoyadi.Text);
                        cmd.Parameters.AddWithValue("@UYE_KULLANICI_ADI", txtKullanıcıAdi.Text);
                        cmd.Parameters.AddWithValue("@UYE_SIFRE", int.Parse(txtSifre.Text));
                        cmd.Parameters.AddWithValue("@GUVENLIK_SORUSU", txtGuvenlikSorusu.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kayıt yapıldı");
                        con.Close();
                        Form1 Kullanici_girisi = new Form1();
                        this.Hide();
                        Kullanici_girisi.ShowDialog();
                        this.Show();
                    }
                }
            }
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            int uzunluk = txtSifre.Text.Length;
            if (uzunluk < 8)
            {
                lblSifre.Visible = true;
                lblUyariSifre.Text = "Şifreniz 8 karakterden\nuzun olmalıdır";
            }
            else
            {
                lblUyariSifre.Visible = false;
            }
        }

        private void txtTekrarSifre_TextChanged(object sender, EventArgs e)
        {
            if (txtSifre.Text != txtTekrarSifre.Text)
            {
                lblSifreTekrar.Visible = true;
                lblUyariTekrarSifre.Text = "Şifreler Eşleşmiyor";
            }
            else
            {
                lblUyariTekrarSifre.Visible = false;
            }
        }

        private void txtKullanıcıAdi_TextChanged(object sender, EventArgs e)
        {
            if (txtKullanıcıAdi.Text == "")
            {
                lblUyariKullaniciAdi.Visible = true;
                lblUyariKullaniciAdi.Text = "Kullanıcı Adı Boş Geçilemez";
            }
            else
            {
                lblUyariKullaniciAdi.Visible = false;
            }

        }

        private void txtSoyadi_TextChanged(object sender, EventArgs e)
        {
            if (txtSoyadi.Text == "")
            {
                lblUyariSoyadi.Visible = true;
                lblUyariSoyadi.Text = "Soyad Kısmı Boş Geçilemez";
            }
            else
            {
                lblUyariSoyadi.Visible = false;
            }
        }

        private void txtAdi_TextChanged(object sender, EventArgs e)
        {

            if (txtAdi.Text == "")
            {
                lblUyariAdi.Visible = true;
                lblUyariAdi.Text = "Ad Kısmı Boş Geçilemez";
            }
            else
            {
                lblUyariAdi.Visible = false;
            }
        }

        private void KullanıcıKayıtFormu_Load(object sender, EventArgs e)
        {
            txtKullanıcıAdi.Focus();
        }

        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTekrarSifre_KeyPress(object sender, KeyPressEventArgs e)
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

       

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
