namespace TPS_PAV.GUI
{
    partial class ABMCursosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txBuscar = new System.Windows.Forms.TextBox();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.idCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVigenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cursoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bnBorrarCurso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btModificarCurso = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.checkMostrarEliminados = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txBuscar
            // 
            this.txBuscar.Location = new System.Drawing.Point(74, 13);
            this.txBuscar.Name = "txBuscar";
            this.txBuscar.Size = new System.Drawing.Size(246, 22);
            this.txBuscar.TabIndex = 1;
            this.txBuscar.TextChanged += new System.EventHandler(this.txBuscar_TextChanged);
            // 
            // dgvCursos
            // 
            this.dgvCursos.AllowUserToAddRows = false;
            this.dgvCursos.AllowUserToDeleteRows = false;
            this.dgvCursos.AllowUserToResizeColumns = false;
            this.dgvCursos.AllowUserToResizeRows = false;
            this.dgvCursos.AutoGenerateColumns = false;
            this.dgvCursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCursos.BackgroundColor = System.Drawing.Color.White;
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCursoDataGridViewTextBoxColumn,
            this.nombreCursoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.fechaVigenciaDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn});
            this.dgvCursos.DataSource = this.cursoBindingSource1;
            this.dgvCursos.GridColor = System.Drawing.Color.DarkGray;
            this.dgvCursos.Location = new System.Drawing.Point(13, 41);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.ReadOnly = true;
            this.dgvCursos.RowHeadersVisible = false;
            this.dgvCursos.RowHeadersWidth = 51;
            this.dgvCursos.RowTemplate.Height = 24;
            this.dgvCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCursos.Size = new System.Drawing.Size(662, 376);
            this.dgvCursos.TabIndex = 3;
            this.dgvCursos.DataSourceChanged += new System.EventHandler(this.dgvCursos_DataSourceChanged);
            this.dgvCursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCursos_CellContentClick);
            this.dgvCursos.SelectionChanged += new System.EventHandler(this.dgvCursos_SelectionChanged);
            // 
            // idCursoDataGridViewTextBoxColumn
            // 
            this.idCursoDataGridViewTextBoxColumn.DataPropertyName = "IdCurso";
            this.idCursoDataGridViewTextBoxColumn.HeaderText = "IdCurso";
            this.idCursoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idCursoDataGridViewTextBoxColumn.Name = "idCursoDataGridViewTextBoxColumn";
            this.idCursoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCursoDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreCursoDataGridViewTextBoxColumn
            // 
            this.nombreCursoDataGridViewTextBoxColumn.DataPropertyName = "NombreCurso";
            this.nombreCursoDataGridViewTextBoxColumn.HeaderText = "Nombre Curso";
            this.nombreCursoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreCursoDataGridViewTextBoxColumn.Name = "nombreCursoDataGridViewTextBoxColumn";
            this.nombreCursoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaVigenciaDataGridViewTextBoxColumn
            // 
            this.fechaVigenciaDataGridViewTextBoxColumn.DataPropertyName = "FechaVigencia";
            this.fechaVigenciaDataGridViewTextBoxColumn.HeaderText = "Fecha de Vigencia";
            this.fechaVigenciaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaVigenciaDataGridViewTextBoxColumn.Name = "fechaVigenciaDataGridViewTextBoxColumn";
            this.fechaVigenciaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            this.categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cursoBindingSource1
            // 
            this.cursoBindingSource1.DataSource = typeof(TPS_PAV.Entities.Curso);
            this.cursoBindingSource1.CurrentChanged += new System.EventHandler(this.cursoBindingSource1_CurrentChanged);
            // 
            // cursoBindingSource
            // 
            this.cursoBindingSource.DataSource = typeof(TPS_PAV.Entities.Curso);
            this.cursoBindingSource.CurrentChanged += new System.EventHandler(this.cursoBindingSource_CurrentChanged);
            // 
            // bnBorrarCurso
            // 
            this.bnBorrarCurso.Enabled = false;
            this.bnBorrarCurso.Location = new System.Drawing.Point(602, 421);
            this.bnBorrarCurso.Name = "bnBorrarCurso";
            this.bnBorrarCurso.Size = new System.Drawing.Size(75, 23);
            this.bnBorrarCurso.TabIndex = 4;
            this.bnBorrarCurso.Text = "Borrar";
            this.bnBorrarCurso.UseVisualStyleBackColor = true;
            this.bnBorrarCurso.Click += new System.EventHandler(this.bnBorrarCurso_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buscar:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btModificarCurso
            // 
            this.btModificarCurso.Enabled = false;
            this.btModificarCurso.Location = new System.Drawing.Point(521, 421);
            this.btModificarCurso.Name = "btModificarCurso";
            this.btModificarCurso.Size = new System.Drawing.Size(75, 23);
            this.btModificarCurso.TabIndex = 6;
            this.btModificarCurso.Text = "Modificar";
            this.btModificarCurso.UseVisualStyleBackColor = true;
            this.btModificarCurso.Click += new System.EventHandler(this.btModificarCurso_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(440, 421);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // checkMostrarEliminados
            // 
            this.checkMostrarEliminados.AutoSize = true;
            this.checkMostrarEliminados.Location = new System.Drawing.Point(657, 16);
            this.checkMostrarEliminados.Name = "checkMostrarEliminados";
            this.checkMostrarEliminados.Size = new System.Drawing.Size(18, 17);
            this.checkMostrarEliminados.TabIndex = 9;
            this.checkMostrarEliminados.UseVisualStyleBackColor = true;
            this.checkMostrarEliminados.CheckedChanged += new System.EventHandler(this.checkMostrarEliminados_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Consultar cursos eliminados";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Total: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Location = new System.Drawing.Point(52, 423);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(16, 17);
            this.labelCantidad.TabIndex = 11;
            this.labelCantidad.Text = "0";
            this.labelCantidad.Click += new System.EventHandler(this.labelCantidad_Click);
            // 
            // ABMCursosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 455);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkMostrarEliminados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btModificarCurso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bnBorrarCurso);
            this.Controls.Add(this.dgvCursos);
            this.Controls.Add(this.txBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ABMCursosForm";
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.BMCCursosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txBuscar;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.Button bnBorrarCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btModificarCurso;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.CheckBox checkMostrarEliminados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource cursoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVigenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.BindingSource cursoBindingSource1;
    }
}