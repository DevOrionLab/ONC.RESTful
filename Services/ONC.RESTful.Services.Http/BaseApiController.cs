using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using ONC.RESTful.Business.Obra;
using ONC.RESTful.Entities;
using ONC.RESTful.Entities.Obra;
using ONC.RESTful.Framework;
using ONC.RESTful.Services.Http.Utils;
using static System.Net.HttpStatusCode;

namespace ONC.RESTful.Services.Http
{
    /// <summary>
    /// 
    /// </summary>
    public class BaseApiController : ApiController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <param name="numero"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        protected HttpResponseMessage HttpResponseMessageCreate(string model, string numero, int result)
        {
            if (result == Constants.EXIT_FAILURE)
            {
                var apiError = new ApiResult()
                {
                    Id = result,
                    Message = $"No existe el frente de Obra: {numero}",
                    Code = (HttpStatusCode)422
                };
                return Request.CreateResponse((HttpStatusCode)422, apiError);
            }

            if (result > 0)
            {
                var apiResult = new ApiResult()
                {
                    Id = result,
                    Message = $"La operación fue llevada de manera exitosa.Datos de la entidad {model} enviada.",
                    Code = HttpStatusCode.Created
                };

                return Request.CreateResponse(HttpStatusCode.Created, apiResult);
            }

            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Not Found");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="result"></param>
        /// <returns></returns>
        protected HttpResponseMessage HttpResponseMessageResult<T>(T result)
        {
            return result == null
                ? Request.CreateErrorResponse(HttpStatusCode.NotFound,
                    "No se puedo encontrar registros con el identificador señalado. Intente nuevamente.")
                : Request.CreateResponse(OK, result);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="result"></param>
        /// <returns></returns>
        protected HttpResponseMessage HttpResponseMessageResult<T>(List<T> result)
        {
            return result == null
                ? Request.CreateErrorResponse(HttpStatusCode.NotFound,
                    "No se puedo encontrar registros con el identificador señalado. Intente nuevamente.")
                : Request.CreateResponse(OK, result);
        }
    }
}