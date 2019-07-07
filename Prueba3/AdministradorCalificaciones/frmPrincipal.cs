using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministradorCalificaciones
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalificarEstudiante_Click(object sender, EventArgs e)
        {
            Form calificarEstudiante = new frmCalificarEstudiante();
            calificarEstudiante.Show();
        }

        private void btnRegistrarMateria_Click(object sender, EventArgs e)
        {
            Form registrarMateria = new frmRegMateria();
            registrarMateria.Show();
        }

        private void btnRegistrarEstudiante_Click(object sender, EventArgs e)
        {
            Form registrarEstudiante = new frmRegistrarEstudiante();
            registrarEstudiante.Show();
        }

        private void btnListarCalificaciones_Click(object sender, EventArgs e)
        {
            Form listarCalificaciones = new frmListarCalificaciones();
            listarCalificaciones.Show();
        }
    }
}
