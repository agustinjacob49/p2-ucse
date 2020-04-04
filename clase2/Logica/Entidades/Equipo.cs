using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    class Equipo
    {
        List<Jugador> jugadores;
        List<CuerpoTecnico> cuerpoTecnico;

        public Equipo(List<Jugador> jugadores, List<CuerpoTecnico> cuerpoTecnico)
        {
            this.jugadores = jugadores;
            this.cuerpoTecnico = cuerpoTecnico;
        }

        public List<Jugador> Jugadores { get => jugadores; }
        public List<CuerpoTecnico> CuerpoTecnico { get => cuerpoTecnico; }
    }
}
