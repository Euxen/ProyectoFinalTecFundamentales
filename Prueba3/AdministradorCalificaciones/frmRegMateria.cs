using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AdministradorCalificaciones
{
    public partial class frmRegMateria : Form
    {
        public frmRegMateria()
        {
            InitializeComponent();
        }

       

        private void frmRegMateria_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrarAsignatura_Click_1(object sender, EventArgs e)
        {
            string materia = txtNombreAsignatura.Text;
            string creditos = txtCantidadCreditos.Text;
            

            if (txtNombreAsignatura.Text.Trim() == "" && txtCantidadCreditos.Text.Trim() == "")
            {
                MessageBox.Show("Por favor, llena todos los campos.");
            }
            else
            {
                txtNombreAsignatura.Text = String.Empty;
                txtCantidadCreditos.Text = String.Empty;
                MessageBox.Show("¡Materia registrada!");
                StreamWriter archivo = File.AppendText("Materias.txt");
                archivo.WriteLine(materia + ":" + creditos);
                archivo.Close();
            }
        }
    }
}
