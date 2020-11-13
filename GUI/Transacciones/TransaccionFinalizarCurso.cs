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
using TPS_PAV.DataAccessLayer;
using TPS_PAV.Entities;

namespace TPS_PAV.GUI.Transacciones
{
    public partial class TransaccionFinalizarCurso : Form
    {

        private CursoService oCursoService;
        private ObjetivoService oObjetivoService;
        private UsuarioService oUsuarioService;


        public TransaccionFinalizarCurso()
        {
            InitializeComponent();
            oCursoService = new CursoService();
            oObjetivoService = new ObjetivoService();
            oUsuarioService = new UsuarioService();

            

        }

        private void LlenarCombo(ComboBox cbo, Object source, string display)
        {
            // Datasource: establece el origen de datos de este objeto.
            cbo.DataSource = source;
            // DisplayMember: establece la propiedad que se va a mostrar para este ListControl.
            cbo.DisplayMember = display;
            // ValueMember: establece la ruta de acceso de la propiedad que se utilizará como valor real para los elementos de ListControl.
            cbo.SelectedIndex = 0;
        }

        private void cbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {

            Curso curso = (Curso) cbCurso.SelectedItem;


            IList<Usuario> usuarios = ObtenerUsuariosCurso();
            dgv_Usuarios.DataSource = usuarios;

            if (curso.FechaVigencia.ToString() == "1/1/0001 00:00:00")
            {
                button1.Enabled = false;
                label2.Visible = true;

            } else
            {
                label2.Visible = false;
                button1.Enabled = true;
            }



        }

        private void dgv_Usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
            //IList<Objetivo> objetivosUsuario = oObjetivoService.ObtenerTodosEnCurso((Curso)cbCurso.SelectedItem);
            
        }

        private Usuario ObtenerUsuarioSeleccionado()
        {
            DataGridViewSelectedRowCollection seleccionados = dgv_Usuarios.SelectedRows;
            DataGridViewRow row;

            IEnumerator Enumerator = seleccionados.GetEnumerator();

            Enumerator.Reset();

            while (Enumerator.MoveNext())

            {

                row = (DataGridViewRow)Enumerator.Current;

                Usuario usuario = (Usuario)row.DataBoundItem;

                // Como solo se puede elegir un usuario, devuelve el primero que encuentra
                return usuario;
            }
            return null;

        }

        //TODO
        private IList<Objetivo> ObtenerObjetivosDelCurso(Curso curso)
        {
            return oObjetivoService.ObtenerTodosEnCurso(curso);
        }
        //TODO
        private IList<Usuario> ObtenerUsuariosCurso()
        {
            if ((Curso)cbCurso.SelectedItem != null)
                return oUsuarioService.ObtenerUsuariosCurso((Curso)cbCurso.SelectedItem);
            else
                return new List<Usuario>();
        }


        //Dao

        private int ObtenerPuntosObjetivos(IList<Objetivo> objetivos)
        {
           
            return 10;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            IList<Usuario> usuarios = ObtenerUsuariosCurso();

            IList<Objetivo> objetivos = ObtenerObjetivosDelCurso((Curso)cbCurso.SelectedItem);
            int puntos = ObtenerPuntosObjetivos(objetivos);

            bool succes = oCursoService.FinalizarCurso((Curso)cbCurso.SelectedItem, usuarios);
            if (succes)
                MessageBox.Show("El curso ha sido terminado por completo");
            else
                MessageBox.Show("Ha habido un error finalizando el curso!");

            cbCurso.SelectedIndex = 0;

            LlenarCombo(cbCurso, oCursoService.ObtenerCursos(), "NombreCurso");

        }



        private void TransaccionActualizarAvance_Load(object sender, EventArgs e)
        {
            LlenarCombo(cbCurso, oCursoService.ObtenerCursos(), "NombreCurso");
        }
    }
}
