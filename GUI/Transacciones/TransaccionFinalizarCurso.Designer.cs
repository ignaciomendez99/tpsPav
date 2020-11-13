namespace TPS_PAV.GUI.Transacciones
{
    partial class TransaccionFinalizarCurso
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbCurso = new System.Windows.Forms.ComboBox();
            this.dgv_Usuarios = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sueldosTableAdapter1 = new TPS_PAV.BugTracker78710DataSetTableAdapters.SueldosTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.idUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perfilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.objetivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objetivoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Curso:";
            // 
            // cbCurso
            // 
            this.cbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCurso.FormattingEnabled = true;
            this.cbCurso.Location = new System.Drawing.Point(71, 24);
            this.cbCurso.Name = "cbCurso";
            this.cbCurso.Size = new System.Drawing.Size(217, 24);
            this.cbCurso.TabIndex = 1;
            this.cbCurso.SelectedIndexChanged += new System.EventHandler(this.cbCurso_SelectedIndexChanged);
            // 
            // dgv_Usuarios
            // 
            this.dgv_Usuarios.AutoGenerateColumns = false;
            this.dgv_Usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Usuarios.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuarioDataGridViewTextBoxColumn,
            this.nombreUsuarioDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.perfilDataGridViewTextBoxColumn});
            this.dgv_Usuarios.DataSource = this.usuarioBindingSource;
            this.dgv_Usuarios.Location = new System.Drawing.Point(19, 64);
            this.dgv_Usuarios.MultiSelect = false;
            this.dgv_Usuarios.Name = "dgv_Usuarios";
            this.dgv_Usuarios.ReadOnly = true;
            this.dgv_Usuarios.RowHeadersVisible = false;
            this.dgv_Usuarios.RowHeadersWidth = 51;
            this.dgv_Usuarios.RowTemplate.Height = 24;
            this.dgv_Usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Usuarios.Size = new System.Drawing.Size(658, 379);
            this.dgv_Usuarios.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgv_Usuarios);
            this.groupBox1.Controls.Add(this.cbCurso);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 485);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuario por Curso";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(550, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Finalizar Curso";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sueldosTableAdapter1
            // 
            this.sueldosTableAdapter1.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Este curso ha finalizado, no se puede modificar";
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            this.idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.HeaderText = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            this.idUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idUsuarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreUsuarioDataGridViewTextBoxColumn
            // 
            this.nombreUsuarioDataGridViewTextBoxColumn.DataPropertyName = "NombreUsuario";
            this.nombreUsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
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
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Condicion";
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
            this.passwordDataGridViewTextBoxColumn.Visible = false;
            // 
            // perfilDataGridViewTextBoxColumn
            // 
            this.perfilDataGridViewTextBoxColumn.DataPropertyName = "Perfil";
            this.perfilDataGridViewTextBoxColumn.HeaderText = "Perfil";
            this.perfilDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perfilDataGridViewTextBoxColumn.Name = "perfilDataGridViewTextBoxColumn";
            this.perfilDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(TPS_PAV.Entities.Usuario);
            // 
            // objetivoBindingSource
            // 
            this.objetivoBindingSource.DataSource = typeof(TPS_PAV.Entities.Objetivo);
            // 
            // TransaccionActualizarAvance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 507);
            this.Controls.Add(this.groupBox1);
            this.Name = "TransaccionActualizarAvance";
            this.Text = "TransaccionActualizarAvance";
            this.Load += new System.EventHandler(this.TransaccionActualizarAvance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objetivoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCurso;
        private System.Windows.Forms.DataGridView dgv_Usuarios;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perfilDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource objetivoBindingSource;
        private System.Windows.Forms.Button button1;
        private BugTracker78710DataSetTableAdapters.SueldosTableAdapter sueldosTableAdapter1;
        private System.Windows.Forms.Label label2;
    }
}