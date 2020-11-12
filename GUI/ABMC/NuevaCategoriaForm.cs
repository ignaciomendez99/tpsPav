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
    public partial class NuevaCategoriaForm : Form
    {
        private CategoriaService categoriaService;

        private bool creado = false;

        public NuevaCategoriaForm()
        {
            InitializeComponent();
            categoriaService = new CategoriaService();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Categoria cat = ObtenerCategoria();
            categoriaService.AgregarCategoria(cat);
            creado = true;
            MessageBox.Show("Se creó la categoría con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.None);

        }

        private Categoria ObtenerCategoria()
        {
            string descripcion = txtDescripcion.Text;
            string nombre = txtNombre.Text;
            int idCat = categoriaService.GetLastID();

            return new Categoria{ Nombre = nombre, Descripcion = descripcion, IdCategoria = idCat };
        }

        private void NuevaCategoriaForm_FormClosing(object sender, FormClosingEventArgs e)
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
