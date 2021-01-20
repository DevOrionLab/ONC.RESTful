using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ONC.RESTful.Framework.Logging;

namespace ONC.RESTful.UI.Web.Models
{
    public class ListLogViewModel
    {
        public IList<LogEntry> LogFiles { get; set; }
    }
}