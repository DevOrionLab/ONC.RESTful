using Newtonsoft.Json;
using ONC.RESTful.Entities.Obra;
using ONC.RESTful.UI.Process;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace ONC.RESTful.UI.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //var p = new ObraProcess();
            //dynamic data = p.GetFrenteObraByEstadoAndNumero(3, "81-0001-FDO18");

            //string jsonString = JsonConvert.SerializeObject(data);
            //JavaScriptSerializer jss = new JavaScriptSerializer();
            //var result = jss.Deserialize<dynamic>(jsonString);

            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult List()
        {
            var op = new ObraProcess();
            var result = op.GetObjectFrenteObraByEstadoAndNumero(3, "81-0001-FDO18");
            var list = new List<FdoNumero>() { result };
            return View(list);
        }
    }
}