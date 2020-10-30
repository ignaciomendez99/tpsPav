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


namespace TPS_PAV.GUI
{

    public partial class NuevoObjetivoForm : Form
    {

        private readonly ObjetivoService objetivoService;
        private bool creado = false;

        public NuevoObjetivoForm()
        {
            objetivoService = new ObjetivoService();
            InitializeComponent();
        }

        private void btnNuevoObjetivo_Click(object sender, EventArgs e)
        {

            string nombre = txtBoxNombre.Text;
            string descripcion = txtBoxDescripcion.Text;


            

            bool creado = objetivoService.NuevoObjetivo(nombre, descripcion);
            if (creado)
            {
                this.creado = true;
                MessageBox.Show("¡El objetivo ha sido agregado con éxito!", "Aviso", MessageBoxButtons.OK);

            }

            else
                MessageBox.Show("No se ha agregado el objetivo", "Aviso", MessageBoxButtons.OK);

            this.Close();

        }

        private void NuevoObjetivoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rpta;

            if (!this.creado)
            {
                rpta = MessageBox.Show("Seguro que desea salir? \nSe perderán todos los cambios.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rpta == DialogResult.No)
                    e.Cancel = true;
            }

        }
    }
}
