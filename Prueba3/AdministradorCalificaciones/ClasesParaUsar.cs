using System;
using System.Collections.Generic;

namespace AdministradorCalificaciones
{
    public class Estudiantes
    {

        public List<Materia> listaMateriaEst = new List<Materia>();

        private string ID;
        public string id
        {
            get { return ID; }
            set { ID = value; }
        }

        private string Nombre;
        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        private string Carrera;
        public string carrera
        {
            get { return Carrera; }
            set { Carrera = value; }
        }

        private decimal Calificacion;
        public decimal calificacion
        {
            get { return Calificacion; }
            set { Calificacion = value; }
        }

        private double Indice;
        public double indice
        {
            get { return Indice; }
            set { Indice = value; }
        }

        private string Honores;
        public string honores
        {
            get { return Honores; }
            set { Honores = value; }
        }

        private int Credito;
    	public int credito
	    {
		    get { return Credito;}
		    set { Credito = value;}
	    }


        public Estudiantes() { }

        public Estudiantes(string IDPer, string NombrePer)
        {
            this.id = IDPer;
            this.nombre = NombrePer;
        }

        public Estudiantes(string IDPer, string NombrePer, string CarreraPer)
        {
            this.ID = IDPer;
            this.Nombre = NombrePer;
            this.Carrera = CarreraPer;
        }
        
        public void agregarCreditos(int creditoMateria)
        {
            int resultado = this.Credito + creditoMateria;

            if (resultado < 22)
            {
                this.Credito = resultado;
            }
            else
            {
                Console.WriteLine("Has sobrepasado el limite de creditos");
            }   
                
        }

    }

    public class Materia
    {
        private string Nombre;

        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        private double NotaMateria;

        public double notaMateria
        {
            get { return NotaMateria; }
            set { NotaMateria = value; }
        }

        public Materia() { }

        public Materia(string nombreMateria, double notaMateria)
        {
            this.Nombre = nombreMateria;
            this.NotaMateria = notaMateria;
        }


    }
}

