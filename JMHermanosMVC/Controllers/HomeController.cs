using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JMHermanosMVC.Controllers
{
    public class HomeController : Controller
    {
        private string renderNuestrosTrabajosView(string viewName)
        {
            return "~/Views/Home/Trabajos/" + viewName + ".cshtml";
        }
        
        // Navigation ========================================================
        // Home
        public ActionResult Index()
        {
            return View();
        }

        // Trabajos
        public ActionResult Trabajos()
        {
            return View();
        }

        // Tu presupuesto
        public ActionResult TuPresupuesto()
        {
            return View();
        }

        // Contacto
        public ActionResult Contact()
        {
            return View();
        }

        // Conocenos
        public ActionResult Conocenos()
        {
            return View();
        }


        // Nuestros trabajos / Trabajos ========================================================
        // Baño
        public ActionResult Baño()
        {
            return View(renderNuestrosTrabajosView("Baño"));
        }

        // Interiores
        public ActionResult Interiores()
        {
            return View(renderNuestrosTrabajosView("Interiores"));
        }

        // Fachada
        public ActionResult Fachada()
        {
            return View(renderNuestrosTrabajosView("Fachada"));
        }

        // Parcela
        public ActionResult Parcela()
        {
            return View(renderNuestrosTrabajosView("Parcela"));
        }

        // Cocina
        public ActionResult Cocina()
        {
            return View(renderNuestrosTrabajosView("Cocina"));
        }

        // Detalles
        public ActionResult Detalles()
        {
            return View(renderNuestrosTrabajosView("Detalles"));
        }
    }
}