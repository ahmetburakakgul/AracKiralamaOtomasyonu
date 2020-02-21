using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.OleDb;

namespace Rent_A_Car
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string ka;

        OleDbConnection con = new OleDbConnection
       ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RentACar.mdb");
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();
        BindingSource bs = new BindingSource();
        OleDbDataReader dr;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void btnKucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblKullanıcıGirisi_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void btnGiris_Click(object sender, EventArgs e)
        {

            if (txtKullanıcıAdı.Text == "" && txtSifre.Text == "")
            {
                MessageBox.Show("Eksik Bilgi Girdiniz");
            }
            else
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from UYE_BILGI where UYE_KULLANICI_ADI='" + txtKullanıcıAdı.Text + "' and UYE_SIFRE= " + int.Parse(txtSifre.Text);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    ka = dr["UYE_KULLANICI_ADI"].ToString();
                    Anasayfa anasayfa = new Anasayfa();
                    Anasayfa.kullanici = txtKullanıcıAdı.Text;
                    this.Hide();
                    anasayfa.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Yanlış Kullanıcı adı şifre giriniz");
                }
                con.Close();
            }
        }

        private void btnKullanıcıKayıt_Click(object sender, EventArgs e)
        {
            KullanıcıKayıtFormu kullanıcıkayıt = new KullanıcıKayıtFormu();
            this.Hide();
            kullanıcıkayıt.ShowDialog();
            this.Show();
        }

        private void lblsiremiunuttum_DoubleClick(object sender, EventArgs e)
        {
            SifremiUnuttum sifre = new SifremiUnuttum();
            this.Hide();
            sifre.ShowDialog();
            this.Show();
        }

        private void txtKullanıcıAdı_TextChanged(object sender, EventArgs e)
        {
            txtKullanıcıAdı.Text = txtKullanıcıAdı.Text.ToLower();
            txtKullanıcıAdı.SelectionStart = txtKullanıcıAdı.Text.Length;
        }

        private void txtSifre_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
