using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Cors;

namespace TravelSecurityFramework
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de API web

            // Rutas de API web
            config.MapHttpAttributeRoutes();

            //Agregamos el formato de rutas con action
            config.Routes.MapHttpRoute(
                name: "Action",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            /*AGREGAMOS CONFIGURACION ADICIONAL*/

            //Habilitamos la los atributos para core permita la comunicacion cruzada
            //Es necesario installar microsoft.aspNet.webApi.cors desde
            //herramientas > Administrador de paquetes NuGet > administrar paquetes nuGet para la solucion
            var cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);

            //Removemos el tipo de dato que retorna (xml)
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            //Agregamos el tipo de dato que retorna (json)
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new
                MediaTypeHeaderValue("application/json"));


        }
    }
}
