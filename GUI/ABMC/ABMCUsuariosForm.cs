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
    public partial class ABMCUsuariosForm : Form
    {

        private readonly UsuarioService usuarioService;

        public ABMCUsuariosForm(Usuario user)
        {
            InitializeComponent();
            usuarioService = new UsuarioService();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
        }

        private void ABMCUsuariosForm_Load(object sender, EventArgs e)
        {
            iniciarDataGridView();
            // dgvCursos.MultiSelect = false;
            btModificarCurso.Enabled = false;

        }

        private void iniciarDataGridView()
        {
            dgvUsuarios.DataSource = usuarioService.ObtenerTodos();
        }


        private void bnBorrarCurso_Click(object sender, EventArgs e)
        {

        }

        private void btModificarCurso_Click(object sender, EventArgs e)
        {

        }

        private void bnBorrarCurso_Click_1(object sender, EventArgs e)
        {

            DialogResult rpta;

            rpta = MessageBox.Show("Seguro que desea eliminar el usuario seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rpta == DialogResult.Yes)
            {
                List<Usuario> usuarioList = ObtenerUsuariosSeleccionados();

                usuarioService.DeleteUsuarios(usuarioList);

                iniciarDataGridView();
            }

            checkMostrarEliminados.Checked = false;
            iniciarDataGridView();
        }


        private List<Usuario> ObtenerUsuariosSeleccionados()
        {
            DataGridViewSelectedRowCollection elementosSeleccionados = dgvUsuarios.SelectedRows;
            DataGridViewRow row;


            IEnumerator Enumerator = elementosSeleccionados.GetEnumerator();

            Enumerator.Reset();

            List<Usuario> usuarioList = new List<Usuario>();

            while (Enumerator.MoveNext())

            {

                row = (DataGridViewRow)Enumerator.Current;

                Usuario usuario = (Usuario)row.DataBoundItem;

                // Como solo se puede elegir un objetivo, devuelve el primero que encuentra
                usuarioList.Add(usuario);
            }

            return usuarioList;

        }


        private void btModificarUsuario_Click_1(object sender, EventArgs e)
        {
            ModificarUsuarioForm muf = new ModificarUsuarioForm(ObtenerUsuariosSeleccionados()[0]);
            muf.ShowDialog();
            iniciarDataGridView();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            NuevoUsuarioForm nuf = new NuevoUsuarioForm();
            nuf.ShowDialog();
            iniciarDataGridView();
        }

        private void checkMostrarEliminados_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMostrarEliminados.Checked)
            {
                dgvUsuarios.DataSource = usuarioService.ObtenerUsuariosyEliminados();
                CambiarColorEliminados();
            }
            else
                dgvUsuarios.DataSource = usuarioService.ObtenerTodos();

            txBuscar.Text = "";

        }

        private void CambiarColorEliminados()
        {

            foreach (DataGridViewRow row in dgvUsuarios.Rows)
            {
                if (usuarioService.checkUsuarioEliminado((Usuario)row.DataBoundItem)) row.DefaultCellStyle.BackColor = Color.LightGray;

            }

        }

        private void dgvUsuarios_DataSourceChanged(object sender, EventArgs e)
        {
            labelCantidad.Text = dgvUsuarios.Rows.Count.ToString();
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            List<Usuario> listUsuarios = ObtenerUsuariosSeleccionados();

            if (listUsuarios.Count == 0) return;

            foreach (Usuario usr in listUsuarios)
            {
                bool usrEliminado = usuarioService.checkUsuarioEliminado(usr);

                btModificarCurso.Enabled = !usrEliminado;
                bnBorrarCurso.Enabled = !usrEliminado;
            }

            if (listUsuarios.Count > 1) btModificarCurso.Enabled = false;

        }

        private void txBuscar_TextChanged(object sender, EventArgs e)
        {
            if (checkMostrarEliminados.Checked)
            {
                dgvUsuarios.DataSource = usuarioService.ObtenerUsuarioBuscadoEliminados(txBuscar.Text);
                CambiarColorEliminados();

            }

            else dgvUsuarios.DataSource = usuarioService.ObtenerUsuarioBuscado(txBuscar.Text);

        }
    }
}
