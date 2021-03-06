﻿using System;
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
using TPS_PAV.GUI.Reports;
using TPS_PAV.GUI.Transacciones;

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
            
            if (mainUser.Perfil.IdPerfil != 1)
                usuariosToolStripMenuItem.Enabled = false;
        }

        private void nuevoCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMCursosForm abmcCurso = new ABMCursosForm(mainUser);
            abmcCurso.ShowDialog();

        }

        private void actualizarObjetivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransaccionObjetivoCursoForm t = new TransaccionObjetivoCursoForm();
            t.ShowDialog();
            //Test
        }

        private void objetivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMCObjetivosForm abmcObjetivos = new ABMCObjetivosForm(mainUser);
            abmcObjetivos.ShowDialog();

        }

        private void ayudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Grupo Nro: 3 - PAVI 2020\nSala, Lorenzo - Mendez, Ignacio - Zago, Agustín - Otero, Gastón", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void avancePorCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReporte rf = new FormReporte();
            rf.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMCUsuariosForm uf = new ABMCUsuariosForm(mainUser);
            uf.ShowDialog();

        }

        private void objetivosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ABMCObjetivosForm ob = new ABMCObjetivosForm(mainUser);
            ob.ShowDialog();

        }

        private void actualizarAvanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransaccionFinalizarCurso tob = new TransaccionFinalizarCurso();
            tob.ShowDialog();
        }

        private void perfilesPorUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReporte2 rp = new FormReporte2();
            rp.ShowDialog();
        }
    }
}
