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
    public partial class TransaccionObjetivoCursoForm : Form
    {
        private readonly ObjetivoService objetivoService;
        private readonly CursoService cursoService;

        private BindingList<Objetivo> objNoTieneList;
        private BindingList<Objetivo> objTieneList;


        public TransaccionObjetivoCursoForm()
        {
            InitializeComponent();
            objetivoService = new ObjetivoService();
            cursoService = new CursoService();
        }

        private void TransaccionObjetivoCursoForm_Load(object sender, EventArgs e)
        {
            InicarDataGridView();
            LlenarCombo(cmbCurso, cursoService.ObtenerCursos(), "NombreCurso", "IdCurso");
            cmbCurso.SelectedIndex = 0;
        }
        public void InicarDataGridView()
        {
            dgvObjetivosCurso.DataSource = objetivoService.ObtenerTodos();


        }


        private void bnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void bnRemover_Click(object sender, EventArgs e)
        {

        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            // Datasource: establece el origen de datos de este objeto.
            cbo.DataSource = source;
            // DisplayMember: establece la propiedad que se va a mostrar para este ListControl.
            cbo.DisplayMember = display;
            // ValueMember: establece la ruta de acceso de la propiedad que se utilizará como valor real para los elementos de ListControl.
            cbo.ValueMember = value;
            //SelectedIndex: establece el índice que especifica el elemento seleccionado actualmente.
            cbo.SelectedIndex = -1;
        }



        private Objetivo ObtenerObjetivoSeleccionado(DataGridView dgv)
        {
            DataGridViewSelectedRowCollection ElementoAAgregar = dgv.SelectedRows;
            DataGridViewRow row;


            IEnumerator Enumerator = ElementoAAgregar.GetEnumerator();

            Enumerator.Reset();

            while (Enumerator.MoveNext())
            {

                row = (DataGridViewRow) Enumerator.Current;

                Objetivo objt = (Objetivo) row.DataBoundItem;

                // Como solo se puede elegir un curso, devuelve el primero que encuentra
                return objt;
            }
            return null;

        }

        private void cmbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (obtenerCursoSeleccionado()  == null)
                return;

            Curso cur = obtenerCursoSeleccionado();

            objNoTieneList = new BindingList<Objetivo>( objetivoService.ObtenerTodosMenosEnCurso(cur) );
            objTieneList = new BindingList<Objetivo>( objetivoService.ObtenerTodosEnCurso(cur) );


            dgvObjetivosCurso.DataSource = objNoTieneList;
            dgvObjetivosParticular.DataSource = objTieneList;


        }

        private Curso obtenerCursoSeleccionado()
        {
            return (Curso)cmbCurso.SelectedItem;
        }

        private void bnAdd_Click(object sender, EventArgs e)
        {
            Objetivo objt = ObtenerObjetivoSeleccionado(dgvObjetivosCurso);
            if (objt == null)
                return;

            objTieneList.Add(objt);
            objNoTieneList.Remove(objt);
        }

        private void bnRemove_Click(object sender, EventArgs e)
        {
            Objetivo objt = ObtenerObjetivoSeleccionado(dgvObjetivosParticular);
            if (objt == null)
                return; 
            objTieneList.Remove(objt);
            objNoTieneList.Add(objt);

        }

        private void bnConfirmarTransaccion_Click(object sender, EventArgs e)
        {
            bool exitCod = cursoService.TransaccionObjetivosPorCurso(objTieneList, objNoTieneList, obtenerCursoSeleccionado());

            if (exitCod)
            {
                MessageBox.Show("Se modificaron los objetivos por curso con exito");
            } 
            else
            {
                MessageBox.Show("Error en la modificación de objetivos por curso");
            }
        }
    }
}
