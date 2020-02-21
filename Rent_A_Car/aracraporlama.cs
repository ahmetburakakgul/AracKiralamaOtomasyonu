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
    public partial class aracraporlama : Form
    {
        public aracraporlama()
        {
            InitializeComponent();
        }

        private void aracraporlama_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'RentACarDataSet.ARAC' table. You can move, or remove it, as needed.
            this.ARACTableAdapter.Fill(this.RentACarDataSet.ARAC);

            this.reportViewer1.RefreshReport();
        }
    }
}
