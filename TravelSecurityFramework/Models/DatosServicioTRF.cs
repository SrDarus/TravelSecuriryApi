using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelSecurityFramework.Models
{
    public class DatosServicioTRF
    {
        //public int Id { get; set; }
        //public int IdServicio { get; set; }
        public string CodigoServicio { get; set; }
        public string CodigoOperador { get; set; }
        public string NombreServicio { get; set; }
        public string DetalleTraslado { get; set; }
        public string NumeroVuelo { get; set; }
        public double ValorVenta { get; set; }
        public string Moneda { get; set; }
        public string FechaTraslado { get; set; }
        public int CantidadPasajeros { get; set; }
        public int Linea { get; set; }
    }
}