//====================================================================================================
// HTTP Service Controller
// ONC.RESTful.WebServices
//
// Generado por vcontreras on 22/12/2020
//====================================================================================================


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ONC.RESTful.Business;
using ONC.RESTful.Entities;

namespace ONC.RESTful.Services.Http
{
    /// <summary>
    /// Historico HTTP service controller.
    /// </summary>
    [RoutePrefix("api/Historico")]
    internal class HistoricoService : ApiController
    {
        /// <summary>
        /// Llama al método de negocio Find de HistoricoComponent
        /// </summary>
        /// <param name="currentPage">Número de página</param>
        /// <remarks>Llama al método de negocio Find de HistoricoComponent, el cual retorna una Lista de Históricos.</remarks>
        /// <response code="400">Bad request</response>
        /// <response code="422">Unprocessable Entity</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>Devuelve una Lista de objetos Históricos</returns>
        [HttpGet]
        [Route("SelectPage")]
        private List<Historico> SelectPage(int currentPage)
        {
            try
            {
                var bc = new HistoricoComponent();
                return bc.Find(currentPage);
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
        /// Calls the Select business method of the HistoricoComponent.
        /// </summary>
        /// <param name="maximumRows"> A maximumRows value.</param>
        /// <param name="startRowIndex"> A startRowIndex value.</param>
        /// <param name="sortExpression"> A sortExpression value.</param>
        /// <returns>Returns a List<Historico> object.</returns>
        [HttpGet]
        [Route("SelectPageSort")]
        private List<Historico> SelectPageSort(int maximumRows, int startRowIndex, string sortExpression)
        {
            try
            {
                var bc = new HistoricoComponent();
                return bc.Select(maximumRows, startRowIndex, sortExpression);
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

