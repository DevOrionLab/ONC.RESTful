using System.ComponentModel;
using System.Net;

namespace ONC.RESTful.Entities
{
    public partial class ApiResult
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName(displayName: "Transaction Id")]
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public HttpStatusCode Code { get; set; }
    }
}