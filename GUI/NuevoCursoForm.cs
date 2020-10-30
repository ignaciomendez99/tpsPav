﻿using System;
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
    // HAY QUE IMPLEMENTAR EL SERVICE DE CATEGORIA Y CURSOS COMO ATRIBUTOS READONLY DEL FORM
    public partial class NuevoCursoForm : Form
    {
        private bool creado = false;

        public NuevoCursoForm()
        {
            InitializeComponent();
        }

        private void ABMCCursosForm_Load(object sender, EventArgs e)
        {
            CategoriaService catService = new CategoriaService();
            IList<Categoria> categorias = catService.ObtenerTodos();
            LlenarCombo(cbCategoria, categorias, "Nombre", "IdCategoria");

        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            // Datasource: establece el origen de datos de este objeto.
            cbo.DataSource = source;
            // DisplayMember: establece la propiedad que se va a mostrar para este ListControl.
            cbo.DisplayMember = display;
            // ValueMember: establece la ruta de acceso de la propiedad que se utilizará como valor real para los elementos de ListControl.
            cbo.ValueMember = value;
            //SelectedIndex: establece el índice que especifica el elemento seleccionado actualmente.
            cbo.SelectedIndex = -1;
        }

        private void btAceptarAltaCurso_Click(object sender, EventArgs e)
        {
            Curso curso = obtenerCurso();
            CursoService cser = new CursoService();



            cser.AgregarCurso(curso);
            MessageBox.Show("Se creó el curso con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.None);
            this.creado = true;
            

        }

        private Curso obtenerCurso()
        {
            CategoriaService catServ = new CategoriaService();
            Curso curso = new Curso
            {

                // Puede retonar null!!

                NombreCurso = txtNombreCurso.Text,
                Descripcion = txtDescripcionCurso.Text,
                FechaVigencia = DateTime.Parse(txtFechaCurso.Text),
                Categoria = catServ.ObtenerCategoriaById(Int32.Parse(cbCategoria.SelectedValue.ToString()))

            };
            return curso;
        }

        private void EnableButtonAceptar()
        {
            btAceptarAltaCurso.Enabled = (txtNombreCurso.Text != "" || txtNombreCurso.Visible == false) && (txtFechaCurso.Text != "  /  /" || txtFechaCurso.Visible == false) && (cbCategoria.Text != "" || cbCategoria.Visible == false);
        }


        private void ABMCCursosForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rpta;

            if (!this.creado)
            {
                rpta = MessageBox.Show("Seguro que desea salir? \nSe perderán todos los cambios.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rpta == DialogResult.No)
                    e.Cancel = true;
            }
        }

        private void txtNombreCurso_TextChanged(object sender, EventArgs e)
        {
            EnableButtonAceptar();
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableButtonAceptar();
        }

        private void txtFechaCurso_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            EnableButtonAceptar();
        }

        private void txtDescripcionCurso_TextChanged(object sender, EventArgs e)
        {
            EnableButtonAceptar();
        }

        private void txtFechaCurso_TextChanged(object sender, EventArgs e)
        {
            EnableButtonAceptar();
        }
    }
}
