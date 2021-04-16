using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using ONC.RESTful.Business;
using ONC.RESTful.Entities;
using ONC.RESTful.Services.Contracts.Requests;
using ONC.RESTful.Services.Http.Security;
using ONC.RESTful.Services.Http.Utils;

namespace ONC.RESTful.Services.Http
{

    /// <summary>
    /// 
    /// </summary>
    [AllowAnonymous]
    [RoutePrefix("api/login")]
    public class LoginService : ApiController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("ping")]
        internal IHttpActionResult Ping()
        {
            return Ok(true);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("echouser")]
        public IHttpActionResult EchoUser()
        {
            var identity = Thread.CurrentPrincipal.Identity;
            return Ok($" IPrincipal-user: {identity.Name} - IsAuthenticated: {identity.IsAuthenticated}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("authenticate")]
        public HttpResponseMessage Authenticate(LoginRequest login)
        {
            var isAuthenticate = Convert.ToBoolean(ConfigurationManager.AppSettings["JWT_AUTHENTICATE"]);
            if (!isAuthenticate)
                return Request.CreateErrorResponse(HttpStatusCode.Unauthorized, "Authenticate Unauthorized");

            if (login == null)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            // *** Constructor
            var isTesterValid = (login.Username == "constructor" && login.Password == "qwerty");
            if (isTesterValid)
            {
                var token = TokenGenerator.GenerateTokenJwt(login.Username, RolName.Constructor);
                return Request.CreateResponse(HttpStatusCode.OK, token );
            }

            // *** Administrator
            var isAdminValid = (login.Username == "admin" && login.Password == "qwerty");
            if (isAdminValid)
            {
                var token = TokenGenerator.GenerateTokenJwt(login.Username, RolName.Administrator);
                return Request.CreateResponse(HttpStatusCode.OK, token);
            }

            return Request.CreateErrorResponse(HttpStatusCode.Unauthorized, "Authenticate Unauthorized");
        }
    }

}
