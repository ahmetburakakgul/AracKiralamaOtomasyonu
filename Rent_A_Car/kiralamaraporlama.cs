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
    public partial class kiralamaraporlama : Form
    {
        public kiralamaraporlama()
        {
            InitializeComponent();
        }

        private void kiralamaraporlama_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'RentACarDataSet.ARAC_KIRALAMA' table. You can move, or remove it, as needed.
            this.ARAC_KIRALAMATableAdapter.Fill(this.RentACarDataSet.ARAC_KIRALAMA);

            this.reportViewer1.RefreshReport();
        }
    }
}
