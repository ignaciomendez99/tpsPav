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
                MessageBox.Show("¡El objetivo ha sido agregado con éxito!", "Aviso", MessageBoxButtons.OK);
            else
                MessageBox.Show("No se ha agregado el objetivo", "Aviso", MessageBoxButtons.OK);

            this.Close();

        }
    }
}
