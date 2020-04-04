using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    class CuerpoTecnico : Persona
    {
        private bool esTecnicoPrincipal;
        private int numeroAyudanteCampo;

        public CuerpoTecnico(int id, int edad, string nombre, string nacionalidad) : base(id, edad, nombre, nacionalidad)
        {
        }

        public bool EsTecnicoPrincipal { get => esTecnicoPrincipal; set => esTecnicoPrincipal = value; }
        public int NumeroAyudanteCampo { get => numeroAyudanteCampo; set => numeroAyudanteCampo = value; }
    }
}
