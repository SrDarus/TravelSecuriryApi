using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelSecurityFramework.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Proveedor { get; set; }
        public string OcTravel { get; set; }
        public string FacturaComision { get; set; }
        public string NumConfirmacion { get; set; }
        public string FechaSolicitud { get; set; }
        public string PasajeroTitular { get; set; }
        public double TotalVenta { get; set; }
        public double TotalNeto { get; set; }
        public double TotalFactura { get; set; }
        public double ValorComision { get; set; }
        public double TotalComision { get; set; }
        public string Moneda{ get; set; }
        public double TipoCambio { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public string Iata { get; set; }
        public string InfoServicio { get; set; }
        public string Observacion { get; set; }
        public int Procesado { get; set; }
        public string FechaProceso { get; set; }
        public string Respuesta { get; set; }


    }
}