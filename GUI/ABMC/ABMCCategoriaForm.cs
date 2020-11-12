using System;
using System.Collections;
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
    public partial class ABMCCategoriaForm : Form
    {
        private readonly CategoriaService catService;

        public ABMCCategoriaForm(Usuario user)
        {
            InitializeComponent();
            catService = new CategoriaService();

            InicarDataGridView();

            if (user.NombreUsuario.Equals("administrador"))

                checkEliminados.Enabled = true;

            else checkEliminados.Enabled = false;

        }

        public void InicarDataGridView()
        {

            dgv_Categorias.DataSource = catService.ObtenerTodos();
            txtCantidad.Text = dgv_Categorias.Rows.Count.ToString();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NuevaCategoriaForm nuevaCat = new NuevaCategoriaForm();
            nuevaCat.ShowDialog();
            InicarDataGridView();
        }

        private void txtBoxBuscar_TextChanged(object sender, EventArgs e)
        {

            if (checkEliminados.Checked)
            {
                dgv_Categorias.DataSource = catService.GetCategoriaBySearchEliminados(txtBoxBuscar.Text);
                CambiarColorEliminados();
            }
            else dgv_Categorias.DataSource = catService.GetCategoriaBySearch(txtBoxBuscar.Text);
            
        }

        private void checkEliminados_CheckedChanged(object sender, EventArgs e)
        {

            if (checkEliminados.Checked)
            {
                dgv_Categorias.DataSource = catService.GetAllYEliminados();
                txtCantidad.Text = dgv_Categorias.Rows.Count.ToString();
                CambiarColorEliminados();
            }
            else
            {
                dgv_Categorias.DataSource = catService.ObtenerTodos();
                txtCantidad.Text = dgv_Categorias.Rows.Count.ToString();
            }

        }

        private Categoria ObtenerCategoriaSeleccionada()
        {
            DataGridViewSelectedRowCollection elementosSeleccionados = dgv_Categorias.SelectedRows;
            DataGridViewRow row;


            IEnumerator Enumerator = elementosSeleccionados.GetEnumerator();

            Enumerator.Reset();

            List<Categoria> objetivosList = new List<Categoria>();

            while (Enumerator.MoveNext())

            {

                row = (DataGridViewRow)Enumerator.Current;

                Categoria objetivo = (Categoria)row.DataBoundItem;

             
                objetivosList.Add(objetivo);
                break;
            }

            return objetivosList[0];

        }

        private List<Categoria> ObtenerCategoriasSeleccionadas()
        {
            DataGridViewSelectedRowCollection elementosSeleccionados = dgv_Categorias.SelectedRows;
            DataGridViewRow row;


            IEnumerator Enumerator = elementosSeleccionados.GetEnumerator();

            Enumerator.Reset();

            List<Categoria> objetivosList = new List<Categoria>();

            while (Enumerator.MoveNext())

            {

                row = (DataGridViewRow)Enumerator.Current;

                Categoria objetivo = (Categoria)row.DataBoundItem;

                // Como solo se puede elegir un objetivo, devuelve el primero que encuentra
                objetivosList.Add(objetivo);
            }

            return objetivosList;

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult rpta;

            rpta = MessageBox.Show("Seguro que desea eliminar los objetivos seleccionados?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rpta == DialogResult.Yes)
            {

                List<Categoria> catList = ObtenerCategoriasSeleccionadas();

                catService.DeleteCatagorias(catList);

                InicarDataGridView();
            }

            checkEliminados.Checked = false;
        }

        private void CambiarColorEliminados()
        {

            foreach (DataGridViewRow row in dgv_Categorias.Rows)
            {
                if (catService.CheckCategoriaEliminado((Categoria)row.DataBoundItem)) row.DefaultCellStyle.BackColor = Color.LightGray;

            }

        }

        private void dgv_Objetivos_SelectionChanged(object sender, EventArgs e)
        {

            //Objetivo ob = ObtenerObjetivoSeleccionado();

            List<Categoria> listObj = ObtenerCategoriasSeleccionadas();
            if (listObj.Count == 0) return;

            foreach (Categoria obj in listObj)
            {
                bool obEliminado = catService.CheckCategoriaEliminado(obj);
                btnModificar.Enabled = !obEliminado;
                btnBorrar.Enabled = !obEliminado;

            }

            if (listObj.Count > 1) btnModificar.Enabled = false;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarCategoriaForms mcf = new ModificarCategoriaForms(ObtenerCategoriaSeleccionada());
            mcf.ShowDialog();
            InicarDataGridView();
        }
    }
}
