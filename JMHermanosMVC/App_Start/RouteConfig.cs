using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Resources;

namespace JMHermanosMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Home
            routes.MapRoute(
                name: "Home",
                url: Resources.Routes.urlHome,
                defaults: new { controller = "Home", action = "Index" }
            );

            // Nuestros Trabajos
            routes.MapRoute(
                name: "NuestrosTrabajos",
                url: Resources.Routes.urlTrabajos,
                defaults: new { controller = "Home", action = "Trabajos"}
            );

            // Contacto
            routes.MapRoute(
                name: "Contacto",
                url: Resources.Routes.urlContacto,
                defaults: new { controller = "Home", action = "Contact" }
            );

            // Tu presupuesto
            routes.MapRoute(
                name: "TuPresupuesto",
                url: Resources.Routes.urlPresupuesto,
                defaults: new { controller = "Home", action = "TuPresupuesto" }
            );

            // Conocenos
            routes.MapRoute(
                name: "Conocenos",
                url: Resources.Routes.urlConocenos,
                defaults: new { controller = "Home", action = "Conocenos" }
            );

            // Nuestros Trabajos ==============================================================

            // Nuestros Trabajos - Baño
            routes.MapRoute(
                name: "Baño",
                url: Resources.Routes.urlTrabajos + "/" + Resources.Routes.urlBaño,
                defaults: new { controller = "Home", action = "Baño" }
            );

            // Nuestros Trabajos - Interiores
            routes.MapRoute(
                name: "Interiores",
                url: Resources.Routes.urlTrabajos + "/" + Resources.Routes.urlInteriores,
                defaults: new { controller = "Home", action = "Interiores" }
            );

            // Nuestros Trabajos - Fachada
            routes.MapRoute(
                name: "Fachada",
                url: Resources.Routes.urlTrabajos + "/" + Resources.Routes.urlFachadas,
                defaults: new { controller = "Home", action = "Fachada" }
            );

            // Nuestros Trabajos - Parcela
            routes.MapRoute(
                name: "Parcela",
                url: Resources.Routes.urlTrabajos + "/" + Resources.Routes.urlParcela,
                defaults: new { controller = "Home", action = "Parcela" }
            );

            // Nuestros Trabajos - Cocina
            routes.MapRoute(
                name: "Cocina",
                url: Resources.Routes.urlTrabajos + "/" + Resources.Routes.urlCocinas,
                defaults: new { controller = "Home", action = "Cocina" }
            );

            // Nuestros Trabajos - Detalles
            routes.MapRoute(
                name: "Detalles",
                url: Resources.Routes.urlTrabajos + "/" + Resources.Routes.urlDetalles,
                defaults: new { controller = "Home", action = "Detalles" }
            );

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);
        }
    }
}
