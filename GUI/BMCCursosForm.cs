using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPS_PAV.BusinessLayer;

namespace TPS_PAV.GUI
{
    public partial class BMCCursosForm : Form
    {
        private readonly CursoService servicioCursos;
        public BMCCursosForm()
        {
            InitializeComponent();
            servicioCursos = new CursoService();
        }

        private void BMCCursosForm_Load(object sender, EventArgs e)
        {
            iniciarDataGridView();
        }

        private void iniciarDataGridView()
        {
            dgvCursos.DataSource = servicioCursos.ObtenerCursos();
        }


        private void bnBuscarCurso_Click(object sender, EventArgs e)
        {
            dgvCursos.DataSource = servicioCursos.ObtenerCursoBuscado(txBuscar.Text);
        }
    }
}
