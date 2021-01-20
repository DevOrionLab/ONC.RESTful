using ONC.RESTful.Framework.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ONC.RESTful.UI.Process;
using ONC.RESTful.UI.Web.Models;

namespace ONC.RESTful.UI.Web.Controllers
{
    public class DashboardController : Controller
    {
        public ActionResult Index()
        {
            var dp = new DashboardProcess();
            IList<LogEntry> logs = new List<LogEntry>();
            try
            {
                logs = dp.Get();
            }
            catch (Exception ex)
            {
                var err = $"No se puede acceder a los registros: {ex.Message}";
            }
            return View(new ListLogViewModel { LogFiles = logs });
        }

        public ActionResult ClearLog()
        {
            return RedirectToAction("Index");
        }
    }
}