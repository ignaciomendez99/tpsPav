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

namespace TPS_PAV
{
    public partial class LoginForm : Form
    {
        private readonly UsuarioService usuarioService;


        public LoginForm()
        {
            InitializeComponent();
            usuarioService = new UsuarioService();

        }

        private void bnIngresar_Click(object sender, EventArgs e)
        {
            if ((txUsuario.Text == ""))
            {
                MessageBox.Show("Se debe ingresar un usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if ((txClave.Text == ""))
            {
                MessageBox.Show("Se debe ingresar una contraseña.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var usr = usuarioService.ValidarUsuario(txUsuario.Text, txClave.Text);
            if (usr != null)
            {
                MainForm main = new MainForm(usr);
              
                this.Hide();
                main.ShowDialog();
                this.Close();
            }
            else
            {
                txClave.Text = "";
                txClave.Focus();
                MessageBox.Show("Debe ingresar usuario y/o contraseña válidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
