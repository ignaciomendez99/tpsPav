namespace TPS_PAV.GUI
{
    partial class ABMCObjetivosForm
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
            this.txtBoxBuscar = new System.Windows.Forms.TextBox();
            this.checkEliminados = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_Objetivos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objetivoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.objetivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Objetivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objetivoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objetivoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar:";
            // 
            // txtBoxBuscar
            // 
            this.txtBoxBuscar.Location = new System.Drawing.Point(75, 9);
            this.txtBoxBuscar.MaxLength = 100;
            this.txtBoxBuscar.Name = "txtBoxBuscar";
            this.txtBoxBuscar.Size = new System.Drawing.Size(256, 22);
            this.txtBoxBuscar.TabIndex = 1;
            this.txtBoxBuscar.TextChanged += new System.EventHandler(this.txtBoxBuscar_TextChanged);
            // 
            // checkEliminados
            // 
            this.checkEliminados.AutoSize = true;
            this.checkEliminados.Location = new System.Drawing.Point(628, 13);
            this.checkEliminados.Name = "checkEliminados";
            this.checkEliminados.Size = new System.Drawing.Size(18, 17);
            this.checkEliminados.TabIndex = 2;
            this.checkEliminados.UseVisualStyleBackColor = true;
            this.checkEliminados.CheckedChanged += new System.EventHandler(this.checkEliminados_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(431, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Consultar objetivos liminados";
            // 
            // dgv_Objetivos
            // 
            this.dgv_Objetivos.AllowUserToAddRows = false;
            this.dgv_Objetivos.AllowUserToDeleteRows = false;
            this.dgv_Objetivos.AllowUserToResizeColumns = false;
            this.dgv_Objetivos.AllowUserToResizeRows = false;
            this.dgv_Objetivos.AutoGenerateColumns = false;
            this.dgv_Objetivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Objetivos.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Objetivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Objetivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2});
            this.dgv_Objetivos.DataSource = this.objetivoBindingSource1;
            this.dgv_Objetivos.GridColor = System.Drawing.Color.DarkGray;
            this.dgv_Objetivos.Location = new System.Drawing.Point(15, 44);
            this.dgv_Objetivos.Name = "dgv_Objetivos";
            this.dgv_Objetivos.ReadOnly = true;
            this.dgv_Objetivos.RowHeadersVisible = false;
            this.dgv_Objetivos.RowHeadersWidth = 51;
            this.dgv_Objetivos.RowTemplate.Height = 24;
            this.dgv_Objetivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Objetivos.Size = new System.Drawing.Size(631, 441);
            this.dgv_Objetivos.TabIndex = 4;
            this.dgv_Objetivos.SelectionChanged += new System.EventHandler(this.dgv_Objetivos_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 492);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.AutoSize = true;
            this.txtCantidad.Location = new System.Drawing.Point(56, 492);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(16, 17);
            this.txtCantidad.TabIndex = 6;
            this.txtCantidad.Text = "0";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(483, 492);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(564, 492);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 8;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAgregar.Location = new System.Drawing.Point(402, 492);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdObjetivo";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdObjetivo";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NombreCorto";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NombreLargo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // objetivoBindingSource1
            // 
            this.objetivoBindingSource1.DataSource = typeof(TPS_PAV.Entities.Objetivo);
            // 
            // objetivoBindingSource
            // 
            this.objetivoBindingSource.DataSource = typeof(TPS_PAV.Entities.Curso);
            // 
            // ABMCObjetivosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 524);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_Objetivos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkEliminados);
            this.Controls.Add(this.txtBoxBuscar);
            this.Controls.Add(this.label1);
            this.Name = "ABMCObjetivosForm";
            this.Text = "ABMCObjetivosForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Objetivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objetivoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objetivoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxBuscar;
        private System.Windows.Forms.CheckBox checkEliminados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_Objetivos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtCantidad;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.BindingSource objetivoBindingSource;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idObjetivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCortoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreLargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource objetivoBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}