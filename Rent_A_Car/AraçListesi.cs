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
    public partial class AraçListesi : Form
    {
        public AraçListesi()
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
        bool kontrol;
        public void listele()
        {
            string sec = " select * from ARAC";
            OleDbDataAdapter da = new OleDbDataAdapter(sec, con);
            ds.Clear();
            da.Fill(ds, "ARAC");

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

        void verilericek()
        {
            ds.Clear();
            string komut = "select Ma.MARKA_ADI,M.MODEL_ADI,A.ARAC_ID,A.PLAKA,A.MODEL,A.MARKA,A.MOTOR_HACMI,A.YAKIT_TURU,A.VITES_TURU,A.RENK,A.EKLEME_TARIHI,A.GUNCELLEME_TARIHI,A.RENK,A.MODEL_YILI,A.ARAC_UCRETI,A.DURUMU,A.RESIM from ARAC as [A],MARKA as [Ma],MODEL as [M] where M.MARKA_ID=Ma.MARKA_ID and A.MARKA=Ma.MARKA_ADI and DURUMU='Boş'";
            OleDbDataAdapter da = new OleDbDataAdapter(komut, con);
            if (con.State == ConnectionState.Closed) con.Open();
            da.Fill(ds, "ARAC");
            bs.DataSource = ds.Tables["ARAC"];
            dataGridView1.DataSource = bs;
            con.Close();
        }

        void arama(string aranan)
        {

            ds.Clear();
            if (ds.Tables["ARAC"] != null) ds.Tables["ARAC"].Clear();
            string seckomutu = aranan;
            OleDbDataAdapter da = new OleDbDataAdapter(seckomutu, con);
            da.Fill(ds, "ARAC");
        }



        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            YeniAraçKaydı arackaydı = new YeniAraçKaydı();
            this.Hide();
            arackaydı.ShowDialog();
            this.Show();
        }

        private void cmbAra_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbAra.SelectedIndex == 0)
                {
                    listele();
                }
                if (cmbAra.SelectedIndex == 1)
                {
                    string sec = " select * from ARAC where DURUMU='Boş'";
                    OleDbDataAdapter da2 = new OleDbDataAdapter(sec, con);
                    ds.Clear();
                    da2.Fill(ds, "ARAC");
                }

                if (cmbAra.SelectedIndex == 2)
                {
                    string sec = " select * from ARAC where DURUMU='Dolu'";
                    OleDbDataAdapter da2 = new OleDbDataAdapter(sec, con);
                    ds.Clear();
                    da2.Fill(ds, "ARAC");
                }
            }
            catch { }
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed) con.Open();
            cmd.CommandText = "select MARKA_ID from MARKA where MARKA_ADI='" + cmbMarka.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                markaid = int.Parse(dr.GetValue(0).ToString());
            }
            dr.Close();
            if (con.State == ConnectionState.Closed) con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select * from MODEL where MARKA_ID=" + markaid + "";
            dr = cmd.ExecuteReader();
            cmbModel.Items.Clear();
            while (dr.Read())
            {
                cmbModel.Items.Add(dr["MODEL_ADI"]);
            }
        }

        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed) con.Open();
            cmd.CommandText = "select MODEL_ID from MODEL where MODEL_ADI='" + cmbModel.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                modelid = int.Parse(dr.GetValue(0).ToString());
            }
            dr.Close();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {

            if (cmbMarka.SelectedIndex > 0 || cmbModel.SelectedIndex > 0)
            {
                string seckomutu = "select Ma.MARKA_ADI,M.MODEL_ADI,A.ARAC_ID,A.PLAKA,A.MODEL,A.MARKA,A.MOTOR_HACMI,A.YAKIT_TURU,A.VITES_TURU,A.RENK,A.EKLEME_TARIHI,A.GUNCELLEME_TARIHI,A.RENK,A.MODEL_YILI,A.ARAC_UCRETI,A.DURUMU,A.RESIM from ARAC as [A],MARKA as [Ma],MODEL as [M] where M.MARKA_ID=Ma.MARKA_ID and A.MARKA=Ma.MARKA_ADI like '" + cmbMarka.Text + "%' and MODEL_ADI like '" + cmbModel.Text + "%'and DURUMU='Boş'";
                arama(seckomutu);
            }
            else if (cmbModel.SelectedIndex < 0 || cmbMarka.SelectedIndex > 0)
            {
                string seckomutu = "select Ma.MARKA_ADI,M.MODEL_ADI,A.ARAC_ID,A.PLAKA,A.MODEL,A.MARKA,A.MOTOR_HACMI,A.YAKIT_TURU,A.VITES_TURU,A.RENK,A.EKLEME_TARIHI,A.GUNCELLEME_TARIHI,A.RENK,A.MODEL_YILI,A.ARAC_UCRETI,A.DURUMU,A.RESIM from ARAC as [A],MARKA as [Ma],MODEL as [M] where M.MARKA_ID=Ma.MARKA_ID and A.MARKA=Ma.MARKA_ADI like '" + cmbMarka.Text + "%'and durum='Boş'";
                arama(seckomutu);
            }
        }

        private void btnAracDüzenle_Click(object sender, EventArgs e)
        {
            if (kontrol == false)
            {
                MessageBox.Show("Lütfen Araç Seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                AraçGüncelleme aracguncelleme = new AraçGüncelleme();
                this.Hide();
                aracguncelleme.ShowDialog();
                this.Show();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            AraçGüncelleme.plaka = (dataGridView1.CurrentRow.Cells["PLAKA"].Value).ToString();
            kontrol = true;
        }

        private void tbAracArama_TextChanged(object sender, EventArgs e)
        {
            string bul = "select * from ARAC where PLAKA like '%" + tbAracArama.Text + "%'";
            OleDbDataAdapter da = new OleDbDataAdapter(bul, con);
            ds.Clear();
            da.Fill(ds, "ARAC");
        }

        private void btnAracSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Emin misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("delete from [ARAC] where PLAKA=@PLAKA", con);
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@PLAKA", dataGridView1.CurrentRow.Cells[1].Value);
                cmd.ExecuteNonQuery();
                listele();
                con.Close();
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            verilericek();
        }

        private void btnMarkaEkle_Click(object sender, EventArgs e)
        {
            MarkaModelEkleme ekle = new MarkaModelEkleme();
            this.Hide();
            ekle.ShowDialog();
            this.Show();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnvazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AraçListesi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Kiralama kiralama = (Kiralama)Application.OpenForms["Kiralama"];
            kiralama.GOSTER();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aracraporlama arac = new aracraporlama();
            this.Hide();
            arac.ShowDialog();
            this.Show();
        }

        private void AraçListesi_Load(object sender, EventArgs e)
        {
           con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("select * From ARAC ", con);
            da.Fill(ds, "ARAC");
            dataGridView1.DataSource = ds.Tables["ARAC"];
            da.Dispose();
            con.Close();
            cmbAra.SelectedIndex = 0;
            markacek();
            verilericek();
        }
    }
}
