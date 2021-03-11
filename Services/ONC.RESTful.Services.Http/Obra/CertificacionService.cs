using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using ONC.RESTful.Business.Obra;
using ONC.RESTful.Entities;
using ONC.RESTful.Entities.Obra;
using ONC.RESTful.Services.Http.Utils;

namespace ONC.RESTful.Services.Http
{
    [RoutePrefix("api/obra/certificacion")]
    public class CertificacionService : BaseApiController
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
        public async Task<HttpResponseMessage> CertificacionAvancePrecioBase(CertificacionAvancePrecioBase model)
        {
            var result = await ObraComponent<CertificacionAvancePrecioBase>.Instance.Create(model);
            return HttpResponseMessageCreate(model.GetType().Name, model.Numero, result);
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
        public async Task<HttpResponseMessage> GetCertificacionAvancePrecioBase(int id)
        {
            var result = await ObraComponent<CertificacionAvancePrecioBase>.Instance.GetById(id);
            return HttpResponseMessageResult(result);
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
        public async Task<HttpResponseMessage> CertificacionAvancePrecioRedeterminado(CertificacionAvancePrecioRedeterminado model)
        {
            var result = await ObraComponent<CertificacionAvancePrecioRedeterminado>.Instance.Create(model);
            return HttpResponseMessageCreate(model.GetType().Name, model.Numero, result);
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
        public async Task<HttpResponseMessage> GetCertificacionAvancePrecioRedeterminado(int id)
        {
            var result = await ObraComponent<CertificacionAvancePrecioRedeterminado>.Instance.GetById(id);
            return HttpResponseMessageResult(result);
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
        public async Task<HttpResponseMessage> CertificacionAjusteRedeterminacion(CertificacionAjusteRedeterminacion model)
        {
            var result = await ObraComponent<CertificacionAjusteRedeterminacion>.Instance.Create(model);
            return HttpResponseMessageCreate(model.GetType().Name, model.Numero, result);
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
        public async Task<HttpResponseMessage> GetCertificacionAjusteRedeterminacion(int id)
        {
            var result = await ObraComponent<CertificacionAjusteRedeterminacion>.Instance.GetById(id);
            return HttpResponseMessageResult(result);
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
        public async Task<HttpResponseMessage> PlanTrabajoCurvaCertificacion(PlanTrabajoCurvaCertificacion model)
        {
            var result = await ObraComponent<PlanTrabajoCurvaCertificacion>.Instance.Create(model);
            return HttpResponseMessageCreate(model.GetType().Name, model.Numero, result);
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
        public async Task<HttpResponseMessage> GetPlanTrabajoCurvaCertificacion(int id)
        {
            var result = await ObraComponent<PlanTrabajoCurvaCertificacion>.Instance.GetById(id);
            return HttpResponseMessageResult(result);
        }
        #endregion
    }
}
