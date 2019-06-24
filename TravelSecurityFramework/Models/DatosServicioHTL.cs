﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelSecurityFramework.Models
{
    public class DatosServicioHTL
    {
        //public int Id { get; set; }
        //public string IdServicio { get; set; }
        public string CodigoServicio { get; set; }
        public string CodigoOperador { get; set; }
        public string NombreServicio { get; set; }
        public string TipoAcomodacion { get; set; }
        public string TipoHabitacion { get; set; }
        public double ValorVenta { get; set; }
        public string Moneda { get; set; }
        public string FechaInicio { get; set; }
        public string FechaTermino { get; set; }
        public int CantidadPasajeros { get; set; }
        public int Linea { get; set; }
    }
}