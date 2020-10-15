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
    public partial class ABMCObjetivosForm : Form
    {

        private readonly ObjetivoService objetivoService;


        public ABMCObjetivosForm(Usuario user)
        {
            objetivoService = new ObjetivoService();
            InitializeComponent();
            InicarDataGridView();

            if (user.NombreUsuario.Equals("administrador"))

                checkEliminados.Enabled = true;

            else checkEliminados.Enabled = false;

        }

        public void InicarDataGridView()
        {

            dgv_Objetivos.DataSource = objetivoService.ObtenerTodos();
            txtCantidad.Text = dgv_Objetivos.Rows.Count.ToString();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NuevoObjetivoForm nof = new NuevoObjetivoForm();
            nof.ShowDialog();
            InicarDataGridView();
        }

        private void txtBoxBuscar_TextChanged(object sender, EventArgs e)
        {

            if (checkEliminados.Checked)
            {
                dgv_Objetivos.DataSource = objetivoService.GetObjetivoBySearchEliminados(txtBoxBuscar.Text);
                CambiarColorEliminados(); 
            }
            else dgv_Objetivos.DataSource = objetivoService.GetObjetivoBySearch(txtBoxBuscar.Text);
        }

        private void checkEliminados_CheckedChanged(object sender, EventArgs e)
        {

            if (checkEliminados.Checked)
            {
                dgv_Objetivos.DataSource = objetivoService.GetAllYEliminados();
                txtCantidad.Text = dgv_Objetivos.Rows.Count.ToString();
                CambiarColorEliminados();
            }
            else
            {
                dgv_Objetivos.DataSource = objetivoService.ObtenerTodos();
                txtCantidad.Text = dgv_Objetivos.Rows.Count.ToString();
            }

        }

        private Objetivo ObtenerObjetivoSeleccionado()
        {
            DataGridViewSelectedRowCollection elementosAborrar =dgv_Objetivos.SelectedRows;
            DataGridViewRow row;


            IEnumerator Enumerator = elementosAborrar.GetEnumerator();

            Enumerator.Reset();

            while (Enumerator.MoveNext())

            {

                row = (DataGridViewRow)Enumerator.Current;

                Objetivo objetivo = (Objetivo)row.DataBoundItem;

                // Como solo se puede elegir un objetivo, devuelve el primero que encuentra
                return objetivo;
            }
            return null;

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult rpta;

            rpta = MessageBox.Show("Seguro que desea eliminar el curso seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rpta == DialogResult.Yes)
            {
                Objetivo objetivoABorrar = ObtenerObjetivoSeleccionado();

                objetivoService.DeleteObjetivo(objetivoABorrar);

                InicarDataGridView();
            }
        }

        private void CambiarColorEliminados()
        {

            foreach (DataGridViewRow row in dgv_Objetivos.Rows)
            {
                if (objetivoService.CheckObjetivoEliminado((Objetivo)row.DataBoundItem)) row.DefaultCellStyle.BackColor = Color.LightGray;

            }

        }

        private void dgv_Objetivos_SelectionChanged(object sender, EventArgs e)
        {

            Objetivo ob = ObtenerObjetivoSeleccionado();

            if (ob == null) return;
        
            bool obEliminado = objetivoService.CheckObjetivoEliminado(ob);
            btnModificar.Enabled = !obEliminado;
            btnBorrar.Enabled = !obEliminado;
        
        }
    }
}
