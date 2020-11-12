namespace TPS_PAV.GUI
{
    partial class ModificarUsuarioForm
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
            this.bnCancelar = new System.Windows.Forms.Button();
            this.bnAceptar = new System.Windows.Forms.Button();
            this.cmbPerfil = new System.Windows.Forms.ComboBox();
            this.txMail = new System.Windows.Forms.TextBox();
            this.txClave = new System.Windows.Forms.TextBox();
            this.txUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bnCancelar
            // 
            this.bnCancelar.Location = new System.Drawing.Point(192, 219);
            this.bnCancelar.Name = "bnCancelar";
            this.bnCancelar.Size = new System.Drawing.Size(75, 30);
            this.bnCancelar.TabIndex = 19;
            this.bnCancelar.Text = "Cancelar";
            this.bnCancelar.UseVisualStyleBackColor = true;
            this.bnCancelar.Click += new System.EventHandler(this.bnCancelar_Click);
            // 
            // bnAceptar
            // 
            this.bnAceptar.Location = new System.Drawing.Point(15, 219);
            this.bnAceptar.Name = "bnAceptar";
            this.bnAceptar.Size = new System.Drawing.Size(75, 30);
            this.bnAceptar.TabIndex = 18;
            this.bnAceptar.Text = "Aceptar";
            this.bnAceptar.UseVisualStyleBackColor = true;
            this.bnAceptar.Click += new System.EventHandler(this.bnAceptar_Click);
            // 
            // cmbPerfil
            // 
            this.cmbPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPerfil.FormattingEnabled = true;
            this.cmbPerfil.Location = new System.Drawing.Point(15, 164);
            this.cmbPerfil.Name = "cmbPerfil";
            this.cmbPerfil.Size = new System.Drawing.Size(252, 24);
            this.cmbPerfil.TabIndex = 17;
            // 
            // txMail
            // 
            this.txMail.Location = new System.Drawing.Point(15, 119);
            this.txMail.Name = "txMail";
            this.txMail.Size = new System.Drawing.Size(252, 22);
            this.txMail.TabIndex = 16;
            // 
            // txClave
            // 
            this.txClave.Location = new System.Drawing.Point(15, 74);
            this.txClave.Name = "txClave";
            this.txClave.PasswordChar = '*';
            this.txClave.Size = new System.Drawing.Size(252, 22);
            this.txClave.TabIndex = 15;
            // 
            // txUsuario
            // 
            this.txUsuario.Location = new System.Drawing.Point(15, 29);
            this.txUsuario.Name = "txUsuario";
            this.txUsuario.Size = new System.Drawing.Size(252, 22);
            this.txUsuario.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Perfil:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Clave:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre de usuario:";
            // 
            // ModificarUsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 264);
            this.Controls.Add(this.bnCancelar);
            this.Controls.Add(this.bnAceptar);
            this.Controls.Add(this.cmbPerfil);
            this.Controls.Add(this.txMail);
            this.Controls.Add(this.txClave);
            this.Controls.Add(this.txUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModificarUsuarioForm";
            this.Text = "ModificarUsuarioForm";
            this.Load += new System.EventHandler(this.ModificarUsuarioForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnCancelar;
        private System.Windows.Forms.Button bnAceptar;
        private System.Windows.Forms.ComboBox cmbPerfil;
        private System.Windows.Forms.TextBox txMail;
        private System.Windows.Forms.TextBox txClave;
        private System.Windows.Forms.TextBox txUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}