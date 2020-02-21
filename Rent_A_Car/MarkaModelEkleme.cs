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
    public partial class MarkaModelEkleme : Form
    {
        public MarkaModelEkleme()
        {
            InitializeComponent();
        }



        OleDbConnection con = new OleDbConnection
    ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RentACar.mdb");
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();
        BindingSource bs = new BindingSource();
        OleDbDataReader dr;
        OleDbDataReader dr3;

        int markaid;
        bool durum;


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





        void Kontrol()
        {

            if (con.State == ConnectionState.Closed) con.Open();
            OleDbCommand komut3 = new OleDbCommand("select * from MARKA where MARKA_ADI=@MARKA_ADI", con);
            komut3.Parameters.AddWithValue("@MARKA_ADI", txtMarka.Text);
            dr3 = komut3.ExecuteReader();
            if (dr.Read())
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
            con.Close();
        }



        private void btnEkle_Click(object sender, EventArgs e)
        {

            if (cmbMarka.Text == "" || txtModel.Text == "")
            {
                MessageBox.Show("Marka ve Model Giriniz");
            }
            else
            {
                if (con.State == ConnectionState.Closed) con.Open();
                OleDbCommand komut = new OleDbCommand();
                komut.Connection = con;
                komut.CommandText = "insert into MODEL(MODEL_ADI,MARKA_ID) values (@MODEL_ADI,@MARKA_ID)";
                komut.Parameters.AddWithValue("@MODEL_ADI", txtModel.Text);
                komut.Parameters.AddWithValue("@MARKA_ID", markaid);
                komut.ExecuteNonQuery();
                con.Close();
                DialogResult cevap = MessageBox.Show("Kayıt Yapıldı \nBaşka Kayıt Yapmak İster Misiniz?", "Bilgi Kutusu", MessageBoxButtons.YesNoCancel);
                if (DialogResult.No == cevap)
                {
                    YeniAraçKaydı yenikayit = new YeniAraçKaydı();
                    this.Hide();
                    yenikayit.ShowDialog();
                }
                else if (DialogResult.Yes == cevap)
                {
                    txtMarka.Clear();
                }
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            YeniAraçKaydı yenikayit = new YeniAraçKaydı();
            this.Hide();
            yenikayit.ShowDialog();
        }

        private void txtModel_TextChanged(object sender, EventArgs e)
        {
            txtModel.Text = txtModel.Text.ToUpper();
            txtModel.SelectionStart = txtModel.Text.Length;
        }

        private void txtMarka_TextChanged(object sender, EventArgs e)
        {
            txtMarka.Text = txtMarka.Text.ToUpper();
            txtMarka.SelectionStart = txtMarka.Text.Length;
        }

        private void btnEkle2_Click(object sender, EventArgs e)
        {
            if (txtMarka.Text == "")
            {
                MessageBox.Show("Marka Giriniz");
            }
            else
            {
                OleDbCommand cmdd = new OleDbCommand();
                cmdd.Connection = con;
                cmdd.CommandText = "select * from MARKA where MARKA_ADI='" + txtMarka.Text + "'";
                if (con.State == ConnectionState.Closed) con.Open();
                dr = cmdd.ExecuteReader();
                if (dr.Read())
                {
                    DialogResult cc = MessageBox.Show("Aynı Marka Bulunmaktadır");
                    if (cc == DialogResult.OK)
                    {
                        txtMarka.Clear();
                    }
                }
                else
                {
                    if (con.State == ConnectionState.Closed) con.Open();
                    OleDbCommand komut = new OleDbCommand();
                    komut.Connection = con;
                    komut.CommandText = "insert into MARKA(MARKA_ADI) values (@MARKA_ADI)";
                    komut.Parameters.AddWithValue("@MARKA_ADI", txtMarka.Text);
                    komut.ExecuteNonQuery();
                    con.Close();
                    DialogResult cevap = MessageBox.Show("Kayıt Yapıldı \nBaşka Kayıt Eklemek İstiyor Musunuz?", "Bilgi Kutusu", MessageBoxButtons.YesNoCancel);
                    if (DialogResult.No == cevap)
                    {
                        MarkaModelEkleme markamodel = new MarkaModelEkleme();
                        this.Hide();
                        markamodel.ShowDialog();
                    }
                    else if (DialogResult.Yes == cevap)
                    {
                        txtMarka.Clear();
                    }
                }

            }
        }

        private void lblModelEkle_Click(object sender, EventArgs e)
        {

            gbMarka.Visible = false;
            gbModel.Visible = true;
        }

        private void lblMarkaEkle_Click(object sender, EventArgs e)
        {
            gbMarka.Visible = true;
            gbModel.Visible = false;
        }

        private void MarkaModelEkleme_Load(object sender, EventArgs e)
        {
            markacek();
            cmbMarka.Refresh();
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
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
