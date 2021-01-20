using ONC.RESTful.Framework.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONC.RESTful.UI.Process
{
    public class DashboardProcess : ProcessComponent
    {
        public List<LogEntry> Get()
        {
            var parameters = new Dictionary<string, object>();
            var response = HttpGet<List<LogEntry>>("/api/dashboard/logs", parameters, MediaType.Json);
            return response;
        }
    }
}