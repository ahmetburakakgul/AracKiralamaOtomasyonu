using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace Rent_A_Car
{
    class AraçKiralama
    {
        OleDbConnection con = new OleDbConnection
  ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RentACar.mdb");
        public DataTable listele(OleDbDataAdapter adtr, string sorgu)
        {
            DataTable tablo = new DataTable();
            adtr = new OleDbDataAdapter(sorgu, con);
            adtr.Fill(tablo);
            con.Close();
            return tablo;
        }

        public void ekle_guncelle(OleDbCommand komut, string sorgu)
        {
            con.Open();
            komut.Connection = con;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            con.Close();
        }

        public void BosAraclar(ComboBox combo, string sorgu)
        {
            con.Open();
            OleDbCommand komut = new OleDbCommand(sorgu, con);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                combo.Items.Add(oku["PLAKA"].ToString());
            }
            con.Close();
        }

        public void TC_ARA(TextBox tc, TextBox ad, TextBox soyad, TextBox gsm, TextBox adres, string sorgu)
        {
            con.Open();
            OleDbCommand komut = new OleDbCommand(sorgu, con);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ad.Text = oku["ADI"].ToString();
                soyad.Text = oku["SOYADI"].ToString();
                gsm.Text = oku["GSM_NO"].ToString();
                adres.Text = oku["ADRES"].ToString();
            }
            con.Close();
        }

        public void Ucret_Hesapla(ComboBox combokirasekli, TextBox ucret, string sorgu)
        {
            con.Open();
            OleDbCommand komut = new OleDbCommand(sorgu, con);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (combokirasekli.SelectedIndex == 0) ucret.Text = (int.Parse(oku["ARAC_UCRETI"].ToString()) * 1).ToString();
                if (combokirasekli.SelectedIndex == 1) ucret.Text = (int.Parse(oku["ARAC_UCRETI"].ToString()) * 0.80).ToString();
                if (combokirasekli.SelectedIndex == 2) ucret.Text = (int.Parse(oku["ARAC_UCRETI"].ToString()) * 0.70).ToString();


            }
            con.Close();
        }

        public void CombodanGetir(ComboBox araclar, TextBox marka, TextBox model, TextBox yakit, TextBox vites, TextBox modelyili, TextBox renk, PictureBox resim, string sorgu)
        {
            con.Open();
            OleDbCommand komut = new OleDbCommand(sorgu, con);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                marka.Text = oku["MARKA"].ToString();
                model.Text = oku["MODEL"].ToString();
                yakit.Text = oku["YAKIT_TURU"].ToString();
                vites.Text = oku["VITES_TURU"].ToString();
                modelyili.Text = oku["MODEL_YILI"].ToString();
                renk.Text = oku["RENK"].ToString();
                resim.ImageLocation = oku["RESIM"].ToString();
            }
            con.Close();
        }


    }
}

