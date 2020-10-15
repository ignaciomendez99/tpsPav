using System;

namespace TPS_PAV
{
    partial class LoginForm
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
            this.bnIngresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txUsuario = new System.Windows.Forms.TextBox();
            this.txClave = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bnIngresar
            // 
            this.bnIngresar.Location = new System.Drawing.Point(211, 129);
            this.bnIngresar.Margin = new System.Windows.Forms.Padding(4);
            this.bnIngresar.Name = "bnIngresar";
            this.bnIngresar.Size = new System.Drawing.Size(100, 28);
            this.bnIngresar.TabIndex = 0;
            this.bnIngresar.Text = "Ingresar";
            this.bnIngresar.UseVisualStyleBackColor = true;
            this.bnIngresar.Click += new System.EventHandler(this.bnIngresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // txUsuario
            // 
            this.txUsuario.Location = new System.Drawing.Point(107, 37);
            this.txUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txUsuario.Name = "txUsuario";
            this.txUsuario.Size = new System.Drawing.Size(204, 22);
            this.txUsuario.TabIndex = 3;
            // 
            // txClave
            // 
            this.txClave.Location = new System.Drawing.Point(107, 83);
            this.txClave.Margin = new System.Windows.Forms.Padding(4);
            this.txClave.Name = "txClave";
            this.txClave.PasswordChar = '*';
            this.txClave.Size = new System.Drawing.Size(204, 22);
            this.txClave.TabIndex = 4;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 170);
            this.Controls.Add(this.txClave);
            this.Controls.Add(this.txUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bnIngresar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnIngresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txUsuario;
        private System.Windows.Forms.TextBox txClave;
    }
}

