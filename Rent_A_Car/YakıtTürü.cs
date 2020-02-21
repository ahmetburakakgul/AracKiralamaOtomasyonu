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
    public partial class YakıtTürü : Form
    {
        public YakıtTürü()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection
("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RentACar.mdb");
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();
        BindingSource bs = new BindingSource();
        OleDbDataReader dr;


        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Yakıt Türü Giriniz");
            }
            else
            {
                OleDbCommand komut2 = new OleDbCommand();
                komut2.Connection = con;
                komut2.CommandText = "select * from YAKIT_TURU where YAKIT_TURU='" + textBox1.Text + "'";
                if (con.State == ConnectionState.Closed) con.Open();
                dr = komut2.ExecuteReader();
                if (dr.Read())
                {
                    DialogResult cc = MessageBox.Show("Aynı Yakıt Türü  bulunmaktadır", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (cc == DialogResult.OK)
                    {
                        textBox1.Clear();
                    }
                }
                else
                {
                    if (con.State == ConnectionState.Closed) con.Open();
                    OleDbCommand komut = new OleDbCommand();
                    komut.Connection = con;
                    komut.CommandText = "insert into YAKIT_TURU(YAKIT_TURU) values (@YAKIT_TURU)";
                    komut.Parameters.AddWithValue("@YAKIT_TURU", textBox1.Text);
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
                        textBox1.Clear();
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToUpper();
            textBox1.SelectionStart = textBox1.Text.Length;
        }
    }
    }

