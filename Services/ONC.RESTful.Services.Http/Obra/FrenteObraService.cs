//====================================================================================================
// HTTP Service Controller
// ONC.RESTful.WebServices
//
// Generado por vcontreras on 20/12/2020
//====================================================================================================

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Newtonsoft.Json.Linq;
using ONC.RESTful.Business.Obra;
using ONC.RESTful.Entities.Obra;
using ONC.RESTful.Services.Http.Utils;

namespace ONC.RESTful.Services.Http
{
    /// <summary>
    /// FrenteObra HTTP service controller.
    /// </summary>
    // [Authorize(Roles = "Constructor")]
    [RoutePrefix("api/frenteObra")]
    public class FrenteObraService : ApiController
    {
        /// <summary>
        /// Proporciona  un objeto FDO, filtrando por estado y n�mero del FDO.
        /// </summary>
        /// <param name="estado"> Valor num�rico que representa el Estado del Frente de Obra.</param>
        /// <param name="numero"> Valor alfanum�rico que representa el N�mero del Frente de Obra.</param>
        /// <remarks>Este m�todo se encarga de retornar un objeto Frente de Obra, tomando como datos de filtros el estado y el n�mero de Frente de Obra.</remarks>
        /// <returns></returns>
        /// <response code="200">FdoNumero</response>
        /// <response code="400">Bad request</response>
        /// <response code="422">Unprocessable Entity</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet]
        [Route("")]
        [ResponseType(typeof(FdoNumero))]
        public HttpResponseMessage GetFdoByEstadoAndNumero([FromUri] string numero, [FromUri] int estado)
        {
            var bc = FrenteObraComponent.Instance;
            var result = bc.FdoByEstadoAndNumero(numero, estado);

            return result == null
                ? Request.CreateErrorResponse(HttpStatusCode.NotFound, "FrenteObra not found")
                : Request.CreateResponse(HttpStatusCode.OK, result as IDictionary<string, object>);
        }

        /// <summary>
        /// Provee  un objeto FDO detallado, filtrando por el n�mero del FDO.
        /// </summary>
        /// <param name="numero"> Valor alfanum�rico que representa el N�mero del Frente de Obra.</param>
        /// <remarks>Provee  un objeto FDO detallado, filtrando por el n�mero del FDO.</remarks>
        /// <response code="200">FdoDetalladoPorNumero</response>
        /// /// <response code="400">Bad request</response>
        /// <response code="422">Unprocessable Entity</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>Devuelve un objeto FdoDetalladoPorNumero.</returns>
        [HttpGet]
        [Route("detalladoPorNumero")]
        [ResponseType(typeof(FdoDetalladoPorNumero))]
        public HttpResponseMessage GetFdoDetalladoPorNumero([FromUri] string numero)
        {
            var bc = FrenteObraComponent.Instance;
            var result = bc.FdoDetalladoPorNumero(numero);

            return result == null
                ? Request.CreateErrorResponse(HttpStatusCode.NotFound, "FrenteObra not found")
                : Request.CreateResponse(HttpStatusCode.OK, result as IDictionary<string, object>);
        }

        /// <summary>
        /// Suministra  un objeto FDO, filtrando por el n�mero de contrato.
        /// </summary>
        /// <param name="numero"> Valor alfanum�rico que representa el N�mero del Frente de Obra.</param>
        /// <remarks>Suministra  un objeto FDO, filtrando por el n�mero de contrato.</remarks>
        /// <response code="200">FdoNumero</response>
        /// /// <response code="400">Bad request</response>
        /// <response code="422">Unprocessable Entity</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>Devuelve un objeto FdoDetalladoPorNumero.</returns>
        [HttpGet]
        [Route("porNumeroContrato")]
        [ResponseType(typeof(FdoNumero))]
        public HttpResponseMessage GetFdoPorNumeroContrato([FromUri] string numero)
        {
            var bc = FrenteObraComponent.Instance;
            var result = bc.FdoPorNumeroContrato(numero);

            return result == null
                ? Request.CreateErrorResponse(HttpStatusCode.NotFound, "FrenteObra not found")
                : Request.CreateResponse(HttpStatusCode.OK, result as IDictionary<string, object>);
        }
    }
}

