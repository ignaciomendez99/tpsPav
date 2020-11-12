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

namespace TPS_PAV.GUI.Transacciones
{
    public partial class TransaccionActualizarAvance : Form
    {

        private CursoService oCursoService;
        private ObjetivoService oObjetivoService;


        public TransaccionActualizarAvance()
        {
            InitializeComponent();
            oCursoService = new CursoService();
            oObjetivoService = new ObjetivoService();

            LlenarCombo(cbCurso, oCursoService.ObtenerCursos(), "Nombre Curso");

        }

        private void LlenarCombo(ComboBox cbo, Object source, string display)
        {
            // Datasource: establece el origen de datos de este objeto.
            cbo.DataSource = source;
            // DisplayMember: establece la propiedad que se va a mostrar para este ListControl.
            cbo.DisplayMember = display;
            // ValueMember: establece la ruta de acceso de la propiedad que se utilizará como valor real para los elementos de ListControl.
            cbo.SelectedIndex = -1;
        }

        private void cbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {

            Curso curso = (Curso) cbCurso.SelectedItem;
            IList<Objetivo> usuarios = oUsuarioService.ObtenerUsuariosCurso();
            dgv_Usuarios.DataSource = usuarios;
            
            
        }

        private void dgv_Usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Usuario user = ObtenerUsuarioSeleccionado();
            dgv_Objetivos.DataSource = oObjetivoService.ObtenerTodos();
            IList<Objetivo> objetivosUsuario = oObjetivoService.ObtenerTodosEnCurso((Curso)cbCurso.SelectedItem);
            
            if(user != null)
            {
                foreach (DataGridViewRow row in dgv_Objetivos.Rows)
                {
                    foreach (Objetivo objetivo in objetivosUsuario)
                    {
                        if (row.Cells[0].Value.ToString() == objetivo.NombreCorto)
                            row.DefaultCellStyle.BackColor = Color.LightGreen;
                        else row.DefaultCellStyle.BackColor = Color.Red;
                    }

                }

            }
   
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
