using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    class Persona
    {
        private int id;
        private int edad;
        private string nombre;
        private string nacionalidad;

        public Persona(int id, int edad, string nombre, string nacionalidad)
        {
            this.id = id;
            this.edad = edad;
            this.nombre = nombre;
            this.nacionalidad = nacionalidad;
        }

        protected int Id { get => id; set => id = value; }
        protected int Edad { get => edad; set => edad = value; }
        protected string Nombre { get => nombre; set => nombre = value; }
        protected string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
    }
}
