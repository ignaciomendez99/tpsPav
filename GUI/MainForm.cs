using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPS_PAV.Entities;
using TPS_PAV.GUI;

namespace TPS_PAV
{
    public partial class MainForm : Form
    {
        private Usuario mainUser;
        public MainForm(Usuario user)
        {
            InitializeComponent();
            mainUser = user;
        }



        private void MainForm_FormClosed(object sender, FormClosingEventArgs e)
        {
            DialogResult rpta;
            rpta = MessageBox.Show("Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rpta == DialogResult.No)
                e.Cancel = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lbUsuario.Text = mainUser.NombreUsuario;
        }

 

        private void nuevoCursoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ABMCCursosForm ambcCursos = new ABMCCursosForm();
            ambcCursos.ShowDialog();
        }

        private void nuevoCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BMCCursosForm bmccCursos = new BMCCursosForm();
            bmccCursos.ShowDialog();

        }
    }
}
