using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent_A_Car
{
    public partial class Anasayfa : Form
    {
        public static string kullanici { get; set; }
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            if (kullanici != "")
            {
                lblKullanıcı.Text = "Kullanıcı : " + kullanici;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AraçListesi liste = new AraçListesi();
            this.Hide();
            liste.ShowDialog();
            this.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            PersonelListesi listepersonel = new PersonelListesi();
            this.Hide();
            listepersonel.ShowDialog();
            this.Show();
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            MüşteriListesi musteri = new MüşteriListesi();
            this.Hide();
            musteri.ShowDialog();
            this.Show();
        }

        private void btnKiralama_Click(object sender, EventArgs e)
        {
            Kiralama kiralama = new Kiralama();
            this.Hide();
            kiralama.ShowDialog();
            this.Show();
        }

        private void btnUyeİslem_Click(object sender, EventArgs e)
        {
            Kontrol uyeislem = new Kontrol();
            this.Hide();
            uyeislem.ShowDialog();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult cevapcıkıs = MessageBox.Show("Çıkış Yapılsın mı ?", "Çıkış", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == cevapcıkıs)
            {
                Form1 cıkıs = new Form1();
                this.Hide();
                cıkıs.ShowDialog();
            }
        }
    }
}
