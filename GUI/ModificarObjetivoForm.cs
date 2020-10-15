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
    public partial class ModificarObjetivoForm : Form
    {

        private Objetivo objAmod;
        private ObjetivoService objService;
        private bool modificado;
        public ModificarObjetivoForm(Objetivo obj)
        {
            InitializeComponent();
            objAmod = obj;
            objService = new ObjetivoService();
        }

        private void btnModificarObj_Click(object sender, EventArgs e)
        {
            objAmod.NombreCorto = txtBoxNombre.Text;
            objAmod.NombreLargo = txtBoxDescripcion.Text;

            objService.ModificarObjetivo(objAmod);

            MessageBox.Show("Objetivo modificado exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.None);
            modificado = true;
            this.Close();
        }

        private void ModificarObjetivoForm_Load(object sender, EventArgs e)
        {
            txtBoxNombre.Text = objAmod.NombreCorto;
            txtBoxDescripcion.Text = objAmod.NombreLargo;
        }

        private void ModificarObjetivoForm_FormClosing(object sender, FormClosingEventArgs e)
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
