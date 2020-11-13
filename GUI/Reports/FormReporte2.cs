using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPS_PAV.GUI.Reports
{
    public partial class FormReporte2 : Form
    {
        public FormReporte2()
        {
            InitializeComponent();
        }

        private void FormReporte2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetReportes.DataTable3' table. You can move, or remove it, as needed.
            this.DataTable3TableAdapter.Fill(this.DataSetReportes.DataTable3);

            this.reportViewer1.RefreshReport();
        }
    }
}
