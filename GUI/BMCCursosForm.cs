using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPS_PAV.BusinessLayer;
using TPS_PAV.Entities;

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
            dgvCursos.MultiSelect = false;
        }

        private void iniciarDataGridView()
        {
            dgvCursos.DataSource = servicioCursos.ObtenerCursos();
        }


        private void bnBuscarCurso_Click(object sender, EventArgs e)
        {
            dgvCursos.DataSource = servicioCursos.ObtenerCursoBuscado(txBuscar.Text);
        }

        private void dgvCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bnBorrarCurso.Enabled = true;
            btModificarCurso.Enabled = true;
        }

        private void bnBorrarCurso_Click(object sender, EventArgs e)
        {

            Curso cursoABorrar = ObtenerCursoSeleccionado();

            servicioCursos.BorrarCurso(cursoABorrar);

            iniciarDataGridView();

        }

        private Curso ObtenerCursoSeleccionado()
        {
            DataGridViewSelectedRowCollection elementosAborrar = dgvCursos.SelectedRows;
            DataGridViewRow row;

            IEnumerator Enumerator = elementosAborrar.GetEnumerator();

            Enumerator.Reset();

            while (Enumerator.MoveNext())

            {

                row = (DataGridViewRow)Enumerator.Current;

                Curso curso = (Curso)row.DataBoundItem;

                // Como solo se puede elegir un curso, devuelve el primero que encuentra
                return curso;
            }
            return null;

        }

        private void btModificarCurso_Click(object sender, EventArgs e)
        {
            ModificarCursoForm modif = new ModificarCursoForm(ObtenerCursoSeleccionado());
            modif.ShowDialog();
            iniciarDataGridView();
        }
    }
}
