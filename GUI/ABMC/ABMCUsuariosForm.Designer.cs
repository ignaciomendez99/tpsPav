namespace TPS_PAV.GUI
{
    partial class ABMCUsuariosForm
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
            this.labelCantidad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkMostrarEliminados = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btModificarCurso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bnBorrarCurso = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.txBuscar = new System.Windows.Forms.TextBox();
            this.cursoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perfilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Location = new System.Drawing.Point(56, 420);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(16, 17);
            this.labelCantidad.TabIndex = 21;
            this.labelCantidad.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Total: ";
            // 
            // checkMostrarEliminados
            // 
            this.checkMostrarEliminados.AutoSize = true;
            this.checkMostrarEliminados.Location = new System.Drawing.Point(661, 13);
            this.checkMostrarEliminados.Name = "checkMostrarEliminados";
            this.checkMostrarEliminados.Size = new System.Drawing.Size(18, 17);
            this.checkMostrarEliminados.TabIndex = 19;
            this.checkMostrarEliminados.UseVisualStyleBackColor = true;
            this.checkMostrarEliminados.CheckedChanged += new System.EventHandler(this.checkMostrarEliminados_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Consultar usuarios eliminados";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(444, 418);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // btModificarCurso
            // 
            this.btModificarCurso.Enabled = false;
            this.btModificarCurso.Location = new System.Drawing.Point(525, 418);
            this.btModificarCurso.Name = "btModificarCurso";
            this.btModificarCurso.Size = new System.Drawing.Size(75, 23);
            this.btModificarCurso.TabIndex = 16;
            this.btModificarCurso.Text = "Modificar";
            this.btModificarCurso.UseVisualStyleBackColor = true;
            this.btModificarCurso.Click += new System.EventHandler(this.btModificarUsuario_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Buscar:";
            // 
            // bnBorrarCurso
            // 
            this.bnBorrarCurso.Enabled = false;
            this.bnBorrarCurso.Location = new System.Drawing.Point(606, 418);
            this.bnBorrarCurso.Name = "bnBorrarCurso";
            this.bnBorrarCurso.Size = new System.Drawing.Size(75, 23);
            this.bnBorrarCurso.TabIndex = 14;
            this.bnBorrarCurso.Text = "Borrar";
            this.bnBorrarCurso.UseVisualStyleBackColor = true;
            this.bnBorrarCurso.Click += new System.EventHandler(this.bnBorrarCurso_Click_1);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeColumns = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.AutoGenerateColumns = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuarioDataGridViewTextBoxColumn,
            this.nombreUsuarioDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.perfilDataGridViewTextBoxColumn});
            this.dgvUsuarios.DataSource = this.usuarioBindingSource;
            this.dgvUsuarios.GridColor = System.Drawing.Color.DarkGray;
            this.dgvUsuarios.Location = new System.Drawing.Point(17, 38);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(662, 376);
            this.dgvUsuarios.TabIndex = 13;
            this.dgvUsuarios.DataSourceChanged += new System.EventHandler(this.dgvUsuarios_DataSourceChanged);
            this.dgvUsuarios.SelectionChanged += new System.EventHandler(this.dgvUsuarios_SelectionChanged);
            // 
            // txBuscar
            // 
            this.txBuscar.Location = new System.Drawing.Point(78, 10);
            this.txBuscar.Name = "txBuscar";
            this.txBuscar.Size = new System.Drawing.Size(246, 22);
            this.txBuscar.TabIndex = 12;
            this.txBuscar.TextChanged += new System.EventHandler(this.txBuscar_TextChanged);
            // 
            // cursoBindingSource1
            // 
            this.cursoBindingSource1.DataSource = typeof(TPS_PAV.Entities.Curso);
            // 
            // cursoBindingSource
            // 
            this.cursoBindingSource.DataSource = typeof(TPS_PAV.Entities.Curso);
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(TPS_PAV.Entities.Usuario);
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            this.idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.HeaderText = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            this.idUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreUsuarioDataGridViewTextBoxColumn
            // 
            this.nombreUsuarioDataGridViewTextBoxColumn.DataPropertyName = "NombreUsuario";
            this.nombreUsuarioDataGridViewTextBoxColumn.HeaderText = "NombreUsuario";
            this.nombreUsuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreUsuarioDataGridViewTextBoxColumn.Name = "nombreUsuarioDataGridViewTextBoxColumn";
            this.nombreUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perfilDataGridViewTextBoxColumn
            // 
            this.perfilDataGridViewTextBoxColumn.DataPropertyName = "Perfil";
            this.perfilDataGridViewTextBoxColumn.HeaderText = "Perfil";
            this.perfilDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perfilDataGridViewTextBoxColumn.Name = "perfilDataGridViewTextBoxColumn";
            this.perfilDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ABMCUsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 450);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkMostrarEliminados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btModificarCurso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bnBorrarCurso);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.txBuscar);
            this.Name = "ABMCUsuariosForm";
            this.Text = "ABMCUsuariosForm";
            this.Load += new System.EventHandler(this.ABMCUsuariosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkMostrarEliminados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btModificarCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bnBorrarCurso;
        private System.Windows.Forms.BindingSource cursoBindingSource;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.BindingSource cursoBindingSource1;
        private System.Windows.Forms.TextBox txBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perfilDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
    }
}