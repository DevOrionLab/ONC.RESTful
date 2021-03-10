using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ONC.RESTful.Business.Obra;
using ONC.RESTful.Entities;
using ONC.RESTful.Entities.Obra;
using ONC.RESTful.Services.Http.Utils;

namespace ONC.RESTful.Services.Http
{
    [RoutePrefix("api/obra/certificacion")]
    public class CertificacionService : ApiController
    {
        private readonly Random _random = new Random();

        #region CertificacionAvancePrecioBase
        /// <summary>
        /// Invoca al método de negocio ObraService.CertificacionAvancePrecioBase
        /// </summary>
        /// <param name="model"></param>
        /// <remarks></remarks>
        /// <returns></returns>
        /// <response code="201">CertificacionAvancePrecioBase</response>
        /// <response code="400">Bad request</response>
        /// <response code="422">Unprocessable Entity</response>
        /// <response code="500">Internal Server Error</response>
        [HttpPost]
        [Route("CertificacionAvancePrecioBase")]
        [ResponseType(typeof(CertificacionAvancePrecioBase))]
        public HttpResponseMessage CertificacionAvancePrecioBase(CertificacionAvancePrecioBase model)
        {
            var result = new CertificacionAvancePrecioBase() { };
            var apiResult = new ApiResult()
            {
                Id = _random.Next(1000),
                Message = "CertificacionAvancePrecioBase creada.",
                Code = HttpStatusCode.Created
            };
            return result == null
                ? Request.CreateErrorResponse(HttpStatusCode.NotFound, "Not Found")
                : Request.CreateResponse(HttpStatusCode.Created, apiResult);
        }

        /// <summary>
        /// Invoca al método de negocio ObraService.CertificacionAvancePrecioBase
        /// </summary>
        /// <param name="id"></param>
        /// <remarks></remarks>
        /// <returns></returns>
        /// <response code="200">CertificacionAvancePrecioBase</response>
        /// <response code="400">Bad request</response>
        /// <response code="422">Unprocessable Entity</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet]
        [Route("GetCertificacionAvancePrecioBase")]
        [ResponseType(typeof(CertificacionAvancePrecioBase))]
        public HttpResponseMessage GetCertificacionAvancePrecioBase(int id)
        {
            var result = new CertificacionAvancePrecioBase() { };
            return result == null
                ? Request.CreateErrorResponse(HttpStatusCode.NotFound, "Not Found")
                : Request.CreateResponse(HttpStatusCode.OK, result);
        }
        #endregion

        #region CertificacionAvancePrecioRedeterminado
        /// <summary>
        /// Invoca ObraService.CertificacionAvancePrecioRedeterminado
        /// </summary>
        /// <param name="model"></param>
        /// <remarks></remarks>
        /// <returns></returns>
        /// <response code="201">CertificacionAvancePrecioRedeterminado</response>
        /// <response code="400">Bad request</response>
        /// <response code="422">Unprocessable Entity</response>
        /// <response code="500">Internal Server Error</response>
        [HttpPost]
        [Route("CertificacionAvancePrecioRedeterminado")]
        [ResponseType(typeof(CertificacionAvancePrecioRedeterminado))]
        public HttpResponseMessage CertificacionAvancePrecioRedeterminado(CertificacionAvancePrecioRedeterminado model)
        {
            var result = new CertificacionAvancePrecioRedeterminado() { };
            var apiResult = new ApiResult()
            {
                Id = _random.Next(1000),
                Message = "CertificacionAvancePrecioRedeterminado creada.",
                Code = HttpStatusCode.Created
            };
            return result == null
                ? Request.CreateErrorResponse(HttpStatusCode.NotFound, "Not Found")
                : Request.CreateResponse(HttpStatusCode.Created, apiResult);
        }

        /// <summary>
        /// Invoca ObraService.CertificacionAvancePrecioRedeterminado
        /// </summary>
        /// <param name="id"></param>
        /// <remarks></remarks>
        /// <returns></returns>
        /// <response code="200">CertificacionAvancePrecioRedeterminado</response>
        /// <response code="400">Bad request</response>
        /// <response code="422">Unprocessable Entity</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet]
        [Route("GetCertificacionAvancePrecioRedeterminado")]
        [ResponseType(typeof(CertificacionAvancePrecioRedeterminado))]
        public HttpResponseMessage GetCertificacionAvancePrecioRedeterminado(int id)
        {
            var result = new CertificacionAvancePrecioRedeterminado() { };
            return result == null
                ? Request.CreateErrorResponse(HttpStatusCode.NotFound, "Not Found")
                : Request.CreateResponse(HttpStatusCode.OK, result);
        }
        #endregion

