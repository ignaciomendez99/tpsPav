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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvObjetivos = new System.Windows.Forms.DataGridView();
            this.objetivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvObjetivosCurso = new System.Windows.Forms.DataGridView();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.objetivoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjetivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objetivoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjetivosCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objetivoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Curso:";
            // 
            // cmbCurso
            // 
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Location = new System.Drawing.Point(67, 16);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(226, 24);
            this.cmbCurso.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dgvObjetivos);
            this.groupBox1.Controls.Add(this.dgvObjetivosCurso);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 428);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Objetivos";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::TPS_PAV.Properties.Resources.arrowDown;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(225, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 64);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::TPS_PAV.Properties.Resources.arrowUp;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(101, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 64);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvObjetivos
            // 
            this.dgvObjetivos.AutoGenerateColumns = false;
            this.dgvObjetivos.BackgroundColor = System.Drawing.Color.White;
            this.dgvObjetivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObjetivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dgvObjetivos.DataSource = this.objetivoBindingSource1;
            this.dgvObjetivos.Location = new System.Drawing.Point(7, 259);
            this.dgvObjetivos.Name = "dgvObjetivos";
            this.dgvObjetivos.RowHeadersVisible = false;
            this.dgvObjetivos.RowHeadersWidth = 51;
            this.dgvObjetivos.RowTemplate.Height = 24;
            this.dgvObjetivos.Size = new System.Drawing.Size(378, 163);
            this.dgvObjetivos.TabIndex = 1;
            // 
            // dgvObjetivosCurso
            // 
            this.dgvObjetivosCurso.AutoGenerateColumns = false;
            this.dgvObjetivosCurso.BackgroundColor = System.Drawing.Color.White;
            this.dgvObjetivosCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObjetivosCurso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvObjetivosCurso.DataSource = this.objetivoBindingSource1;
            this.dgvObjetivosCurso.Location = new System.Drawing.Point(7, 22);
            this.dgvObjetivosCurso.Name = "dgvObjetivosCurso";
            this.dgvObjetivosCurso.RowHeadersVisible = false;
            this.dgvObjetivosCurso.RowHeadersWidth = 51;
            this.dgvObjetivosCurso.RowTemplate.Height = 24;
            this.dgvObjetivosCurso.Size = new System.Drawing.Size(378, 163);
            this.dgvObjetivosCurso.TabIndex = 0;
            // 
            // objetivoBindingSource1
            // 
            this.objetivoBindingSource1.DataSource = typeof(TPS_PAV.Entities.Objetivo);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IdObjetivo";
            this.dataGridViewTextBoxColumn4.HeaderText = "ID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NombreLargo";
            this.dataGridViewTextBoxColumn5.HeaderText = "NombreLargo";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NombreCorto";
            this.dataGridViewTextBoxColumn6.HeaderText = "NombreCorto";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "IdObjetivo";
            this.dataGridViewTextBoxColumn7.HeaderText = "IdObjetivo";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "NombreLargo";
            this.dataGridViewTextBoxColumn8.HeaderText = "NombreLargo";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "NombreCorto";
            this.dataGridViewTextBoxColumn9.HeaderText = "NombreCorto";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // TransaccionObjetivoCursoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(415, 492);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCurso);
            this.Name = "TransaccionObjetivoCursoForm";
            this.Text = "TransaccionObjetivoCursoForm";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjetivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objetivoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjetivosCurso)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.BindingSource objetivoBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}