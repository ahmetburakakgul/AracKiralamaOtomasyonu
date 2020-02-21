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
    public partial class MüşteriListesi : Form
    {
        public MüşteriListesi()
        {
            InitializeComponent();
        }


        OleDbConnection con = new OleDbConnection
      ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RentACar.mdb");
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();
        BindingSource bs = new BindingSource();
        OleDbDataReader dr;
        bool kontrol;

        public void GOSTER()
        {
            string sec = " select * from MUSTERI";
            OleDbDataAdapter da = new OleDbDataAdapter(sec, con);
            ds.Clear();
            da.Fill(ds, "MUSTERI");

        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            MüşteriKaydı musterikayıt = new MüşteriKaydı();
            this.Hide();
            musterikayıt.ShowDialog();
            this.Show(); 
        }

        private void btnvazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MüşteriListesi_Load(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("select * From MUSTERI ", con);
            da.Fill(ds, "MUSTERI");
            dataGridView1.DataSource = ds.Tables["MUSTERI"];
            da.Dispose();
            con.Close();

          
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Emin misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("delete from [MUSTERI] where MUSTERI_ID=@MUSTERI_ID", con);
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@MUSTERI_ID", dataGridView1.CurrentRow.Cells[0].Value);
                cmd.ExecuteNonQuery();
                GOSTER();
                con.Close();
            }
        }

        private void tbMusteriArama_TextChanged(object sender, EventArgs e)
        {
            string bul = "select * from MUSTERI where TC like '%" + tbMusteriArama.Text + "%'";
            OleDbDataAdapter da = new OleDbDataAdapter(bul, con);
            ds.Clear();
            da.Fill(ds, "MUSTERI");
        }

        private void btnDüzenle_Click(object sender, EventArgs e)
        {
            if (kontrol == false)
            {
                MessageBox.Show("Lütfen Müşteri Seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MüşteriGüncelleme musteriguncelleme = new MüşteriGüncelleme();
                this.Hide();
                musteriguncelleme.ShowDialog();
                this.Show();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MüşteriGüncelleme.musteri_id = (dataGridView1.CurrentRow.Cells["MUSTERI_ID"].Value).ToString();
            kontrol = true;
        }

        private void MüşteriListesi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Kiralama kiralama = (Kiralama)Application.OpenForms["Kiralama"];
            kiralama.GOSTER();
        }

       

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {

                tbMusteriArama.Enabled = true;
                tbMusteriArama.Focus(); textBox1.Clear(); textBox2.Clear();
            }
            else
            tbMusteriArama.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {

                textBox1.Enabled = true;
                textBox1.Focus(); tbMusteriArama.Clear(); textBox2.Clear();
            }
            else
            textBox1.Enabled = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                textBox2.Enabled = true;
                textBox2.Focus(); textBox1.Clear(); tbMusteriArama.Clear();
            }
            else
                textBox2.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string bul = "select * from MUSTERI where ADI like '%" + textBox1.Text + "%'";
            OleDbDataAdapter da = new OleDbDataAdapter(bul, con);
            ds.Clear();
            da.Fill(ds, "MUSTERI");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string bul = "select * from MUSTERI where SOYADI like '%" + textBox2.Text + "%'";
            OleDbDataAdapter da = new OleDbDataAdapter(bul, con);
            ds.Clear();
            da.Fill(ds, "MUSTERI");
        }

        private void btnrapor_Click(object sender, EventArgs e)
        {
            musteriraporlama musteri = new musteriraporlama();
            this.Hide();
            musteri.ShowDialog();
            this.Show();
        }
    }
}
