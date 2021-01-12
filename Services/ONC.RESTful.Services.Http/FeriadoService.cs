//====================================================================================================
// HTTP Service Controller
// ONC.RESTful.WebServices
//
// Generado por vcontreras on 19/12/2020
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
    /// Feriado HTTP service controller.
    /// </summary>
    [RoutePrefix("api/Feriado")]
    internal class FeriadoService : ApiController
    {
        /// <summary>
        /// Llama al método de negocio Add de FeriadoComponent.
        /// </summary>
        /// <param name="feriado"> A feriado value.</param>
        /// <returns>Returns a Feriado object.</returns>
        [HttpPost]
        [Route("")]
        public Feriado Add(Feriado feriado)
        {
            try
            {
                var bc = new FeriadoComponent();
                return bc.Add(feriado);
            }
            catch (Exception ex)
            {
                // Re empaquetar al error de Http.
                var httpError = new HttpResponseMessage()
                {
                    StatusCode = (HttpStatusCode)422,
                    ReasonPhrase = ex.Message
                };

                throw new HttpResponseException(httpError);
            }
        }

        /// <summary>
        /// Llama al método de negocio Edit de FeriadoComponent.
        /// </summary>
        /// <param name="feriado"> A feriado value.</param>
        [HttpPut]
        [Route("")]
        public void Edit(Feriado feriado)
        {
            try
            {
                var bc = new FeriadoComponent();
                bc.Edit(feriado);
            }
            catch (Exception ex)
            {
                // Re empaquetar al error de Http.
                var httpError = new HttpResponseMessage()
                {
                    StatusCode = (HttpStatusCode)422,
                    ReasonPhrase = ex.Message
                };

                throw new HttpResponseException(httpError);
            }
        }

        /// <summary>
        /// Llama al método de negocio Find de FeriadoComponent.
        /// </summary>
        /// <param name="id"> A id value.</param>
        /// <returns>Returns a Feriado object.</returns>
        [HttpGet]
        [Route("{id}")]
        public Feriado Find(int id)
        {
            try
            {
                var bc = new FeriadoComponent();
                return bc.Find(id);
            }
            catch (Exception ex)
            {
                // Re empaquetar al error de Http.
                var httpError = new HttpResponseMessage()
                {
                    StatusCode = (HttpStatusCode)422,
                    ReasonPhrase = ex.Message
                };

                throw new HttpResponseException(httpError);
            }
        }

        /// <summary>
        /// Llama al método de negocio Remove de FeriadoComponent.
        /// </summary>
        /// <param name="id"> A id value.</param>
        [HttpDelete]
        [Route("")]
        public void Remove(int id)
        {
            try
            {
                var bc = new FeriadoComponent();
                bc.Remove(id);
            }
            catch (Exception ex)
            {
                // Re empaquetar al error de Http.
                var httpError = new HttpResponseMessage()
                {
                    StatusCode = (HttpStatusCode)422,
                    ReasonPhrase = ex.Message
                };

                throw new HttpResponseException(httpError);
            }
        }

        /// <summary>
        /// Llama al método de negocio Select de FeriadoComponent.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("")]
        public List<Feriado> Select()
        {
            try
            {
                var bc = new FeriadoComponent();
                return bc.Select();
            }
            catch (Exception ex)
            {
                // Re empaquetar al error de Http.
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

