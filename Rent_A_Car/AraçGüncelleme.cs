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
    public partial class AraçGüncelleme : Form
    {
        public static string plaka { get; set; }
        public AraçGüncelleme()
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
        void verilericek()
        {
            ds.Clear();
            object b = plaka;
            string komut = "select*from ARAC where PLAKA = '" + plaka + "'";
            OleDbDataAdapter db = new OleDbDataAdapter(komut, con);
            db.Fill(ds, "ARAC");

        }

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

        private void AraçGüncelleme_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed) con.Open();
            verilericek();
            bs.DataSource = ds.Tables["ARAC"];
            txtPlakaNo.DataBindings.Clear();
            cmbMarka.DataBindings.Clear();
            cmbModel.DataBindings.Clear();
            txtModelYılı.DataBindings.Clear();
            txtMotorHacmi.DataBindings.Clear();
            cmbRenk.DataBindings.Clear();
            cmbVites.DataBindings.Clear();
            dtEklemeTarihi.DataBindings.Clear();
            dtGüncellemeTarihi.DataBindings.Clear();
            cmbYakıt.DataBindings.Clear();
            txtKira.DataBindings.Clear();
            pictureBox1.DataBindings.Clear();



            txtPlakaNo.DataBindings.Add("Text", bs, "PLAKA");
            cmbMarka.DataBindings.Add("Text", bs, "MARKA");
            cmbModel.DataBindings.Add("Text", bs, "MODEL");
            txtModelYılı.DataBindings.Add("Text", bs, "MODEL_YILI");
            txtMotorHacmi.DataBindings.Add("Text", bs, "MOTOR_HACMI");
            cmbRenk.DataBindings.Add("Text", bs, "RENK");
            cmbVites.DataBindings.Add("Text", bs, "VITES_TURU");
            dtGüncellemeTarihi.DataBindings.Add("Text", bs, "GUNCELLEME_TARIHI");
            cmbYakıt.DataBindings.Add("Text", bs, "YAKIT_TURU");
            dtEklemeTarihi.DataBindings.Add("Text", bs, "EKLEME_TARIHI");
            txtKira.DataBindings.Add("Text", bs, "ARAC_UCRETI");
            pictureBox1.DataBindings.Add("ImageLocation", bs, "RESIM");
            con.Close();
            markacek();
            vites();
            yakit();
        }

        private void AraçGüncelleme_FormClosed(object sender, FormClosedEventArgs e)
        {
            AraçListesi araclistesi = (AraçListesi)Application.OpenForms["AraçListesi"];
            araclistesi.listele();
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
            komut.CommandText = "select * from MODEL where MARKA_ID='" + markaid + "'";
            dr = komut.ExecuteReader();
            cmbModel.Items.Clear();
            while (dr.Read())
            {
                cmbModel.Items.Add(dr["MODEL_ADI"]);
            }
        }

        private void btnResimGuncelle_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath + "\\resim\\";
            DialogResult sonuc = openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
           
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

        private void txtModelYılı_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnVazgeç_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMotorHacmi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPlakaNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPlakaNo.Text = txtPlakaNo.Text.ToUpper();
            txtPlakaNo.SelectionStart = txtPlakaNo.Text.Length;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update  ARAC set PLAKA=@PLAKA,MARKA=@MARKA,MODEL=@MODEL,MOTOR_HACMI=@MOTOR_HACMI," +
                "YAKIT_TURU=@YAKIT_TURU,VITES_TURU=@VITES_TURU,MODEL_YILI=@MODEL_YILI,EKLEME_TARIHI=@EKLEME_TARIHI,GUNCELLEME_TARIHI=@GUNCELLEME_TARIHI,RENK=@RENK," +
                "ARAC_UCRETI=@ARAC_UCRETI,RESIM=@RESIM where PLAKA = '" + plaka + "'";


            cmd.Parameters.AddWithValue("@PLAKA", txtPlakaNo.Text);

            cmd.Parameters.AddWithValue("@MARKA", cmbMarka.Text);

            cmd.Parameters.AddWithValue("@MODEL", cmbModel.Text);

            cmd.Parameters.AddWithValue("@MOTOR_HACMI", txtMotorHacmi.Text);

            cmd.Parameters.AddWithValue("@YAKIT_TURU", cmbYakıt.Text);

            cmd.Parameters.AddWithValue("@VITES_TURU", cmbVites.SelectedItem);

            cmd.Parameters.AddWithValue("@MODEL_YILI", txtModelYılı.Text);

            cmd.Parameters.AddWithValue("@EKLEME_TARIHI", dtEklemeTarihi.Text);

            cmd.Parameters.AddWithValue("@GUNCELLEME_TARIHI", dtGüncellemeTarihi.Text);

            cmd.Parameters.AddWithValue("@RENK", cmbRenk.Text);

            cmd.Parameters.AddWithValue("@ARAC_UCRETI", txtKira.Text);

            cmd.Parameters.AddWithValue("@RESIM", pictureBox1.ImageLocation);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("KAYIT GÜNCELLEMESİ GERÇEKLEŞTİ");

        }
    }
}
