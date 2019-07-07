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
    public partial class frmRegistrarEstudiante : Form
    {
        public frmRegistrarEstudiante()
        {
            InitializeComponent();
            string[] lectorLineas = File.ReadAllLines("Materias.txt");
            foreach (var line in lectorLineas)
            {
                string[] elemento = line.Split(':');
                materiaComboBox1.Items.Add(elemento[0]);
            }
        }

        public string materia;

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string nombre = txtNombre.Text;
            string carrera = txtCarrera.Text;
            
            materia = materiaComboBox1.Text;

            Estudiantes nuevo = new Estudiantes(id, nombre, carrera);

            if (id == ""  && carrera == "" && nombre == "" && materia == "")
            {
                MessageBox.Show("Por favor, llena todos los campos.");
            }
            else
            {
                if (File.Exists(id))
                {
                    MessageBox.Show("El estudiante ya está registrado.");
                }
                else
                {
                    MessageBox.Show("¡Estudiante registrado!");
                    
                    //Guardar datos en text files
                    //Guardar txt con id y nombre
                    string IdYNombre = "" + nuevo.id + ";" + nuevo.nombre + Environment.NewLine;
                    File.AppendAllText("estudiantes.txt", IdYNombre);

                    //Guardar txt con id, nombre y carrera
                    string IdNombreCarrera = "" + nuevo.id + ";" + nuevo.nombre + ";" + nuevo.carrera + Environment.NewLine;
                    File.AppendAllText("estudianteslista.txt", IdNombreCarrera);

                    //Guardar ID con sus calificaciones personales
                    
                    string IdMasCalificaciones = "" + nuevo.id + ";" + nuevo.nombre + ";" + nuevo.carrera + ";" + nuevo.listaMateriaEst + Environment.NewLine;
                    string dirUnico = nuevo.id + ".txt";
                    File.AppendAllText(dirUnico, IdMasCalificaciones);
                    
                    //Limpiar todo despues de hacer todo
                    txtCarrera.Text = String.Empty;
                    txtId.Text = String.Empty;
                    txtNombre.Text = String.Empty;
                    materiaComboBox1.Text = String.Empty;
                   
                }
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmRegistrarEstudiante_Load(object sender, EventArgs e)
        {

        }
    }
}
