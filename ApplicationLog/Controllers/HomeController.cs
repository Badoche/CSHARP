using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Read_Write_Logs;

namespace ApplicationLog.Controllers
{
    public class HomeController : Controller
    {
        private object logs;

        public ActionResult Index()
        {
            ViewBag.Message = "Modifiez ce modèle pour dynamiser votre application ASP.NET MVC.";

            return View();
        }

        public ActionResult listLog()
        {
            ViewBag.Message = "Liste des différents logs.";
            logs = new Read_Write_Logs.Lecture();
            return View(logs);
        }

        public ActionResult addLog()
        {
            ViewBag.Message = "Ajout d'un nouveau log.";
            logs = new Read_Write_Logs.Ecriture();
            return View();
        }
    }
}
