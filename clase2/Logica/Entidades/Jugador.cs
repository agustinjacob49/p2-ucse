using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    class Jugador : Persona
    {
        private int dorsal;
        private bool esTitular;
        private int idEquipo;

        public Jugador(int id, int edad, string nombre, string nacionalidad, int dorsal, bool esTitular, int idEquipo) 
            : base(id, edad, nombre, nacionalidad)
        {
            this.dorsal = dorsal;
            this.esTitular = esTitular;
            this.idEquipo = idEquipo;
        }

    }
}
