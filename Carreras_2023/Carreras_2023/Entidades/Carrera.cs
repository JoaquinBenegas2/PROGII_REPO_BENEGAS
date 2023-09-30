﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carreras_2023.Entidades
{
    internal class Carrera
    {
        public int IdCarrera { get; set; }
        public string NomCarrera { get; set; }
        public List<DetalleCarrera> ListaDetalles { get; set; }

        public Carrera()
        {
            ListaDetalles = new List<DetalleCarrera>();
        }
        public Carrera(int idCarrera, string nomCarrera)
        {
            IdCarrera = idCarrera;
            NomCarrera = nomCarrera;
            ListaDetalles = new List<DetalleCarrera>();
        }

        public void AgregarDetalle(DetalleCarrera detalleCarrera)
        {
            ListaDetalles.Add(detalleCarrera);
        }

        public void QuitarDetalle(int indice) {
            ListaDetalles.RemoveAt(indice);
        }
    }
}
