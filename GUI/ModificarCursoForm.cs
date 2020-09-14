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
using TPS_PAV.Entities;

namespace TPS_PAV.GUI
{
    public partial class ModificarCursoForm : Form
    {
        private Curso cursoModificar;
        private CursoService curService;
        private CategoriaService catService;
        private bool modificado = false;

        public ModificarCursoForm(Curso curAMod)
        {
            InitializeComponent();
            cursoModificar = curAMod;
            catService = new CategoriaService();
            curService = new CursoService();

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


        private void ModificarCursoForm_Load(object sender, EventArgs e)
        {
            IList<Categoria> categorias = catService.ObtenerTodos();
            LlenarCombo(cbCategoriaCursos, categorias, "Nombre", "IdCategoria");
            txId.Text = cursoModificar.IdCurso.ToString();
            txDescripcion.Text = cursoModificar.Descripcion;

            DateTime dt = cursoModificar.FechaVigencia;
            string fecha = String.Format("{0:dd/MM/yyyy}", dt);

            txFechaVigencia.Text = fecha;
            txNombre.Text = cursoModificar.NombreCurso;

            cbCategoriaCursos.SelectedIndex = cbCategoriaCursos.FindStringExact(cursoModificar.Categoria.Nombre);
        }

        private void btModificarCurso_Click(object sender, EventArgs e)
        {

            cursoModificar.NombreCurso = txNombre.Text;
            cursoModificar.Descripcion = txDescripcion.Text;
            cursoModificar.FechaVigencia =DateTime.Parse( txFechaVigencia.Text);
            cursoModificar.Categoria = catService.ObtenerCategoriaById(Int32.Parse(cbCategoriaCursos.SelectedValue.ToString()));

            curService.ModificarCurso(cursoModificar);
            MessageBox.Show("Curso modificado exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.None);
            this.modificado = true;
            this.Close();
        }

        private void ModificarCursoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            DialogResult rpta;

            if (!this.modificado)
            {
                rpta = MessageBox.Show("Seguro que desea salir? \nSe perderán todos los cambios.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rpta == DialogResult.No)
                    e.Cancel = true;
            }
           
        }
    }
}
