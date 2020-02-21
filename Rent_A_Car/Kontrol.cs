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
    public partial class Kontrol : Form
    {
        public static string guvkul { get; set; }
        public Kontrol()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection
("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RentACar.mdb");
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();
        BindingSource bs = new BindingSource();
        OleDbDataReader dr;

       

        private void txtsifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Kontrol_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click_1(object sender, EventArgs e)
        {
            if(txtsifre.Text=="")
            {
                MessageBox.Show("Şifreyi Giriniz");
            }
            else
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from UYE_BILGI where UYE_KULLANICI_ADI='" + Form1.ka + "'and UYE_SIFRE=" + int.Parse(txtsifre.Text);
                con.Open();
                dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    Üyeİşlemleri islem = new Üyeİşlemleri();
                    Üyeİşlemleri.kulad = Form1.ka;
                    this.Hide();
                    islem.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Yanlış Şifre Girdiniz");
                }
                con.Close();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
