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
            this.bnRemover = new System.Windows.Forms.Button();
            this.bnAgregar = new System.Windows.Forms.Button();
            this.dgvObjetivos = new System.Windows.Forms.DataGridView();
            this.IdObjetivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvObjetivosCurso = new System.Windows.Forms.DataGridView();
            this.objetivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objetivoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjetivos)).BeginInit();
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
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bnRemover);
            this.groupBox1.Controls.Add(this.bnAgregar);
            this.groupBox1.Controls.Add(this.dgvObjetivos);
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
            // bnRemover
            // 
            this.bnRemover.BackgroundImage = global::TPS_PAV.Properties.Resources.arrowDown;
            this.bnRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bnRemover.FlatAppearance.BorderSize = 0;
            this.bnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnRemover.Location = new System.Drawing.Point(160, 471);
            this.bnRemover.Margin = new System.Windows.Forms.Padding(7);
            this.bnRemover.Name = "bnRemover";
            this.bnRemover.Size = new System.Drawing.Size(128, 114);
            this.bnRemover.TabIndex = 3;
            this.bnRemover.UseVisualStyleBackColor = true;
            this.bnRemover.Click += new System.EventHandler(this.bnRemover_Click);
            // 
            // bnAgregar
            // 
            this.bnAgregar.BackgroundImage = global::TPS_PAV.Properties.Resources.arrowUp;
            this.bnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bnAgregar.FlatAppearance.BorderSize = 0;
            this.bnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnAgregar.Location = new System.Drawing.Point(17, 471);
            this.bnAgregar.Margin = new System.Windows.Forms.Padding(7);
            this.bnAgregar.Name = "bnAgregar";
            this.bnAgregar.Size = new System.Drawing.Size(120, 114);
            this.bnAgregar.TabIndex = 2;
            this.bnAgregar.UseVisualStyleBackColor = true;
            this.bnAgregar.Click += new System.EventHandler(this.bnAgregar_Click);
            // 
            // dgvObjetivos
            // 
            this.dgvObjetivos.AutoGenerateColumns = false;
            this.dgvObjetivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvObjetivos.BackgroundColor = System.Drawing.Color.White;
            this.dgvObjetivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObjetivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdObjetivo,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dgvObjetivos.DataSource = this.objetivoBindingSource1;
            this.dgvObjetivos.Location = new System.Drawing.Point(17, 599);
            this.dgvObjetivos.Margin = new System.Windows.Forms.Padding(7);
            this.dgvObjetivos.Name = "dgvObjetivos";
            this.dgvObjetivos.RowHeadersVisible = false;
            this.dgvObjetivos.RowHeadersWidth = 51;
            this.dgvObjetivos.RowTemplate.Height = 24;
            this.dgvObjetivos.Size = new System.Drawing.Size(898, 377);
            this.dgvObjetivos.TabIndex = 1;
            // 
            // IdObjetivo
            // 
            this.IdObjetivo.DataPropertyName = "IdObjetivo";
            this.IdObjetivo.HeaderText = "ID";
            this.IdObjetivo.MinimumWidth = 15;
            this.IdObjetivo.Name = "IdObjetivo";
            // 
            // dgvObjetivosCurso
            // 
            this.dgvObjetivosCurso.AutoGenerateColumns = false;
            this.dgvObjetivosCurso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvObjetivosCurso.BackgroundColor = System.Drawing.Color.White;
            this.dgvObjetivosCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObjetivosCurso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvObjetivosCurso.DataSource = this.objetivoBindingSource1;
            this.dgvObjetivosCurso.Location = new System.Drawing.Point(17, 80);
            this.dgvObjetivosCurso.Margin = new System.Windows.Forms.Padding(7);
            this.dgvObjetivosCurso.Name = "dgvObjetivosCurso";
            this.dgvObjetivosCurso.RowHeadersVisible = false;
            this.dgvObjetivosCurso.RowHeadersWidth = 51;
            this.dgvObjetivosCurso.RowTemplate.Height = 24;
            this.dgvObjetivosCurso.Size = new System.Drawing.Size(898, 377);
            this.dgvObjetivosCurso.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "NombreLargo";
            this.dataGridViewTextBoxColumn8.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "NombreCorto";
            this.dataGridViewTextBoxColumn9.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // objetivoBindingSource1
            // 
            this.objetivoBindingSource1.DataSource = typeof(TPS_PAV.Entities.Objetivo);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IdObjetivo";
            this.dataGridViewTextBoxColumn4.HeaderText = "IdObjetivo";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 15;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NombreLargo";
            this.dataGridViewTextBoxColumn5.HeaderText = "NombreLargo";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 15;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NombreCorto";
            this.dataGridViewTextBoxColumn6.HeaderText = "NombreCorto";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 15;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // TransaccionObjetivoCursoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(986, 1174);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCurso);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "TransaccionObjetivoCursoForm";
            this.Text = "TransaccionObjetivoCursoForm";
            this.Load += new System.EventHandler(this.TransaccionObjetivoCursoForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjetivos)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvObjetivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button bnAgregar;
        private System.Windows.Forms.Button bnRemover;
        private System.Windows.Forms.BindingSource objetivoBindingSource1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdObjetivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}