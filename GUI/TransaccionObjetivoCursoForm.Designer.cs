namespace TPS_PAV.GUI
{
    partial class TransaccionObjetivoCursoForm
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
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bnAdd = new System.Windows.Forms.Button();
            this.bnRemove = new System.Windows.Forms.Button();
            this.dgvObjetivosParticular = new System.Windows.Forms.DataGridView();
            this.IdObjetivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvObjetivosCurso = new System.Windows.Forms.DataGridView();
            this.objetivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bnConfirmarTransaccion = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objetivoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjetivosParticular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjetivosCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objetivoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objetivoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Curso:";
            // 
            // cmbCurso
            // 
            this.cmbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Location = new System.Drawing.Point(159, 37);
            this.cmbCurso.Margin = new System.Windows.Forms.Padding(7);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(531, 45);
            this.cmbCurso.TabIndex = 1;
            this.cmbCurso.SelectedIndexChanged += new System.EventHandler(this.cmbCurso_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bnAdd);
            this.groupBox1.Controls.Add(this.bnRemove);
            this.groupBox1.Controls.Add(this.dgvObjetivosParticular);
            this.groupBox1.Controls.Add(this.dgvObjetivosCurso);
            this.groupBox1.Location = new System.Drawing.Point(28, 130);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7);
            this.groupBox1.Size = new System.Drawing.Size(940, 990);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Objetivos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(650, 548);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Propios del curso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(808, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Todos";
            // 
            // bnAdd
            // 
            this.bnAdd.BackgroundImage = global::TPS_PAV.Properties.Resources.arrowDown;
            this.bnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bnAdd.FlatAppearance.BorderSize = 0;
            this.bnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnAdd.Location = new System.Drawing.Point(160, 471);
            this.bnAdd.Margin = new System.Windows.Forms.Padding(7);
            this.bnAdd.Name = "bnAdd";
            this.bnAdd.Size = new System.Drawing.Size(128, 114);
            this.bnAdd.TabIndex = 3;
            this.bnAdd.UseVisualStyleBackColor = true;
            this.bnAdd.Click += new System.EventHandler(this.bnAdd_Click);
            // 
            // bnRemove
            // 
            this.bnRemove.BackgroundImage = global::TPS_PAV.Properties.Resources.arrowUp;
            this.bnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bnRemove.FlatAppearance.BorderSize = 0;
            this.bnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnRemove.Location = new System.Drawing.Point(17, 471);
            this.bnRemove.Margin = new System.Windows.Forms.Padding(7);
            this.bnRemove.Name = "bnRemove";
            this.bnRemove.Size = new System.Drawing.Size(120, 114);
            this.bnRemove.TabIndex = 2;
            this.bnRemove.UseVisualStyleBackColor = true;
            this.bnRemove.Click += new System.EventHandler(this.bnRemove_Click);
            // 
            // dgvObjetivosParticular
            // 
            this.dgvObjetivosParticular.AllowUserToAddRows = false;
            this.dgvObjetivosParticular.AllowUserToDeleteRows = false;
            this.dgvObjetivosParticular.AutoGenerateColumns = false;
            this.dgvObjetivosParticular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvObjetivosParticular.BackgroundColor = System.Drawing.Color.White;
            this.dgvObjetivosParticular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObjetivosParticular.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdObjetivo,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dgvObjetivosParticular.DataSource = this.objetivoBindingSource1;
            this.dgvObjetivosParticular.Location = new System.Drawing.Point(17, 599);
            this.dgvObjetivosParticular.Margin = new System.Windows.Forms.Padding(7);
            this.dgvObjetivosParticular.Name = "dgvObjetivosParticular";
            this.dgvObjetivosParticular.ReadOnly = true;
            this.dgvObjetivosParticular.RowHeadersVisible = false;
            this.dgvObjetivosParticular.RowHeadersWidth = 51;
            this.dgvObjetivosParticular.RowTemplate.Height = 24;
            this.dgvObjetivosParticular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObjetivosParticular.Size = new System.Drawing.Size(898, 377);
            this.dgvObjetivosParticular.TabIndex = 1;
            // 
            // IdObjetivo
            // 
            this.IdObjetivo.DataPropertyName = "IdObjetivo";
            this.IdObjetivo.HeaderText = "ID";
            this.IdObjetivo.MinimumWidth = 15;
            this.IdObjetivo.Name = "IdObjetivo";
            this.IdObjetivo.ReadOnly = true;
            // 
            // dgvObjetivosCurso
            // 
            this.dgvObjetivosCurso.AllowUserToAddRows = false;
            this.dgvObjetivosCurso.AllowUserToDeleteRows = false;
            this.dgvObjetivosCurso.AutoGenerateColumns = false;
            this.dgvObjetivosCurso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvObjetivosCurso.BackgroundColor = System.Drawing.Color.White;
            this.dgvObjetivosCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObjetivosCurso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvObjetivosCurso.DataSource = this.objetivoBindingSource1;
            this.dgvObjetivosCurso.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvObjetivosCurso.Location = new System.Drawing.Point(17, 80);
            this.dgvObjetivosCurso.Margin = new System.Windows.Forms.Padding(7);
            this.dgvObjetivosCurso.Name = "dgvObjetivosCurso";
            this.dgvObjetivosCurso.ReadOnly = true;
            this.dgvObjetivosCurso.RowHeadersVisible = false;
            this.dgvObjetivosCurso.RowHeadersWidth = 51;
            this.dgvObjetivosCurso.RowTemplate.Height = 24;
            this.dgvObjetivosCurso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObjetivosCurso.Size = new System.Drawing.Size(898, 377);
            this.dgvObjetivosCurso.TabIndex = 0;
            // 
            // bnConfirmarTransaccion
            // 
            this.bnConfirmarTransaccion.Location = new System.Drawing.Point(252, 1130);
            this.bnConfirmarTransaccion.Name = "bnConfirmarTransaccion";
            this.bnConfirmarTransaccion.Size = new System.Drawing.Size(475, 101);
            this.bnConfirmarTransaccion.TabIndex = 3;
            this.bnConfirmarTransaccion.Text = "Confirmar Transaccion";
            this.bnConfirmarTransaccion.UseVisualStyleBackColor = true;
            this.bnConfirmarTransaccion.Click += new System.EventHandler(this.bnConfirmarTransaccion_Click);
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "NombreLargo";
            this.dataGridViewTextBoxColumn8.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "NombreCorto";
            this.dataGridViewTextBoxColumn9.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // objetivoBindingSource1
            // 
            this.objetivoBindingSource1.DataSource = typeof(TPS_PAV.Entities.Curso);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IdObjetivo";
            this.dataGridViewTextBoxColumn4.HeaderText = "IdObjetivo";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 15;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NombreLargo";
            this.dataGridViewTextBoxColumn5.HeaderText = "NombreLargo";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 15;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NombreCorto";
            this.dataGridViewTextBoxColumn6.HeaderText = "NombreCorto";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 15;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // TransaccionObjetivoCursoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(288F, 288F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(986, 1258);
            this.Controls.Add(this.bnConfirmarTransaccion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCurso);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "TransaccionObjetivoCursoForm";
            this.Text = "TransaccionObjetivoCursoForm";
            this.Load += new System.EventHandler(this.TransaccionObjetivoCursoForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjetivosParticular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjetivosCurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objetivoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objetivoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvObjetivosCurso;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.BindingSource objetivoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idObjetivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreLargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCortoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvObjetivosParticular;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button bnRemove;
        private System.Windows.Forms.Button bnAdd;
        private System.Windows.Forms.BindingSource objetivoBindingSource1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdObjetivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button bnConfirmarTransaccion;
    }
}