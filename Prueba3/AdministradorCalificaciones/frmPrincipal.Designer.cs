namespace AdministradorCalificaciones
{
    partial class frmPrincipal
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
            this.txtTituloPrincipal = new System.Windows.Forms.Label();
            this.btnCalificarEstudiante = new System.Windows.Forms.Button();
            this.btnRegistrarEstudiante = new System.Windows.Forms.Button();
            this.btnRegistrarMateria = new System.Windows.Forms.Button();
            this.btnListarCalificaciones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTituloPrincipal
            // 
            this.txtTituloPrincipal.AutoSize = true;
            this.txtTituloPrincipal.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloPrincipal.Location = new System.Drawing.Point(133, 9);
            this.txtTituloPrincipal.Name = "txtTituloPrincipal";
            this.txtTituloPrincipal.Size = new System.Drawing.Size(562, 55);
            this.txtTituloPrincipal.TabIndex = 0;
            this.txtTituloPrincipal.Text = "Manejador de Calificaciones";
            // 
            // btnCalificarEstudiante
            // 
            this.btnCalificarEstudiante.Location = new System.Drawing.Point(332, 223);
            this.btnCalificarEstudiante.Name = "btnCalificarEstudiante";
            this.btnCalificarEstudiante.Size = new System.Drawing.Size(141, 45);
            this.btnCalificarEstudiante.TabIndex = 1;
            this.btnCalificarEstudiante.Text = "Calificar Estudiante";
            this.btnCalificarEstudiante.UseVisualStyleBackColor = true;
            this.btnCalificarEstudiante.Click += new System.EventHandler(this.btnCalificarEstudiante_Click);
            // 
            // btnRegistrarEstudiante
            // 
            this.btnRegistrarEstudiante.Location = new System.Drawing.Point(332, 161);
            this.btnRegistrarEstudiante.Name = "btnRegistrarEstudiante";
            this.btnRegistrarEstudiante.Size = new System.Drawing.Size(141, 45);
            this.btnRegistrarEstudiante.TabIndex = 2;
            this.btnRegistrarEstudiante.Text = "Registrar Estudiante";
            this.btnRegistrarEstudiante.UseVisualStyleBackColor = true;
            this.btnRegistrarEstudiante.Click += new System.EventHandler(this.btnRegistrarEstudiante_Click);
            // 
            // btnRegistrarMateria
            // 
            this.btnRegistrarMateria.Location = new System.Drawing.Point(332, 93);
            this.btnRegistrarMateria.Name = "btnRegistrarMateria";
            this.btnRegistrarMateria.Size = new System.Drawing.Size(141, 45);
            this.btnRegistrarMateria.TabIndex = 3;
            this.btnRegistrarMateria.Text = "Registrar Materia";
            this.btnRegistrarMateria.UseVisualStyleBackColor = true;
            this.btnRegistrarMateria.Click += new System.EventHandler(this.btnRegistrarMateria_Click);
            // 
            // btnListarCalificaciones
            // 
            this.btnListarCalificaciones.Location = new System.Drawing.Point(332, 287);
            this.btnListarCalificaciones.Name = "btnListarCalificaciones";
            this.btnListarCalificaciones.Size = new System.Drawing.Size(141, 45);
            this.btnListarCalificaciones.TabIndex = 4;
            this.btnListarCalificaciones.Text = "Listar Calificaciones";
            this.btnListarCalificaciones.UseVisualStyleBackColor = true;
            this.btnListarCalificaciones.Click += new System.EventHandler(this.btnListarCalificaciones_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListarCalificaciones);
            this.Controls.Add(this.btnRegistrarMateria);
            this.Controls.Add(this.btnRegistrarEstudiante);
            this.Controls.Add(this.btnCalificarEstudiante);
            this.Controls.Add(this.txtTituloPrincipal);
            this.Name = "frmPrincipal";
            this.Text = "Manejador de Calificaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTituloPrincipal;
        private System.Windows.Forms.Button btnCalificarEstudiante;
        private System.Windows.Forms.Button btnRegistrarEstudiante;
        private System.Windows.Forms.Button btnRegistrarMateria;
        private System.Windows.Forms.Button btnListarCalificaciones;
    }
}

