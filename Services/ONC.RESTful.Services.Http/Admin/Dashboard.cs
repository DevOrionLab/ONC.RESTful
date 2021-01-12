//====================================================================================================
// HTTP Service Controller - Dashboard
// ONC.RESTful.WebServices
//
// Generado por vcontreras on 12/01/2021
//====================================================================================================

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ONC.RESTful.Business.Obra;
using ONC.RESTful.Framework.Logging;
using ONC.RESTful.Services.Http.Utils;

namespace ONC.RESTful.Services.Http
{
    /// <summary>
    /// 
    /// </summary>
    [Authorize(Roles = "Administrator")]
    [RoutePrefix("api/dashboard")]
    public class DashboardService : ApiController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("logs")]
        [ResponseType(typeof(IList<LogEntry>))]
        public HttpResponseMessage GetLogs()
        {
            IList<LogEntry> logs = new List<LogEntry>();
            try
            {
                logs = LoggingService.Instance.ListLogFile();
            }
            catch (Exception ex)
            {
                var err = $"No se puede acceder a los registros: {ex.Message}";
                LoggingService.Instance.Error(err);
            }
            return logs == null
                ? Request.CreateErrorResponse(HttpStatusCode.NotFound, "Logs not found")
                : Request.CreateResponse(HttpStatusCode.OK, logs);

        }
    }
}
