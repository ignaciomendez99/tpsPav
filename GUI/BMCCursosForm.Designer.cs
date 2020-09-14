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
            this.bnBuscarCurso = new System.Windows.Forms.Button();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.bnBorrarCurso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // txBuscar
            // 
            this.txBuscar.Location = new System.Drawing.Point(12, 12);
            this.txBuscar.Name = "txBuscar";
            this.txBuscar.Size = new System.Drawing.Size(563, 22);
            this.txBuscar.TabIndex = 1;
            // 
            // bnBuscarCurso
            // 
            this.bnBuscarCurso.Location = new System.Drawing.Point(582, 13);
            this.bnBuscarCurso.Name = "bnBuscarCurso";
            this.bnBuscarCurso.Size = new System.Drawing.Size(75, 23);
            this.bnBuscarCurso.TabIndex = 2;
            this.bnBuscarCurso.Text = "Buscar";
            this.bnBuscarCurso.UseVisualStyleBackColor = true;
            this.bnBuscarCurso.Click += new System.EventHandler(this.bnBuscarCurso_Click);
            // 
            // dgvCursos
            // 
            this.dgvCursos.AllowUserToAddRows = false;
            this.dgvCursos.AllowUserToDeleteRows = false;
            this.dgvCursos.AllowUserToResizeRows = false;
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Location = new System.Drawing.Point(13, 41);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.ReadOnly = true;
            this.dgvCursos.RowHeadersWidth = 51;
            this.dgvCursos.RowTemplate.Height = 24;
            this.dgvCursos.Size = new System.Drawing.Size(644, 376);
            this.dgvCursos.TabIndex = 3;
            // 
            // bnBorrarCurso
            // 
            this.bnBorrarCurso.Location = new System.Drawing.Point(311, 420);
            this.bnBorrarCurso.Name = "bnBorrarCurso";
            this.bnBorrarCurso.Size = new System.Drawing.Size(75, 23);
            this.bnBorrarCurso.TabIndex = 4;
            this.bnBorrarCurso.Text = "Borrar";
            this.bnBorrarCurso.UseVisualStyleBackColor = true;
            // 
            // BMCCursosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 455);
            this.Controls.Add(this.bnBorrarCurso);
            this.Controls.Add(this.dgvCursos);
            this.Controls.Add(this.bnBuscarCurso);
            this.Controls.Add(this.txBuscar);
            this.Name = "BMCCursosForm";
            this.Text = "BMCCursosForm";
            this.Load += new System.EventHandler(this.BMCCursosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txBuscar;
        private System.Windows.Forms.Button bnBuscarCurso;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.Button bnBorrarCurso;
    }
}