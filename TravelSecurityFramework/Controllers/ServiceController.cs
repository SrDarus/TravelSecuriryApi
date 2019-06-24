using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TravelSecurityFramework.Models;

using System.IO;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace TravelSecurityFramework.Controllers
{
    public class ServiceController : ApiController
    {
        //GET api/Service/getServicios
        [HttpGet]
        public IEnumerable<Service> getServicios()
        {

            IList<Service> listConserje = new List<Service>();

            DataSet ds = Conexion.ejecutar_select("Sp_GetServicios_PTS ");
            //DataSet ds = Conexion.ejecutar_select("sp_getConserjes_test ");

            Service service = null;

            if (ds.Tables[0].Rows.Count > 0)
            {
                //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                foreach (DataRow row in ds.Tables[0].Rows)
                {

                    service = new Service();
                    service.Id = Convert.ToInt32(row["Id"]);
                    service.Proveedor = Convert.ToString(row["Proveedor"]);
                    service.OcTravel = Convert.ToString(row["OcTravel"]);
                    service.FacturaComision = Convert.ToString(row["FacturaComision"]);
                    service.NumConfirmacion = Convert.ToString(row["NumConfirmacion"]);
                    service.FechaSolicitud = Convert.ToString(row["FechaSolicitud"]);
                    service.PasajeroTitular = Convert.ToString(row["PasajeroTitular"]);
                    service.TotalVenta = Convert.ToInt32(row["TotalVenta"]);
                    service.TotalNeto = Convert.ToInt32(row["TotalNeto"]);
                    service.TotalFactura = Convert.ToDouble(row["TotalFactura"]);
                    service.ValorComision = Convert.ToDouble(row["ValorComision"]);
                    service.TotalComision = Convert.ToDouble(row["TotalComision"]);
                    service.Moneda = Convert.ToString(row["Moneda"]);
                    service.TipoCambio = Convert.ToDouble(row["TipoCambio"]);
                    service.Pais = Convert.ToString(row["Pais"]);
                    service.Ciudad = Convert.ToString(row["Ciudad"]);
                    service.Iata = Convert.ToString(row["Iata"]);
                    service.InfoServicio = Convert.ToString(row["InfoServicio"]);
                    service.Observacion = Convert.ToString(row["Observacion"]);
                    service.Procesado = Convert.ToInt32(row["Procesado"]);
                    service.FechaProceso = Convert.ToString(row["FechaProceso"]);
                    service.Respuesta = Convert.ToString(row["Respuesta"]);
                    listConserje.Add(service);
                }
            }
            else
            {
                //
            }
            return listConserje;
        }

        //GET api/Service/getServicios
        [HttpGet]
        public IEnumerable<Service> getServiciosTodos()
        {

            IList<Service> listServicios= new List<Service>();

            DataSet ds = Conexion.ejecutar_select("Sp_GetServiciosTodos_PTS ");
            //DataSet ds = Conexion.ejecutar_select("sp_getConserjes_test ");

            Service service = null;

            if (ds.Tables[0].Rows.Count > 0)
            {
                //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                foreach (DataRow row in ds.Tables[0].Rows)
                {

                    service = new Service();
                    service.Id = Convert.ToInt32(row["Id"]);
                    service.Proveedor = Convert.ToString(row["Proveedor"]);
                    service.OcTravel = Convert.ToString(row["OcTravel"]);
                    service.FacturaComision = Convert.ToString(row["FacturaComision"]);
                    service.NumConfirmacion = Convert.ToString(row["NumConfirmacion"]);
                    service.FechaSolicitud = Convert.ToString(row["FechaSolicitud"]);
                    service.PasajeroTitular = Convert.ToString(row["PasajeroTitular"]);
                    service.TotalVenta = Convert.ToInt32(row["TotalVenta"]);
                    service.TotalNeto = Convert.ToInt32(row["TotalNeto"]);
                    service.TotalFactura = Convert.ToDouble(row["TotalFactura"]);
                    service.ValorComision = Convert.ToDouble(row["ValorComision"]);
                    service.TotalComision = Convert.ToDouble(row["TotalComision"]);
                    service.Moneda = Convert.ToString(row["Moneda"]);
                    service.TipoCambio = Convert.ToDouble(row["TipoCambio"]);
                    service.Pais = Convert.ToString(row["Pais"]);
                    service.Ciudad = Convert.ToString(row["Ciudad"]);
                    service.Iata = Convert.ToString(row["Iata"]);
                    service.InfoServicio = Convert.ToString(row["InfoServicio"]);
                    service.Observacion = Convert.ToString(row["Observacion"]);
                    service.Procesado = Convert.ToInt32(row["Procesado"]);
                    service.FechaProceso = Convert.ToString(row["FechaProceso"]);
                    service.Respuesta = Convert.ToString(row["Respuesta"]);
                    listServicios.Add(service);
                }
            }
            else
            {
                //
            }
            return listServicios;
        }

        public IEnumerable<Service> getServiciosFecha()
        {

            IList<Service> listServicios = new List<Service>();

            DataSet ds = Conexion.ejecutar_select("Sp_GetServiciosFecha_PTS ");
            //DataSet ds = Conexion.ejecutar_select("sp_getConserjes_test ");

            Service service = null;

            if (ds.Tables[0].Rows.Count > 0)
            {
                //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                foreach (DataRow row in ds.Tables[0].Rows)
                {

                    service = new Service();
                    service.Id = Convert.ToInt32(row["Id"]);
                    service.Proveedor = Convert.ToString(row["Proveedor"]);
                    service.OcTravel = Convert.ToString(row["OcTravel"]);
                    service.FacturaComision = Convert.ToString(row["FacturaComision"]);
                    service.NumConfirmacion = Convert.ToString(row["NumConfirmacion"]);
                    service.FechaSolicitud = Convert.ToString(row["FechaSolicitud"]);
                    service.PasajeroTitular = Convert.ToString(row["PasajeroTitular"]);
                    service.TotalVenta = Convert.ToInt32(row["TotalVenta"]);
                    service.TotalNeto = Convert.ToInt32(row["TotalNeto"]);
                    service.TotalFactura = Convert.ToDouble(row["TotalFactura"]);
                    service.ValorComision = Convert.ToDouble(row["ValorComision"]);
                    service.TotalComision = Convert.ToDouble(row["TotalComision"]);
                    service.Moneda = Convert.ToString(row["Moneda"]);
                    service.TipoCambio = Convert.ToDouble(row["TipoCambio"]);
                    service.Pais = Convert.ToString(row["Pais"]);
                    service.Ciudad = Convert.ToString(row["Ciudad"]);
                    service.Iata = Convert.ToString(row["Iata"]);
                    service.InfoServicio = Convert.ToString(row["InfoServicio"]);
                    service.Observacion = Convert.ToString(row["Observacion"]);
                    service.Procesado = Convert.ToInt32(row["Procesado"]);
                    service.FechaProceso = Convert.ToString(row["FechaProceso"]);
                    service.Respuesta = Convert.ToString(row["Respuesta"]);
                    listServicios.Add(service);
                }
            }
            else
            {
                //
            }
            return listServicios;
        }

        //GET /api/Service/getServicioDetalle?rutServicio=78872390-3
        [HttpGet]
        public IEnumerable<Object> getServicioDetalle(String idServicio)
        {
            IList<Object> listDetalle = new List<Object>();

            IList<DatosServicioHTL> hoteles = new List<DatosServicioHTL>();
            IList<DatosServicioTRF> transferes = new List<DatosServicioTRF>();
            IList<DatosServicioOTR> otros = new List<DatosServicioOTR>();
            IList<PAX> pasajeros = new List<PAX>();
            IList<RelacionServPax> relacionPaxList = new List<RelacionServPax>();

            DataSet ds = Conexion.ejecutar_select("Sp_GetServicioDetalle_PTS '" + idServicio + "'");
            //DataSet ds = Conexion.ejecutar_select("sp_getConserjes_test ");

            //if (ds.Tables[0].Rows.Count > 0)
            if (ds.Tables.Count > 0)
            {

                //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                foreach (DataRow row in ds.Tables[0].Rows)
                {

                    DatosServicioHTL hotel = new DatosServicioHTL();
                    //hotel.Id = Convert.ToInt32(row["Id"]);
                    hotel.CodigoServicio = Convert.ToString(row["CodigoServicio"]);
                    //hotel.IdServicio = Convert.ToString(row["IdServicio"]);
                    hotel.NombreServicio = Convert.ToString(row["NombreServicio"]);
                    hotel.TipoAcomodacion = Convert.ToString(row["TipoAcomodacion"]);
                    hotel.TipoHabitacion = Convert.ToString(row["TipoHabitacion"]);
                    hotel.ValorVenta = Convert.ToDouble(row["ValorVenta"]);
                    hotel.Moneda = Convert.ToString(row["Moneda"]);
                    hotel.FechaInicio = Convert.ToString(row["FechaInicio"]);
                    hotel.FechaTermino = Convert.ToString(row["FechaTermino"]);
                    hotel.CantidadPasajeros = Convert.ToInt32(row["CantidadPasajeros"]);
                    hotel.Linea = Convert.ToInt32(row["Linea"]);
                    hotel.CodigoOperador = Convert.ToString(row["CodigoOperador"]);
                    hoteles.Add(hotel);
                }

                foreach (DataRow row in ds.Tables[1].Rows)
                {

                    DatosServicioTRF transfer = new DatosServicioTRF();
                    //transfer.Id = Convert.ToInt32(row["Id"]);
                    //transfer.IdServicio = Convert.ToInt16(row["IdServicio"]);
                    transfer.CodigoServicio = Convert.ToString(row["CodigoServicio"]);
                    transfer.NombreServicio = Convert.ToString(row["NombreServicio"]);
                    transfer.DetalleTraslado = Convert.ToString(row["DetalleTraslado"]);
                    transfer.NumeroVuelo = Convert.ToString(row["NumeroVuelo"]);
                    transfer.ValorVenta = Convert.ToDouble(row["ValorVenta"]);
                    transfer.Moneda = Convert.ToString(row["Moneda"]);
                    transfer.FechaTraslado = Convert.ToString(row["FechaTraslado"]);
                    transfer.CantidadPasajeros = Convert.ToInt16(row["CantidadPasajeros"]);
                    transfer.Linea = Convert.ToInt32(row["Linea"]);
                    transfer.CodigoOperador = Convert.ToString(row["CodigoOperador"]);
                    transferes.Add(transfer);
                }

                foreach (DataRow row in ds.Tables[2].Rows)
                {

                    DatosServicioOTR otro = new DatosServicioOTR();
                    //otro.Id = Convert.ToInt32(row["Id"]);
                    otro.CodigoServicio = Convert.ToString(row["CodigoServicio"]);
                    //otro.IdServicio = Convert.ToString(row["IdServicio"]);
                    otro.NombreServicio = Convert.ToString(row["NombreServicio"]);
                    otro.TipoOtrosServicios = Convert.ToString(row["TipoOtrosServicios"]);
                    otro.DetalleOtroServicios = Convert.ToString(row["DetalleOtroServicios"]);
                    otro.ValorVenta = Convert.ToDouble(row["ValorVenta"]);
                    otro.Moneda = Convert.ToString(row["Moneda"]);
                    otro.FechaInicio = Convert.ToString(row["FechaInicio"]);
                    otro.FechaTermino = Convert.ToString(row["FechaTermino"]);
                    otro.CantidadPasajeros = Convert.ToInt32(row["CantidadPasajeros"]);
                    otro.Linea = Convert.ToInt32(row["Linea"]);
                    otro.CodigoOperador = Convert.ToString(row["CodigoOperador"]);
                    otros.Add(otro);
                }
                foreach (DataRow row in ds.Tables[3].Rows)
                {

                    PAX pasajero = new PAX();
                    //pasajero.Id = Convert.ToInt32(row["Id"]);
                    //pasajero.IdServicio = Convert.ToString(row["IdServicio"]);
                    pasajero.Nombre = Convert.ToString(row["Nombre"]);
                    pasajero.Apellido = Convert.ToString(row["Apellido"]);
                    pasajero.Documento = Convert.ToString(row["Documento"]);
                    pasajero.Edad = Convert.ToInt32(row["Edad"]);
                    pasajero.Nacionalidad = Convert.ToString(row["Nacionalidad"]);
                    pasajero.Observacion = Convert.ToString(row["Observacion"]);
                    pasajeros.Add(pasajero);
                }
                foreach (DataRow row in ds.Tables[4].Rows)
                {

                    RelacionServPax relacionPax = new RelacionServPax();
                    //relacionPax.Id = Convert.ToInt32(row["Id"]);
                    //relacionPax.IdServicio = Convert.ToInt32(row["IdServicio"]);
                    relacionPax.Linea = Convert.ToInt32(row["Linea"]);
                    relacionPax.Documento = Convert.ToString(row["Documento"]);
                    relacionPax.NroHabitacion = Convert.ToInt32(row["NroHabitacion"]);
                    relacionPax.Posicion = Convert.ToInt32(row["Posicion"]);
                    relacionPaxList.Add(relacionPax);
                }

            }
            else
            {
                //
            }
            listDetalle.Add(hoteles);
            listDetalle.Add(transferes);
            listDetalle.Add(otros);
            listDetalle.Add(pasajeros);
            listDetalle.Add(relacionPaxList);
            return listDetalle;
        }

        // GET api/Conserjes/enviarSererva
        [HttpPost]
        public string procesarServicio([FromBody]JObject post)
        {
            var request = (HttpWebRequest)WebRequest.Create("http://www.travelsecurity.cl/DesktopModules/Genericos/API/Genericos/GenerarNegocio");

            String json = post["data"].ToString();
            String id = post["id"].ToString();
            
            dynamic dataJson = JObject.Parse(json);

            string OcTravel = dataJson.OcTravel;
            string Respuesta = dataJson.Respuesta;
            //request

            var data = Encoding.ASCII.GetBytes(json);

            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = data.Length;
            String username = "Operador_Adsmundo";
            String password = "+Ads__TS%~";
            //String username = "OperadoresTS";
            //String password = "~OP19_%++TS%";
            string credentials = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + credentials);
            try
            {
                using (var stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }

                var response = (HttpWebResponse)request.GetResponse();

                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                responseString = responseString.Replace("\"","");   
                var _estado = 0;
                var responseSub = responseString.Substring(0, 16);

                if (responseSub == "Negocio Generado")
                {
                    _estado = 1;
                }
                else {
                    _estado = 2;
                }

                DataSet ds = Conexion.ejecutar_select("Sp_ProcesarServicio_PTS '" + id + "', '" + responseString + "','"+ json +"',"+_estado+", '"+OcTravel+"'" );
                //DataSet ds = Conexion.ejecutar_select("sp_getConserjes_test ");
                //if (ds.Tables[0].Rows.Count > 0) { }

                string resp = JsonConvert.SerializeObject(new
                    { estado = _estado, mensaje = responseString.Replace("\"", "") }
                );
                return resp;
            }
            catch (Exception e)
            {
                string resp = JsonConvert.SerializeObject(new
                { estado = 3, mensaje = e.Message}
                );
                return resp;
            }

        }

        [HttpPost]
        public string reversarProcesado([FromBody]JObject post)
        {
            string id = post["id"].ToString();
            try
            {
                DataSet ds = Conexion.ejecutar_select("Sp_ReversarProcesado_PTS " + id);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    int estado= Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                    string respuesta;
                    if (estado == 0)
                    {
                        respuesta = "Revertido Correctamente";
                    }
                    else {
                        respuesta = "Problemas al revertir";
                    }
                    string resp = JsonConvert.SerializeObject(new
                        { estado = estado, mensaje = respuesta }
                    );
                    return resp;
                }
                else
                {
                    string resp = JsonConvert.SerializeObject(new
                    { estado = 1, mensaje = "No se Revertir" }
                    );
                    return resp;
                }
            }
            catch (Exception ex)
            {
                string resp = JsonConvert.SerializeObject(new
                { estado = 1, mensaje = ex }
                    );
                return resp;
            }


        }   

        [HttpPost]
        public string reversarProcesadoo([FromBody]JObject post)
        {

            String json = post["data"].ToString();

            dynamic data = JObject.Parse(json);

            var Id = data.Id;
            var OcTravel = data.OcTravel;
            var Respuesta = data.Respuesta;
            try
            {
                DataSet ds = Conexion.ejecutar_select("Sp_ReversarProcesado_PTS '" + OcTravel + "','" + Respuesta + "','" + json + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    int estado = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                    string respuesta;
                    if (estado == 0)
                    {
                        respuesta = "Registrado Correctamente";
                    }
                    else
                    {
                        respuesta = "Problemas al registrar";
                    }
                    string resp = JsonConvert.SerializeObject(new
                    { estado = estado, mensaje = respuesta }
                    );
                    return resp;
                }
                else
                {
                    string resp = JsonConvert.SerializeObject(new
                    { estado = 1, mensaje = "No se pudo registrar" }
                    );
                    return resp;
                }
            }
            catch (Exception ex)
            {
                string resp = JsonConvert.SerializeObject(new
                { estado = 1, mensaje = ex }
                    );
                return resp;
            }


        }

        //api/Service/downloadFile2?fileName=test
        [HttpPost]
        public int uploadFile(string fileName, string json)
        {
            //fileName = @"C:\Temp\Mahesh.txt";

            try
            {

                string path = System.Web.HttpContext.Current.Server.MapPath("/");
                //or 
                //string path2 = System.Web.HttpContext.Current.Server.MapPath("~");
                // Check if file already exists. If yes, delete it.    
                string ruta = path + "\\log\\" + fileName;
                if (File.Exists(ruta))
                {
                    ruta = ruta +"//"+ System.DateTime.Now.ToString("yyyy.MM.dd");
                    File.Delete(ruta);
                }

                // Create a new file     
                using (FileStream fs = File.Create(ruta))
                {
                    // Add some text to file    
                    Byte[] title = new UTF8Encoding(true).GetBytes(json);
                    fs.Write(title, 0, title.Length);
                    //byte[] author = new UTF8Encoding(true).GetBytes("Mahesh Chand");
                    //fs.Write(author, 0, author.Length);
                }

                // Open the stream and read it back.    
                using (StreamReader sr = File.OpenText(ruta))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
                return 1;
            }
            return 0;
        }
    }
}
