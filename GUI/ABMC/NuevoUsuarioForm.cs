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
    public partial class NuevoUsuarioForm : Form
    {
        private readonly PerfilService perfilService;
        private readonly UsuarioService usuarioService;

        public NuevoUsuarioForm()
        {
            InitializeComponent();
            perfilService = new PerfilService();
            usuarioService = new UsuarioService();

        }

        private void bnAceptar_Click(object sender, EventArgs e)
        {
            Usuario usuario = obtenerUsuario();



            usuarioService.AgregarUsuario(usuario);
            MessageBox.Show("Se creó el Usuario con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.None);

        }

        private Usuario obtenerUsuario()
        {
            Usuario usuario = new Usuario
            {

                // Puede retonar null!!

                NombreUsuario = txUsuario.Text,
                Email = txMail.Text,
                Password = txClave.Text,
                Perfil = ((Perfil) cmbPerfil.SelectedValue)

            };
            return usuario;
        }

        private void bnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NuevoUsuarioForm_Load(object sender, EventArgs e)
        {
            IList<Perfil> perfiles = perfilService.ObtenerTodos();
            LlenarCombo(cmbPerfil, perfiles, "Nombre", "IdPerfil");

        }


        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            // Datasource: establece el origen de datos de este objeto.
            cbo.DataSource = source;
            // DisplayMember: establece la propiedad que se va a mostrar para este ListControl.
            cbo.DisplayMember = display;
            // ValueMember: establece la ruta de acceso de la propiedad que se utilizará como valor real para los elementos de ListControl.
            //cbo.ValueMember = value;
            //SelectedIndex: establece el índice que especifica el elemento seleccionado actualmente.
            cbo.SelectedIndex = -1;
        }

        private void NuevoUsuarioForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rpta;

            rpta = MessageBox.Show("Seguro que desea salir? \nSe perderán todos los cambios.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rpta == DialogResult.No)
                e.Cancel = true;


        }
    }
}
