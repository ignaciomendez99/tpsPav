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
    public partial class ModificarUsuarioForm : Form
    {
        private Usuario usuarioAModificar;
        private UsuarioService usuarioService;
        private PerfilService perflService;
        private bool modificado = false;
        private bool unUsr = false;

        public ModificarUsuarioForm(Usuario usr)
        {
            InitializeComponent();
            if (usr != null)
            {
                usuarioAModificar = usr;
                unUsr = true;
            }

            usuarioService = new UsuarioService();
            perflService = new PerfilService();

        }

        private void ModificarUsuarioForm_Load(object sender, EventArgs e)
        {
            if (unUsr)
            {

                IList<Perfil> perfiles = perflService.ObtenerTodos();
                LlenarCombo(cmbPerfil, perfiles, "Nombre", "");

                txUsuario.Text = usuarioAModificar.NombreUsuario;
                txClave.Text = usuarioAModificar.Password;
                txMail.Text = usuarioAModificar.Email;

                cmbPerfil.SelectedIndex = cmbPerfil.FindStringExact(usuarioAModificar.Perfil.Nombre);
            }


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

        private void bnAceptar_Click(object sender, EventArgs e)
        {
            usuarioAModificar.NombreUsuario = txUsuario.Text;
            usuarioAModificar.Password = txClave.Text;
            usuarioAModificar.Perfil = (Perfil)cmbPerfil.SelectedItem;
            usuarioAModificar.Email = txMail.Text;
            usuarioService.modificarUsuario(usuarioAModificar);

            MessageBox.Show("Usuario modificado exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.None);
            modificado = true;
            this.Close();

        }

        private void bnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModificarUsuarioForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rpta;

            rpta = MessageBox.Show("Seguro que desea salir? \nSe perderán todos los cambios.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rpta == DialogResult.No)
                e.Cancel = true;
            

        }
    }
}
