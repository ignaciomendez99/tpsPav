namespace TPS_PAV.GUI
{
    partial class BMCCursosForm
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
            this.txBuscar = new System.Windows.Forms.TextBox();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.bnBorrarCurso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btModificarCurso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // txBuscar
            // 
            this.txBuscar.Location = new System.Drawing.Point(74, 13);
            this.txBuscar.Name = "txBuscar";
            this.txBuscar.Size = new System.Drawing.Size(246, 22);
            this.txBuscar.TabIndex = 1;
            this.txBuscar.TextChanged += new System.EventHandler(this.bnBuscarCurso_Click);
            // 
            // dgvCursos
            // 
            this.dgvCursos.AllowUserToAddRows = false;
            this.dgvCursos.AllowUserToDeleteRows = false;
            this.dgvCursos.AllowUserToResizeRows = false;
            this.dgvCursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Location = new System.Drawing.Point(13, 41);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.ReadOnly = true;
            this.dgvCursos.RowHeadersWidth = 51;
            this.dgvCursos.RowTemplate.Height = 24;
            this.dgvCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCursos.Size = new System.Drawing.Size(566, 376);
            this.dgvCursos.TabIndex = 3;
            this.dgvCursos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCursos_CellClick);
            // 
            // bnBorrarCurso
            // 
            this.bnBorrarCurso.Enabled = false;
            this.bnBorrarCurso.Location = new System.Drawing.Point(505, 421);
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
            // 
            // btModificarCurso
            // 
            this.btModificarCurso.Enabled = false;
            this.btModificarCurso.Location = new System.Drawing.Point(424, 421);
            this.btModificarCurso.Name = "btModificarCurso";
            this.btModificarCurso.Size = new System.Drawing.Size(75, 23);
            this.btModificarCurso.TabIndex = 6;
            this.btModificarCurso.Text = "Modificar";
            this.btModificarCurso.UseVisualStyleBackColor = true;
            this.btModificarCurso.Click += new System.EventHandler(this.btModificarCurso_Click);
            // 
            // BMCCursosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 455);
            this.Controls.Add(this.btModificarCurso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bnBorrarCurso);
            this.Controls.Add(this.dgvCursos);
            this.Controls.Add(this.txBuscar);
            this.Name = "BMCCursosForm";
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.BMCCursosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txBuscar;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.Button bnBorrarCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btModificarCurso;
    }
}