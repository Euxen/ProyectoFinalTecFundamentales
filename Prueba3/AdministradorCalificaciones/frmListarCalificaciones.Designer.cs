namespace AdministradorCalificaciones
{
    partial class frmListarCalificaciones
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Indice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Honor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListarCalificaciones = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Carrera,
            this.Materia,
            this.Calificacion,
            this.Indice,
            this.Honor});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(799, 293);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Carrera
            // 
            this.Carrera.HeaderText = "Carrera";
            this.Carrera.Name = "Carrera";
            // 
            // Materia
            // 
            this.Materia.HeaderText = "Materia";
            this.Materia.Name = "Materia";
            // 
            // Calificacion
            // 
            this.Calificacion.HeaderText = "Calificacíon";
            this.Calificacion.Name = "Calificacion";
            // 
            // Indice
            // 
            this.Indice.HeaderText = "Indice";
            this.Indice.Name = "Indice";
            // 
            // Honor
            // 
            this.Honor.HeaderText = "Honor";
            this.Honor.Name = "Honor";
            // 
            // btnListarCalificaciones
            // 
            this.btnListarCalificaciones.Location = new System.Drawing.Point(314, 329);
            this.btnListarCalificaciones.Name = "btnListarCalificaciones";
            this.btnListarCalificaciones.Size = new System.Drawing.Size(119, 23);
            this.btnListarCalificaciones.TabIndex = 1;
            this.btnListarCalificaciones.Text = "Listar Calificaciones";
            this.btnListarCalificaciones.UseVisualStyleBackColor = true;
            this.btnListarCalificaciones.Click += new System.EventHandler(this.btnListarCalificaciones_Click);
            // 
            // frmListarCalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListarCalificaciones);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmListarCalificaciones";
            this.Text = "frmListarCalificaciones";
            this.Load += new System.EventHandler(this.frmListarCalificaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Indice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Honor;
        private System.Windows.Forms.Button btnListarCalificaciones;


    }
}