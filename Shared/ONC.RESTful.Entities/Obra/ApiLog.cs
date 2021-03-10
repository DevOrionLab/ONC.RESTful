using System;
using System.ComponentModel.DataAnnotations;

namespace ONC.RESTful.Entities.Obra
{
    public partial class ApiLog : IdentityBase
    {

        public ApiLog()
        {
            this.CreatedBy = "monitor@apilog.com"; 
            
        }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public Guid IdentityId{ get;  set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        [MaxLength(256)]
        public string IdentityName { get; set; }

        [MaxLength(256)]
        public string CreatedBy { get; private set; }

        [MaxLength(256)]
        public string IpAddress { get; set; }

        [MaxLength(256)]
        public string UserAgent { get; set; }

        [MaxLength(500)]
        public string Message { get; set; }
        
        [MaxLength(256)]
        public string HttpReferer { get; set; }

        [MaxLength(256)]
        public string PathAndQuery { get; set; }

    }
}