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
    public partial class YeniAraçKaydı : Form
    {
        public YeniAraçKaydı()
        {
            InitializeComponent();
        }



        OleDbConnection con = new OleDbConnection
      ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RentACar.mdb");
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();
        BindingSource bs = new BindingSource();
        OleDbDataReader dr;


        int markaid, modelid;
        bool kontrol = false;
        void markacek()
        {
            cmbMarka.Items.Clear();
            OleDbCommand komut = new OleDbCommand();
            if (con.State == ConnectionState.Closed) con.Open();
            komut.Connection = con;
            komut.CommandText = "select * from MARKA";
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbMarka.Items.Add(dr["MARKA_ADI"]);
            }
        }

        void vites()
        {
            OleDbCommand komut = new OleDbCommand();
            if (con.State == ConnectionState.Closed) con.Open();
            komut.Connection = con;            
            komut.CommandText = "select VITES_TURU from VITES_TURU";
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbVites.Items.Add(dr["VITES_TURU"].ToString());
            }
        }

        void yakit()
        {
            
            OleDbCommand kom = new OleDbCommand();
            if (con.State == ConnectionState.Closed) con.Open();
            kom.Connection = con;
            kom.CommandText = "select YAKIT_TURU from YAKIT_TURU";
            dr = kom.ExecuteReader();
            while (dr.Read())
            {
                cmbYakıt.Items.Add(dr["YAKIT_TURU"].ToString());
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            if (txtPlakaNo.Text == "" || txtMotorHacmi.Text == "" || txtModelYılı.Text == "" || txtKira.Text == "" || cmbMarka.Text == "" || cmbModel.Text == "" || cmbRenk.Text == "" || cmbVites.Text == "" || cmbYakıt.Text == "" || dtEklemeTarihi.Text == "" || dtGüncellemeTarihi.Text == "" || pictureBox1.ImageLocation == "" || kontrol == false)
            {
                MessageBox.Show("Tüm Kısımları doldurunuz");
            }
            else
            {
                OleDbCommand cmd2 = new OleDbCommand();
                cmd2.Connection = con;
                cmd2.CommandText = "select * from ARAC where PLAKA='" + txtPlakaNo.Text + "'";
                if (con.State == ConnectionState.Closed) con.Open();
                dr = cmd2.ExecuteReader();
                if (dr.Read())
                {
                    DialogResult cc = MessageBox.Show("Aynı PLAKADA Araç bulunmaktadır", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (cc == DialogResult.OK)
                    {
                        txtPlakaNo.Clear();
                    }
                }
                else
                {
                    con.Close();
                    con.Open();
                    OleDbCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO ARAC (PLAKA,MARKA,MODEL,MOTOR_HACMI,YAKIT_TURU,VITES_TURU,MODEL_YILI,EKLEME_TARIHI,GUNCELLEME_TARIHI,RENK,ARAC_UCRETI,DURUMU,RESIM) " +

                    "VALUES (@PLAKA,@MARKA,@MODEL,@MOTOR_HACMI,@YAKIT_TURU,@VITES_TURU,@MODEL_YILI,@EKLEME_TARIHI,@GUNCELLEME_TARIHI,@RENK,@ARAC_UCRETI,@DURUMU,@RESIM)";


                    cmd.Parameters.AddWithValue("@PLAKA", txtPlakaNo.Text);

                    cmd.Parameters.AddWithValue("@MARKA", cmbMarka.Text);

                    cmd.Parameters.AddWithValue("@MODEL", cmbModel.Text);

                    cmd.Parameters.AddWithValue("@MOTOR_HACMI", txtMotorHacmi.Text);

                    cmd.Parameters.AddWithValue("@YAKIT_TURU", cmbYakıt.Text);

                    cmd.Parameters.AddWithValue("@VITES_TURU", cmbVites.Text);

                    cmd.Parameters.AddWithValue("@MODEL_YILI", txtModelYılı.Text);

                    cmd.Parameters.AddWithValue("@EKLEME_TARIHI", dtEklemeTarihi.Text);

                    cmd.Parameters.AddWithValue("@GUNCELLEME_TARIHI", dtGüncellemeTarihi.Text);

                    cmd.Parameters.AddWithValue("@RENK", cmbRenk.Text);

                    cmd.Parameters.AddWithValue("@ARAC_UCRETI", txtKira.Text);

                    cmd.Parameters.AddWithValue("@DURUMU", "Boş");

                    cmd.Parameters.AddWithValue("@RESIM", pictureBox1.ImageLocation);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("KAYIT BAŞARIYLA GERÇEKLEŞTİ");
                }
            }
        }

        private void YeniAraçKaydı_FormClosed(object sender, FormClosedEventArgs e)
        {
            AraçListesi arackayıt = (AraçListesi)Application.OpenForms["AraçListesi"];
            arackayıt.listele();
        }

        private void btnMarkaEkle_Click(object sender, EventArgs e)
        {
            MarkaModelEkleme marka_model = new MarkaModelEkleme();
            this.Hide();
            marka_model.ShowDialog();
            this.Close();
        }

        private void YeniAraçKaydı_Load(object sender, EventArgs e)
        {
            yakit();
            vites();
            markacek();
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = con;
            if (con.State == ConnectionState.Closed) con.Open();
            komut.CommandText = "select MARKA_ID from MARKA where MARKA_ADI='" + cmbMarka.Text + "'";
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                markaid = int.Parse(dr.GetValue(0).ToString());
            }
            dr.Close();
            if (con.State == ConnectionState.Closed) con.Open();
            komut.Connection = con;
            komut.CommandText = "select * from MODEL where MARKA_ID=" + markaid + "";
            dr = komut.ExecuteReader();
            cmbModel.Items.Clear();
            while (dr.Read())
            {
                cmbModel.Items.Add(dr["MODEL_ADI"]);
            }
        }

        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = con;
            if (con.State == ConnectionState.Closed) con.Open();
            komut.CommandText = "select MODEL_ID from MODEL where MODEL_ADI='" + cmbModel.Text + "'";
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                modelid = int.Parse(dr.GetValue(0).ToString());
            }
            dr.Close();
        }

        private void txtPlakaNo_TextChanged(object sender, EventArgs e)
        {
            txtPlakaNo.Text = txtPlakaNo.Text.ToUpper();
            txtPlakaNo.SelectionStart = txtPlakaNo.Text.Length;
        }

        private void txtMotorHacmi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtModelYılı_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVazgeç_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbVites_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnvitestürü_Click(object sender, EventArgs e)
        {
            VitesTürüEkle vites = new VitesTürüEkle();
            this.Hide();
            vites.ShowDialog();
            this.Show();
        }

        private void btnyakıttürü_Click(object sender, EventArgs e)
        {
            YakıtTürü yakit = new YakıtTürü();
            this.Hide();
            yakit.ShowDialog();
            this.Show();
        }

        private void cmbYakıt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath + "\\resim\\";
            DialogResult sonuc = openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            kontrol = true;
        }
    }
}
