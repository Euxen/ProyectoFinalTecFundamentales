﻿namespace AdministradorCalificaciones
{
    partial class frmRegMateria
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
            this.txtNombreAsignatura = new System.Windows.Forms.TextBox();
            this.txtCantidadCreditos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistrarAsignatura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de la asignatura";
            // 
            // txtNombreAsignatura
            // 
            this.txtNombreAsignatura.Location = new System.Drawing.Point(195, 85);
            this.txtNombreAsignatura.Name = "txtNombreAsignatura";
            this.txtNombreAsignatura.Size = new System.Drawing.Size(165, 20);
            this.txtNombreAsignatura.TabIndex = 2;
            // 
            // txtCantidadCreditos
            // 
            this.txtCantidadCreditos.Location = new System.Drawing.Point(195, 126);
            this.txtCantidadCreditos.Name = "txtCantidadCreditos";
            this.txtCantidadCreditos.Size = new System.Drawing.Size(165, 20);
            this.txtCantidadCreditos.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cantidad de creditos";
            // 
            // btnRegistrarAsignatura
            // 
            this.btnRegistrarAsignatura.Location = new System.Drawing.Point(115, 201);
            this.btnRegistrarAsignatura.Name = "btnRegistrarAsignatura";
            this.btnRegistrarAsignatura.Size = new System.Drawing.Size(128, 23);
            this.btnRegistrarAsignatura.TabIndex = 6;
            this.btnRegistrarAsignatura.Text = "Registrar asignatura";
            this.btnRegistrarAsignatura.UseVisualStyleBackColor = true;
            this.btnRegistrarAsignatura.Click += new System.EventHandler(this.btnRegistrarAsignatura_Click_1);
            // 
            // frmRegMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 301);
            this.Controls.Add(this.btnRegistrarAsignatura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCantidadCreditos);
            this.Controls.Add(this.txtNombreAsignatura);
            this.Controls.Add(this.label1);
            this.Name = "frmRegMateria";
            this.Text = "frmRegMateria";
            this.Load += new System.EventHandler(this.frmRegMateria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreAsignatura;
        private System.Windows.Forms.TextBox txtCantidadCreditos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegistrarAsignatura;
    }
}