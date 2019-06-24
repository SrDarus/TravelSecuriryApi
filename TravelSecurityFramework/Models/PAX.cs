using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelSecurityFramework.Models
{
    public class PAX
    {
        //public int Id { get; set; }
        //public string IdServicio { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Documento { get; set; }
        public int Edad { get; set; }
        public string Nacionalidad { get; set; }
        public string Observacion { get; set; }
    }
}