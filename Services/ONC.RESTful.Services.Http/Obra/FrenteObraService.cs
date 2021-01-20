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
using ONC.RESTful.Business.Obra;
using ONC.RESTful.Entities.Obra;
using ONC.RESTful.Services.Http.Utils;

namespace ONC.RESTful.Services.Http
{
    /// <summary>
    /// FrenteObra HTTP service controller.
    /// </summary>
    // [Authorize(Roles = "Constructor")]
    [RoutePrefix("api/frenteobra")]
    public class FrenteObraService : ApiController
    {
        /// <summary>
        /// Llama al método de negocio Find de FrenteObraComponent.
        /// </summary>
        /// <param name="estado"> Valor numérico que representa el Estado del Frente de Obra.</param>
        /// <param name="numero"> Valor alfanumérico que representa el Número del Frente de Obra.</param>
        /// <remarks>Este método se encarga de retornar un objeto Frente de Obra, tomando como datos de filtros el estado y el número de Frente de Obra.</remarks>
        /// <returns></returns>
        /// <response code="200">FrenteObra</response>
        /// <response code="400">Bad request</response>
        /// <response code="422">Unprocessable Entity</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet]
        //[CustomExceptionFilter]
        [Route("")]
        [ResponseType(typeof(FrenteObraGetEstadoNumero))]
        public HttpResponseMessage GetFrenteObraByEstadoAndNumero([FromUri] int estado, [FromUri] string numero)
        {
            var bc = FrenteObraComponent.Instance;
            var result = bc.Find(estado, numero);
            return result == null
                ? Request.CreateErrorResponse(HttpStatusCode.NotFound, "FrenteObra not found")
                : Request.CreateResponse(HttpStatusCode.OK, result);
            //try
            //{
            //    var bc = FrenteObraComponent.Instance;
            //    var result = bc.Find(estado, numero);
            //    return result == null
            //        ? Request.CreateErrorResponse(HttpStatusCode.NotFound, "FrenteObra not found")
            //        : Request.CreateResponse(HttpStatusCode.OK, result);
            //}
            //catch (Exception ex)
            //{
            //    var httpError = new HttpResponseMessage()
            //    {
            //        StatusCode = (HttpStatusCode)422,
            //        ReasonPhrase = ex.Message,
            //        Content = new StringContent(ex.Message)
            //    };

            //    throw new HttpResponseException(httpError);
            //}
        }

        /// <summary>
        /// Llama al método de negocio Find de FrenteObraComponent.
        /// </summary>
        /// <param name="estado"> Valor numérico que representa el Estado del Frente de Obra.</param>
        /// <param name="numero"> Valor alfanumérico que representa el Número del Frente de Obra.</param>
        /// <remarks>Llama al método de negocio Find de FrenteObraComponent, el cual a través del estado y el numero retornan el FrenteObraGetEstadoNumero.</remarks>
        /// <response code="400">Bad request</response>
        /// <response code="422">Unprocessable Entity</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>Devuelve un objeto FrenteObraGetEstadoNumero.</returns>
        [HttpGet]
        [Route("GetFrenteObraByEstadoAndNumeroToExpando")]
        private dynamic FindToExpando(int estado, string numero)
        {
            try
            {
                var bc = FrenteObraComponent.Instance;
                return bc.FindToExpando(estado, numero);
            }
            catch (Exception ex)
            {
                // Repack to Http error.
                var httpError = new HttpResponseMessage()
                {
                    StatusCode = (HttpStatusCode)422,
                    ReasonPhrase = ex.Message
                };

                throw new HttpResponseException(httpError);
            }
        }
    }
}

