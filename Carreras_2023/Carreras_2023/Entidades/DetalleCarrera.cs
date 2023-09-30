using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carreras_2023.Entidades
{
    internal class DetalleCarrera
    {
        public int AñoCursado { get; set; }
        public int Cuatrimestre { get; set; }
        public Asignatura Asignatura { get; set; }

        public DetalleCarrera(int añoCursado, int cuatrimestre, Asignatura asignatura)
        {
            AñoCursado = añoCursado;
            Cuatrimestre = cuatrimestre;
            Asignatura = asignatura;
        }
    }
}