        #region CertificacionAjusteRedeterminacion
        /// <summary>
        /// Invoca ObraService.CertificacionAjusteRedeterminacion
        /// </summary>
        /// <param name="model"></param>
        /// <remarks></remarks>
        /// <returns></returns>
        /// <response code="201">CertificacionAjusteRedeterminacion</response>
        /// <response code="400">Bad request</response>
        /// <response code="422">Unprocessable Entity</response>
        /// <response code="500">Internal Server Error</response>
        [HttpPost]
        [Route("CertificacionAjusteRedeterminacion")]
        [ResponseType(typeof(CertificacionAjusteRedeterminacion))]
        public HttpResponseMessage CertificacionAjusteRedeterminacion(CertificacionAjusteRedeterminacion model)
        {
            var result = new CertificacionAjusteRedeterminacion() { };
            var apiResult = new ApiResult()
            {
                Id = _random.Next(1000),
                Message = "CertificacionAjusteRedeterminacion creada.",
                Code = HttpStatusCode.Created
            };
            return result == null
                ? Request.CreateErrorResponse(HttpStatusCode.NotFound, "Not Found")
                : Request.CreateResponse(HttpStatusCode.Created, apiResult);
        }

        /// <summary>
        /// Invoca ObraService.CertificacionAjusteRedeterminacion
        /// </summary>
        /// <param name="id"></param>
        /// <remarks></remarks>
        /// <returns></returns>
        /// <response code="200">CertificacionAjusteRedeterminacion</response>
        /// <response code="400">Bad request</response>
        /// <response code="422">Unprocessable Entity</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet]
        [Route("GetCertificacionAjusteRedeterminacion")]
        [ResponseType(typeof(CertificacionAjusteRedeterminacion))]
        public HttpResponseMessage GetCertificacionAjusteRedeterminacion(int id)
        {
            var result = new CertificacionAjusteRedeterminacion() { };
            return result == null
                ? Request.CreateErrorResponse(HttpStatusCode.NotFound, "Not Found")
                : Request.CreateResponse(HttpStatusCode.OK, result);
        }
        #endregion

        #region PlanTrabajoCurvaCertificacion
        /// <summary>
        /// Invoca al método de negocio ObraService.PlanTrabajoCurvaCertificacion
        /// </summary>
        /// <param name="model"></param>
        /// <remarks></remarks>
        /// <returns></returns>
        /// <response code="201">PlanTrabajoCurvaCertificacion</response>
        /// <response code="400">Bad request</response>
        /// <response code="422">Unprocessable Entity</response>
        /// <response code="500">Internal Server Error</response>
        [HttpPost]
        [Route("PlanTrabajoCurvaCertificacion")]
        [ResponseType(typeof(PlanTrabajoCurvaCertificacion))]
        public HttpResponseMessage PlanTrabajoCurvaCertificacion(PlanTrabajoCurvaCertificacion model)
        {
            var result = new PlanTrabajoCurvaCertificacion() { };
            var apiResult = new ApiResult()
            {
                Id = _random.Next(1000),
                Message = "PlanTrabajoCurvaCertificacion creada.",
                Code = HttpStatusCode.Created
            };
            return result == null
                ? Request.CreateErrorResponse(HttpStatusCode.NotFound, "Not Found")
                : Request.CreateResponse(HttpStatusCode.Created, apiResult);
        }

        /// <summary>
        /// Invoca al método de negocio ObraService.PlanTrabajoCurvaCertificacion
        /// </summary>
        /// <param name="id"></param>
        /// <remarks></remarks>
        /// <returns></returns>
        /// <response code="200">PlanTrabajoCurvaCertificacion</response>
        /// <response code="400">Bad request</response>
        /// <response code="422">Unprocessable Entity</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet]
        [Route("GetPlanTrabajoCurvaCertificacion")]
        [ResponseType(typeof(PlanTrabajoCurvaCertificacion))]
        public HttpResponseMessage GetPlanTrabajoCurvaCertificacion(int id)
        {
            var result = new PlanTrabajoCurvaCertificacion() { };
            return result == null
                ? Request.CreateErrorResponse(HttpStatusCode.NotFound, "Not Found")
                : Request.CreateResponse(HttpStatusCode.OK, result);
        }
        #endregion
    }
}
