namespace TPS_PAV.GUI
{
    partial class ModificarCursoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.txDescripcion = new System.Windows.Forms.TextBox();
            this.btModificarCurso = new System.Windows.Forms.Button();
            this.cbCategoriaCursos = new System.Windows.Forms.ComboBox();
            this.txFechaVigencia = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // txId
            // 
            this.txId.Location = new System.Drawing.Point(148, 15);
            this.txId.Name = "txId";
            this.txId.ReadOnly = true;
            this.txId.Size = new System.Drawing.Size(44, 22);
            this.txId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha de Vigencia: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Categoría: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Descripcion: ";
            // 
            // txNombre
            // 
            this.txNombre.Location = new System.Drawing.Point(148, 54);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(173, 22);
            this.txNombre.TabIndex = 6;
            // 
            // txDescripcion
            // 
            this.txDescripcion.Location = new System.Drawing.Point(148, 171);
            this.txDescripcion.Name = "txDescripcion";
            this.txDescripcion.Size = new System.Drawing.Size(173, 22);
            this.txDescripcion.TabIndex = 9;
            // 
            // btModificarCurso
            // 
            this.btModificarCurso.Location = new System.Drawing.Point(246, 212);
            this.btModificarCurso.Name = "btModificarCurso";
            this.btModificarCurso.Size = new System.Drawing.Size(75, 23);
            this.btModificarCurso.TabIndex = 10;
            this.btModificarCurso.Text = "Modificar";
            this.btModificarCurso.UseVisualStyleBackColor = true;
            this.btModificarCurso.Click += new System.EventHandler(this.btModificarCurso_Click);
            // 
            // cbCategoriaCursos
            // 
            this.cbCategoriaCursos.FormattingEnabled = true;
            this.cbCategoriaCursos.Location = new System.Drawing.Point(148, 132);
            this.cbCategoriaCursos.Name = "cbCategoriaCursos";
            this.cbCategoriaCursos.Size = new System.Drawing.Size(173, 24);
            this.cbCategoriaCursos.TabIndex = 11;
            // 
            // txFechaVigencia
            // 
            this.txFechaVigencia.Location = new System.Drawing.Point(148, 93);
            this.txFechaVigencia.Mask = "00/00/0000";
            this.txFechaVigencia.Name = "txFechaVigencia";
            this.txFechaVigencia.Size = new System.Drawing.Size(173, 22);
            this.txFechaVigencia.TabIndex = 12;
            // 
            // ModificarCursoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 247);
            this.Controls.Add(this.txFechaVigencia);
            this.Controls.Add(this.cbCategoriaCursos);
            this.Controls.Add(this.btModificarCurso);
            this.Controls.Add(this.txDescripcion);
            this.Controls.Add(this.txNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txId);
            this.Controls.Add(this.label1);
            this.Name = "ModificarCursoForm";
            this.Text = "Modificar Curso";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModificarCursoForm_FormClosing);
            this.Load += new System.EventHandler(this.ModificarCursoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.TextBox txDescripcion;
        private System.Windows.Forms.Button btModificarCurso;
        private System.Windows.Forms.ComboBox cbCategoriaCursos;
        private System.Windows.Forms.MaskedTextBox txFechaVigencia;
    }
}