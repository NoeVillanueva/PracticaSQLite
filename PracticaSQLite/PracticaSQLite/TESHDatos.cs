using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace PracticaSQLite
{
    public class TESHDatos
    {
        string matricula;
        string nombre;
        string apellidos;
        string direccion;
        string telefono;
        string carrera;
        string semestre;
        string correo;
        string github;

        [PrimaryKey, Unique, MaxLength(10) ]

        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        [MaxLength(40)]

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        [MaxLength(40)]

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        [MaxLength (40)]

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        [MaxLength(15)]

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        [MaxLength(50)]

        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }

        [MaxLength(30)]

        public string Semestre
        {
            get { return semestre; }
            set { semestre = value; }
        }

        [MaxLength(50)]

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        [MaxLength(50)]

        public string Github
        {
            get { return github; }
            set { github = value; }
        }
    }
}
