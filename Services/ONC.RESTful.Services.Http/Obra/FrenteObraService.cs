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
using ONC.RESTful.Business.Obra;
using ONC.RESTful.Entities.Obra;

namespace ONC.RESTful.Services.Http
{
    /// <summary>
    /// FrenteObra HTTP service controller.
    /// </summary>
    [RoutePrefix("api/FrenteObra")]
    public class FrenteObraService : ApiController
    {
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
        //[Route("{estado}/{numero}")]
        [Route("GetFrenteObraByEstadoAndNumero")]
        public FrenteObraGetEstadoNumero Find(int estado, string numero)
        {
            try
            {
                var bc = FrenteObraComponent.Instance;
                return bc.Find(estado, numero);
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
        public dynamic FindToExpando(int estado, string numero)
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

