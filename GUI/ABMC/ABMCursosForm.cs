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
    public partial class ABMCursosForm : Form
    {


        private readonly UsuarioService usuarioService;
        private readonly CursoService servicioCursos;

        public ABMCursosForm(Usuario user)
        {
            InitializeComponent();
            usuarioService = new UsuarioService();
            servicioCursos = new CursoService();

            

            if (user.NombreUsuario.Equals("administrador"))

                checkMostrarEliminados.Enabled = true;

            else checkMostrarEliminados.Enabled = false;

        }

        private void BMCCursosForm_Load(object sender, EventArgs e)
        {
            iniciarDataGridView();
            // dgvCursos.MultiSelect = false;
            btModificarCurso.Enabled = false;
        }

        private void iniciarDataGridView()
        {
            dgvCursos.DataSource = servicioCursos.ObtenerCursos();
        }

        private void bnBorrarCurso_Click(object sender, EventArgs e)
        {

            DialogResult rpta;

            rpta = MessageBox.Show("Seguro que desea eliminar el curso seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (rpta == DialogResult.Yes)
            {
                List<Curso> cursosList = ObtenerCursosSeleccionados();

                servicioCursos.DeleteCursos(cursosList);

                iniciarDataGridView();
            }

            checkMostrarEliminados.Checked = false;

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

        private List<Curso> ObtenerCursosSeleccionados()
        {
            DataGridViewSelectedRowCollection elementosSeleccionados = dgvCursos.SelectedRows;
            DataGridViewRow row;


            IEnumerator Enumerator = elementosSeleccionados.GetEnumerator();

            Enumerator.Reset();

            List<Curso> cursosList = new List<Curso>();

            while (Enumerator.MoveNext())

            {

                row = (DataGridViewRow)Enumerator.Current;

                Curso curso = (Curso)row.DataBoundItem;

                // Como solo se puede elegir un objetivo, devuelve el primero que encuentra
                cursosList.Add(curso);
            }

            return cursosList;

        }

        private void btModificarCurso_Click(object sender, EventArgs e)
        {

            ModificarCursoForm modif = new ModificarCursoForm(ObtenerCursosSeleccionados());
            
            modif.ShowDialog();
            iniciarDataGridView();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NuevoCursoForm nuevo = new NuevoCursoForm();
            nuevo.ShowDialog();
            iniciarDataGridView();
        }

        private void checkMostrarEliminados_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMostrarEliminados.Checked)
            {
                dgvCursos.DataSource = servicioCursos.ObtenerCursosYEliminados();
                CambiarColorEliminados();
            }
            else
                dgvCursos.DataSource = servicioCursos.ObtenerCursos();

            txBuscar.Text = "";
        }

        private void CambiarColorEliminados()
        {

            foreach(DataGridViewRow row in dgvCursos.Rows)
            {
                if (servicioCursos.CheckCursoEliminado((Curso)row.DataBoundItem)) row.DefaultCellStyle.BackColor = Color.LightGray;

            }

        }


        private void dgvCursos_DataSourceChanged(object sender, EventArgs e)
        {
            labelCantidad.Text = dgvCursos.Rows.Count.ToString();
        }

        private void dgvCursos_SelectionChanged(object sender, EventArgs e)
        {

            List<Curso> listCur = ObtenerCursosSeleccionados();

            if (listCur.Count == 0) return;

          foreach(Curso cur in listCur)
            {
                bool cursoEliminado = servicioCursos.CheckCursoEliminado(cur);

                btModificarCurso.Enabled = !cursoEliminado;
                bnBorrarCurso.Enabled = !cursoEliminado;
            }

            if (listCur.Count > 1) btModificarCurso.Enabled = false;
            
        }

        private void txBuscar_TextChanged(object sender, EventArgs e)
        {
            if(checkMostrarEliminados.Checked)
            {
                dgvCursos.DataSource = servicioCursos.ObtenerCursoBuscadoEliminados(txBuscar.Text);
                CambiarColorEliminados();

            }
                
            else dgvCursos.DataSource = servicioCursos.ObtenerCursoBuscado(txBuscar.Text);
        }
    }
}
