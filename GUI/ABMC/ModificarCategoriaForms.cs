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
    public partial class ModificarCategoriaForms : Form
    {

        bool modificado = false;
        Categoria cat;
        private readonly CategoriaService categoriaService;

        public ModificarCategoriaForms(Categoria cat)
        {
            InitializeComponent();
            this.cat = cat;
            categoriaService = new CategoriaService();
            txtDescripcion.Text = cat.Descripcion;
            txtNombre.Text = cat.Nombre;
            
        }  

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            cat.Descripcion = txtDescripcion.Text;
            cat.Nombre  = txtNombre.Text;

            categoriaService.ModificarCategoria(cat);
            modificado = true;
            MessageBox.Show("Curso modificado exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.None);
            this.Close();
        }

        private void ModificarCategoriaForms_FormClosing(object sender, FormClosingEventArgs e)
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
