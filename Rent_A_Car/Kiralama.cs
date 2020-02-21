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
    public partial class Kiralama : Form
    {
        public Kiralama()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection
        ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RentACar.mdb");
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();
        BindingSource bs = new BindingSource();
        OleDbDataReader dr;

        AraçKiralama arackiralama = new AraçKiralama();

        private void BosAraclar()
        {

            string sorgu2 = "select * from  ARAC where DURUMU='Boş'";
            arackiralama.BosAraclar(cmbAracPlakası, sorgu2);
        }

        public void GOSTER()
        {
            string sec = " select * from ARAC_KIRALAMA";
            OleDbDataAdapter da = new OleDbDataAdapter(sec, con);
            ds.Clear();
            da.Fill(ds, "ARAC_KIRALAMA");

        }

        private void Yenile()
        {
            string sorgu3 = "select * from ARAC_KIRALAMA";
            OleDbDataAdapter adtr2 = new OleDbDataAdapter();
            dataGridView1.DataSource = arackiralama.listele(adtr2, sorgu3);
        }

        private void Temizle()
        {
            dtCıkıs.Text = DateTime.Now.ToShortDateString();
            dtDonus.Text = DateTime.Now.ToShortDateString();
            cmbKira.Text = "";
            txtKiraÜcreti.Text = "";
            txtGun.Text = "";
            txtToplamTutar.Text = "";
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KayıtlıMüşteri musteri = new KayıtlıMüşteri();
            this.Hide();
            musteri.ShowDialog();
            this.Show();
        }

        private void btnAracTeslim_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            string sorgu1 = "delete from ARAC_KIRALAMA where PLAKA='" + satir.Cells["PLAKA"].Value.ToString() + "'";
            OleDbCommand cmd1 = new OleDbCommand();
            arackiralama.ekle_guncelle(cmd1, sorgu1);
            string sorgu2 = "update ARAC set DURUMU='Boş' where PLAKA='" + satir.Cells["PLAKA"].Value.ToString() + "'";
            OleDbCommand cmd2 = new OleDbCommand();
            arackiralama.ekle_guncelle(cmd2, sorgu2);
            MessageBox.Show("ARAÇ TESLİM EDİLDİ");
            cmbAracPlakası.Text = "";
            cmbAracPlakası.Items.Clear();
            BosAraclar();
            Yenile();

            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
            cmbAracPlakası.Text = "";
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "update ARAC_KIRALAMA set TC=@TC,ADI=@ADI,SOYADI=@SOYADI,GSM_NO=@GSM_NO,ADRES=@ADRES,PLAKA=@PLAKA,MARKA=@MARKA,MODEL=@MODEL,YAKIT_TURU=@YAKIT_TURU,VITES_TURU=@VITES_TURU,MODEL_YILI=@MODEL_YILI,RENK=@RENK,KIRA_SEKLI=@KIRA_SEKLI,KIRA_UCRETI=@KIRA_UCRETI,GUN=@GUN,TOPLAM_TUTAR=@TOPLAM_TUTAR,CIKIS_TARIHI=@CIKIS_TARIHI,DONUS_TARIHI=@DONUS_TARIHI where PLAKA=@PLAKA";
            OleDbCommand cmd = new OleDbCommand(sorgu2);

            cmd.Parameters.AddWithValue("@TC", txtTCKimlik.Text);
            cmd.Parameters.AddWithValue("@ADI", txtAdi.Text);
            cmd.Parameters.AddWithValue("@SOYADI", txtSoyadi.Text);
            cmd.Parameters.AddWithValue("@GSM_NO,", txtGsM.Text);
            cmd.Parameters.AddWithValue("@ADRES", txtAdres.Text);
            cmd.Parameters.AddWithValue("@PLAKA", cmbAracPlakası.Text);
            cmd.Parameters.AddWithValue("@MARKA", txtMarka.Text);
            cmd.Parameters.AddWithValue("@MODEL", txtModel.Text);
            cmd.Parameters.AddWithValue("@YAKIT_TURU", txtYakıtTuru.Text);
            cmd.Parameters.AddWithValue("@VITES_TURU", txtVitesTuru.Text);
            cmd.Parameters.AddWithValue("@MODEL_YILI", txtModelyılı.Text);
            cmd.Parameters.AddWithValue("@RENK", txtModelyılı.Text);
            cmd.Parameters.AddWithValue("@KIRA_SEKLI", cmbKira.Text);
            cmd.Parameters.AddWithValue("@KIRA_UCRETI", txtKiraÜcreti.Text);
            cmd.Parameters.AddWithValue("@GUN", txtGun.Text);
            cmd.Parameters.AddWithValue("@TOPLAM_TUTAR", txtToplamTutar.Text);
            cmd.Parameters.AddWithValue("@CIKIS_TARIHI", dtCıkıs.Text);
            cmd.Parameters.AddWithValue("@DONUS_TARIHI", dtDonus.Text);
            arackiralama.ekle_guncelle(cmd, sorgu2);

            cmbAracPlakası.Items.Clear();
            BosAraclar();
            Yenile();

            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
            cmbAracPlakası.Text = "";
            btnTemizle.Enabled = true;
            Temizle();
            MessageBox.Show("Güncelleme Tamamlandı");
        }

        private void txtTCKimlik_TextChanged(object sender, EventArgs e)
        {
            if (txtTCKimlik.Text == "") foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            string sorgu2 = "select * from MUSTERI where TC like '" + txtTCKimlik.Text + "'";
            arackiralama.TC_ARA(txtTCKimlik, txtAdi, txtSoyadi, txtGsM, txtAdres, sorgu2);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtTCKimlik.Text == "" || txtAdi.Text == "" || txtSoyadi.Text == "" || txtGsM.Text == "" || txtAdres.Text == "" || txtGun.Text == "" || txtKiraÜcreti.Text == "" || txtMarka.Text == "" || txtModel.Text == "" || txtModelyılı.Text == "" || txtRenk.Text == "" || txtToplamTutar.Text == "" || txtVitesTuru.Text == "" || txtYakıtTuru.Text == "" || cmbAracPlakası.Text == "" || dtCıkıs.Text == "" || dtDonus.Text == "")
            {
                MessageBox.Show("Tüm Alanları Doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                OleDbCommand cmd3 = new OleDbCommand();
                cmd3.Connection = con;
                cmd3.CommandText = "select * from ARAC_KIRALAMA where PLAKA='" + cmbAracPlakası.Text + "'";
                if (con.State == ConnectionState.Closed) con.Open();
                dr = cmd3.ExecuteReader();
                if (dr.Read())
                {
                    DialogResult cc = MessageBox.Show("Araç Kiralanmıştır Boş Bir Araç Seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (cc == DialogResult.OK)
                    {
                        cmbAracPlakası.Items.Clear();
                    }
                }
                else
                {
                    string sorgu2 = "insert into ARAC_KIRALAMA(TC,ADI,SOYADI,GSM_NO,ADRES,PLAKA,MARKA,MODEL,YAKIT_TURU,VITES_TURU,MODEL_YILI,RENK,KIRA_SEKLI,KIRA_UCRETI,GUN,TOPLAM_TUTAR,CIKIS_TARIHI,DONUS_TARIHI)" +
                    "values(@TC,@ADI,@SOYADI,@GSM_NO,@ADRES,@PLAKA,@MARKA,@MODEL,@YAKIT_TURU,@VITES_TURU,@MODEL_YILI,@RENK,@KIRA_SEKLI,@KIRA_UCRETI,@GUN,@TOPLAM_TUTAR,@CIKIS_TARIHI,@DONUS_TARIHI)";
                    OleDbCommand cmd = new OleDbCommand(sorgu2);

                    cmd.Parameters.AddWithValue("@TC", txtTCKimlik.Text);
                    cmd.Parameters.AddWithValue("@ADI", txtAdi.Text);
                    cmd.Parameters.AddWithValue("@SOYADI", txtSoyadi.Text);
                    cmd.Parameters.AddWithValue("@GSM_NO,", txtGsM.Text);
                    cmd.Parameters.AddWithValue("@ADRES", txtAdres.Text);
                    cmd.Parameters.AddWithValue("@PLAKA", cmbAracPlakası.Text);
                    cmd.Parameters.AddWithValue("@MARKA", txtMarka.Text);
                    cmd.Parameters.AddWithValue("@MODEL", txtModel.Text);
                    cmd.Parameters.AddWithValue("@YAKIT_TURU", txtYakıtTuru.Text);
                    cmd.Parameters.AddWithValue("@VITES_TURU", txtVitesTuru.Text);
                    cmd.Parameters.AddWithValue("@MODEL_YILI", txtModelyılı.Text);
                    cmd.Parameters.AddWithValue("@RENK", txtRenk.Text);
                    cmd.Parameters.AddWithValue("@KIRA_SEKLI", cmbKira.Text);
                    cmd.Parameters.AddWithValue("@KIRA_UCRETI", txtKiraÜcreti.Text);
                    cmd.Parameters.AddWithValue("@GUN", txtGun.Text);
                    cmd.Parameters.AddWithValue("@TOPLAM_TUTAR", txtToplamTutar.Text);
                    cmd.Parameters.AddWithValue("@CIKIS_TARIHI", dtCıkıs.Text);
                    cmd.Parameters.AddWithValue("@DONUS_TARIHI", dtDonus.Text);
                    arackiralama.ekle_guncelle(cmd, sorgu2);

                    string sorgu3 = "update ARAC set DURUMU='Dolu' where PLAKA='" + cmbAracPlakası.Text + "'";
                    OleDbCommand cmd2 = new OleDbCommand();
                    arackiralama.ekle_guncelle(cmd2, sorgu3);
                    cmbAracPlakası.Items.Clear();
                    BosAraclar();
                    Yenile();

                    foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
                    foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
                    cmbAracPlakası.Text = "";
                    Temizle();
                    MessageBox.Show("Araç Kiralandı");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            txtTCKimlik.Text = satır.Cells[1].Value.ToString();
            txtAdi.Text = satır.Cells[2].Value.ToString();
            txtSoyadi.Text = satır.Cells[3].Value.ToString();
            txtGsM.Text = satır.Cells[4].Value.ToString();
            txtAdres.Text = satır.Cells[5].Value.ToString();
            cmbAracPlakası.Text = satır.Cells[6].Value.ToString();
            txtMarka.Text = satır.Cells[7].Value.ToString();
            txtModel.Text = satır.Cells[8].Value.ToString();
            txtYakıtTuru.Text = satır.Cells[9].Value.ToString();
            txtVitesTuru.Text = satır.Cells[10].Value.ToString();
            txtModelyılı.Text = satır.Cells[11].Value.ToString();
            txtRenk.Text = satır.Cells[12].Value.ToString();
            cmbKira.Text = satır.Cells[13].Value.ToString();
            txtKiraÜcreti.Text = satır.Cells[14].Value.ToString();
            txtGun.Text = satır.Cells[15].Value.ToString();
            txtToplamTutar.Text = satır.Cells[16].Value.ToString();
            dtCıkıs.Value = Convert.ToDateTime(satır.Cells[17].Value.ToString());
            dtDonus.Value = Convert.ToDateTime(satır.Cells[18].Value.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Kayıtlı_Araçlar araclar = new Kayıtlı_Araçlar();
            this.Hide();
            araclar.ShowDialog();
            this.Show();
            
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {

            TimeSpan GunFarkı = (DateTime.Parse(dtDonus.Text) - DateTime.Parse(dtCıkıs.Text));
            int GunFarkı2 = GunFarkı.Days;
            txtGun.Text = GunFarkı2.ToString();
            txtToplamTutar.Text = (GunFarkı2 * int.Parse(txtKiraÜcreti.Text)).ToString();
        }

        private void cmbKira_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "select * from ARAC where PLAKA like '" + cmbAracPlakası.SelectedItem + "'";
            arackiralama.Ucret_Hesapla(cmbKira, txtKiraÜcreti, sorgu2);
        }

        private void cmbAracPlakası_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "select * from ARAC where PLAKA like '" + cmbAracPlakası.SelectedItem + "'";
            arackiralama.CombodanGetir(cmbAracPlakası, txtMarka, txtModel, txtYakıtTuru, txtVitesTuru, txtModelyılı, txtRenk, pictureBox1, sorgu2);
        }

        private void Kiralama_Load(object sender, EventArgs e)
        {
            BosAraclar();
            Yenile();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kiralama kiralama = new Kiralama();
            this.Hide();
            kiralama.ShowDialog();
        }

        private void btnrapor_Click(object sender, EventArgs e)
        {
            kiralamaraporlama kiralama = new kiralamaraporlama();
            this.Hide();
            kiralama.ShowDialog();
            this.Show();
        }
    }
}
