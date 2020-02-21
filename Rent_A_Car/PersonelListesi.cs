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
    public partial class PersonelListesi : Form
    {
        public PersonelListesi()
        {
            InitializeComponent();
        }
        bool kontrol;

        OleDbConnection con = new OleDbConnection
      ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RentACar.mdb");
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();
        BindingSource bs = new BindingSource();
      

        public void verilerigoster()
        {
            string sec = " select * from PERSONEL";
            OleDbDataAdapter da = new OleDbDataAdapter(sec, con);
            ds.Clear();
            da.Fill(ds, "PERSONEL");

        }



        private void PersonelListesi_Load(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("select * From PERSONEL ", con);
            da.Fill(ds, "PERSONEL");
            dataGridView1.DataSource = ds.Tables["PERSONEL"];
            da.Dispose();
            con.Close();
            verilerigoster();
            if (radioButton1.Checked == true)
            {
                radioButton2.Checked = false;
                radioButton3.Checked = false;
            }
        }

        private void btnyenikayit_Click(object sender, EventArgs e)
        {

            Personel_Kayıt_Formu personel_kayıt = new Personel_Kayıt_Formu();
            this.Hide();
            personel_kayıt.ShowDialog();
            this.Show();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Emin misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("delete from [PERSONEL] where PERSONEL_ID=@PERSONEL_ID", con);
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@PERSONEL_ID", dataGridView1.CurrentRow.Cells[0].Value);
                cmd.ExecuteNonQuery();
                verilerigoster();
                con.Close();

            }
        }

        private void tbpersonelarama_TextChanged(object sender, EventArgs e)
        {
            string bul = "select * from PERSONEL where TC_KIMLIK_NO like '%" + tbpersonelarama.Text + "%'";
            OleDbDataAdapter da = new OleDbDataAdapter(bul, con);
            ds.Clear();
            da.Fill(ds, "PERSONEL");
            tbpersonelarama.Text = tbpersonelarama.Text.ToUpper();
            tbpersonelarama.SelectionStart = tbpersonelarama.Text.Length;
        }

        private void btnduzenle_Click(object sender, EventArgs e)
        {
            if (kontrol == false)
            {
                MessageBox.Show("Lütfen Personel Seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                PersonelGüncelleme personel = new PersonelGüncelleme();
                this.Hide();
                personel.ShowDialog();
                this.Show(); 
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PersonelGüncelleme.personel_id = (dataGridView1.CurrentRow.Cells["PERSONEL_ID"].Value).ToString();
            kontrol = true;
        }

        private void btnvazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {

                tbpersonelarama.Enabled = true;
                tbpersonelarama.Focus(); textBox1.Clear(); textBox2.Clear();
            }
            else
                tbpersonelarama.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {

                textBox1.Enabled = true;
                textBox1.Focus(); tbpersonelarama.Clear(); textBox2.Clear();
            }
            else
                textBox1.Enabled = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {

                textBox2.Enabled = true;
                textBox2.Focus(); tbpersonelarama.Clear(); textBox1.Clear();
            }
            else
                textBox2.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string bul = "select * from PERSONEL where ADI like '%" + textBox1.Text + "%'";
            OleDbDataAdapter da = new OleDbDataAdapter(bul, con);
            ds.Clear();
            da.Fill(ds, "PERSONEL");
            tbpersonelarama.Text = tbpersonelarama.Text.ToUpper();
            tbpersonelarama.SelectionStart = tbpersonelarama.Text.Length;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string bul = "select * from PERSONEL where SOYADI like '%" + textBox2.Text + "%'";
            OleDbDataAdapter da = new OleDbDataAdapter(bul, con);
            ds.Clear();
            da.Fill(ds, "PERSONEL");
            tbpersonelarama.Text = tbpersonelarama.Text.ToUpper();
            tbpersonelarama.SelectionStart = tbpersonelarama.Text.Length;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
