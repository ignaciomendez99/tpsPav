namespace TPS_PAV.GUI
{
    partial class ModificarObjetivoForm
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
            this.btnModificarObj = new System.Windows.Forms.Button();
            this.txtBoxDescripcion = new System.Windows.Forms.TextBox();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnModificarObj
            // 
            this.btnModificarObj.Location = new System.Drawing.Point(217, 96);
            this.btnModificarObj.Name = "btnModificarObj";
            this.btnModificarObj.Size = new System.Drawing.Size(75, 23);
            this.btnModificarObj.TabIndex = 9;
            this.btnModificarObj.Text = "Editar";
            this.btnModificarObj.UseVisualStyleBackColor = true;
            this.btnModificarObj.Click += new System.EventHandler(this.btnModificarObj_Click);
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.Location = new System.Drawing.Point(103, 58);
            this.txtBoxDescripcion.MaxLength = 100;
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.Size = new System.Drawing.Size(189, 22);
            this.txtBoxDescripcion.TabIndex = 8;
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(103, 20);
            this.txtBoxNombre.MaxLength = 50;
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(189, 22);
            this.txtBoxNombre.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descripcion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre:";
            // 
            // ModificarObjetivoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 139);
            this.Controls.Add(this.btnModificarObj);
            this.Controls.Add(this.txtBoxDescripcion);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModificarObjetivoForm";
            this.Text = "ModificarObjetivoForm";
            this.Load += new System.EventHandler(this.ModificarObjetivoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificarObj;
        private System.Windows.Forms.TextBox txtBoxDescripcion;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}