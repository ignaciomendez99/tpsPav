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
    public partial class TransaccionObjetivoCursoForm : Form
    {
        private readonly ObjetivoService objetivoService;
        private readonly CursoService cursoService;

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

    }
}
