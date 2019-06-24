using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelSecurityFramework.Models
{
    public class RelacionServPax
    {
        //public int Id { get; set; }
        //public int IdServicio { get; set; }
        public int Linea { get; set; }
        public string Documento { get; set; }
        public int NroHabitacion { get; set; }
        public int Posicion { get; set; }
    }
}