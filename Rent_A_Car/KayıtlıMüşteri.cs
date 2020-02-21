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
    public partial class KayıtlıMüşteri : Form
    {
        public KayıtlıMüşteri()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection
      ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RentACar.mdb");
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void KayıtlıMüşteri_Load(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("select * From MUSTERI ", con);
            da.Fill(ds, "MUSTERI");
            dataGridView1.DataSource = ds.Tables["MUSTERI"];
            da.Dispose();
            con.Close();

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
