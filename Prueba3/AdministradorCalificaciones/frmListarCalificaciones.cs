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
    public partial class frmListarCalificaciones : Form
    {
        public class _ID
        {
            public static int id = 0;
        }

        public frmListarCalificaciones()
        {
            InitializeComponent();
        }

        private void btnListarCalificaciones_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string IDEstParaGridView;

            try
            {
                //BUSCAR ID DESDE FILE
                StreamReader fileR = new StreamReader(@"estudiantes.txt");//LEER File
                string lineNormal;
                string[] palabrasLine;

                lineNormal = fileR.ReadLine();
                palabrasLine = lineNormal.Split(';');
                IDEstParaGridView = palabrasLine[1];

                fileR.Close();//Cerramos los files que no vamos a usar

                StreamReader streamReader = new StreamReader("estudianteslista.txt");
                string text = "";
                for (text = streamReader.ReadLine(); text != null; text = streamReader.ReadLine())
                {    
                    string[] array = text.Split(new char[] { ';' });
                    dataGridView1.Rows.Add(array);
                }


                dataGridView1.Sort(dataGridView1.Columns[5], ListSortDirection.Descending);
            }
            catch (Exception)
            {
                MessageBox.Show("¡No hay estudiantes registrados!");
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Height = (dataGridView1.ClientRectangle.Height - dataGridView1.ColumnHeadersHeight) / dataGridView1.Rows.Count;
            }
        }

        private void frmListarCalificaciones_Load(object sender, EventArgs e)
        {

        }

        
    }
}
