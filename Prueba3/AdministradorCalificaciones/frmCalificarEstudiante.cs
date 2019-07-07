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
    public partial class frmCalificarEstudiante : Form
    {
        public frmCalificarEstudiante()
        {
            InitializeComponent();
            //Buscar los estudiantes de la lista
            List<Estudiantes> listaDeID = new List<Estudiantes>();
            StreamReader fileR = new StreamReader(@"estudiantes.txt");//LEER File
            string lineOfContents = fileR.ReadLine();
            string[] arrayEst = lineOfContents.Split(';');
            Estudiantes tempObj = new Estudiantes(arrayEst[0], arrayEst[1]);
            listaDeID.Add(tempObj);

            fileR.Close();

            for (int i = listaDeID.Count - 1; i < listaDeID.Count; i++)
            {
                seleccionarEstComboBox1.Items.Add(listaDeID[i].id);//Aparecer en la lista drop-down
            }
        }

        private void seleccionarEstComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string estudiante = seleccionarEstComboBox1.Text;
            
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            double indice = 0;
            string honor = null;
            string calificacion = txtCalificacion.Text;//Los datos del la calificacion

            

            //Calcular las notas
            double vNota = Convert.ToDouble(calificacion);
            if (vNota <= 100 && vNota > 89)
            {
                indice = 4.00;
            }
            if (vNota < 90 && vNota > 84)
            {
                indice = 3.50;
            }
            if (vNota < 85 && vNota > 79)
            {
                indice = 3.00;
            }
            if (vNota < 80 && vNota > 74)
            {
                indice = 2.50;
            }
            if (vNota < 75 && vNota > 69)
            {
                indice = 2.00;
            }
            if (vNota < 70)
            {
                indice = 0;
            }

            if (indice == 4.00)
            {
                honor = "Suma cum laude";
            }
            if (indice == 3.50)
            {
                honor = "Magna cum laude";
            }
            if (indice < 3.50)
            {
                honor = "Sin honor";
            }

            //Obtener estudiante
            string nombreMateria = txtMateria.SelectedText;

            List<Estudiantes> listaEst = new List<Estudiantes>();
            string buscador = string.Empty;//PARA SOSTENER EL ID DEL ESTUDIANTE SELECCIONADO

            StreamReader fileR = new StreamReader(@"estudianteslista.txt");//LEER

            while(fileR.Peek() >= 0)//PASAR A LISTA DE OBJETO. NOSE LEE BIEN ARREGL
            {
                string lineNormal;
                string[] palabrasLine;

                lineNormal = fileR.ReadLine();
                palabrasLine = lineNormal.Split(';');

                string IdEst, NombreEst, CarreraEst;
                buscador = palabrasLine[0];//Obtener Id para usos mas abajo
                IdEst = palabrasLine[0];
                NombreEst = palabrasLine[1];
                CarreraEst = palabrasLine[2];
                listaEst.Add(new Estudiantes(IdEst, NombreEst, CarreraEst));//Agregar un objeto a la lista
            }

            foreach (Estudiantes element in listaEst)//BUSCAR EL ESTUDIANTE
            {
                for (int i = listaEst.Count - 1; i >= 0; i--)
                {
                    if ( listaEst[i].id == buscador )
                    {
                        listaEst[i].indice = indice;//Agregar indice
                        listaEst[i].honores = honor;//Agregar honores
                        listaEst[i].listaMateriaEst.Add(new Materia(nombreMateria, vNota));//Agregar dicha materia a la lista del estudiante

                    }
                }
            }

            for (int i = listaEst.Count - 1; i >= 0; i--)
            {
                while(listaEst[i] != null)
                {
                    string informacionPersonal = listaEst[i].id + ";" + listaEst[i].nombre + ";" + listaEst[i].carrera + ";" + listaEst[i].listaMateriaEst.ToArray()  + ";" + listaEst[i].calificacion + ";" + listaEst[i].indice + ";" + listaEst[i].honores + "\n";
                    string dirUnico = listaEst[i].id + ".txt";
                    File.AppendAllText(dirUnico, informacionPersonal);
                    break;
                }
            }


            //string[] linesFromTextFile = File.ReadAllLines("estudianteslista.txt");
            //linesFromTextFile[seleccionarEstComboBox1.SelectedIndex] = line + calificacion + ";" + indice.ToString() + ";" + Honor;
            //File.WriteAllLines("estudianteslista.txt", linesFromTextFile);
            seleccionarEstComboBox1.Text = "";
            txtMateria.Text = "";
            txtCalificacion.Text = "";
            

            MessageBox.Show("¡Estudiante calificado!");
        }

        private void txtMateria_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCalificarEstudiante_Load(object sender, EventArgs e)
        {

        }
    }
}
