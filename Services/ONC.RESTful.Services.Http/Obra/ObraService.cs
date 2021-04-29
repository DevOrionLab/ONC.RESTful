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
    [RoutePrefix("api/obra")]
    public class ObraService : BaseApiController
    {
        private readonly Random _random = new Random();

        #region ActaInicioObra

        /// <summary><![CDATA[Método de negocio Task[int] Create(model).]]></summary>
        /// <param name="model"> </param>
        /// <remarks>Agrega un nuevo objeto T:ActaInicioObra.</remarks>
        /// <returns></returns>
        /// <response code="201">ActaInicioObra</response>
        /// <response code="400">Bad request</response>
        /// <response code="422">Unprocessable Entity</response>
        /// <response code="500">Internal Server Error</response>
        [HttpPost]
        [Route("ActaInicioObra")]
        [ResponseType(typeof(ActaInicioObra))]
        public async Task<HttpResponseMessage> AddActaInicioObra(ActaInicioObra model)
        {
            var result = await ObraComponent<ActaInicioObra>.Instance.Create(model);
            return HttpResponseMessageCreate(model.GetType().Name, model.Numero, result);
        }

        /// <summary><![CDATA[Método de negocio T Create(int).]]></summary>
        /// <param name="id"></param>
        /// <remarks>Retorna un objeto T:ActaInicioObra, tomando como parámetro el Id.</remarks>
        /// <returns>ActaInicioObra</returns>
        /// <response code="200">ActaInicioObra</response>
        /// <response code="400">Bad request</response>
        /// <response code="422">Unprocessable Entity</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet]
        [Route("ActaInicioObraId")]
        [ResponseType(typeof(ActaInicioObra))]
        public async Task<HttpResponseMessage> GetActaInicioObra(int id)
        {
            var result = await ObraComponent<ActaInicioObra>.Instance.GetById(id);
            return HttpResponseMessageResult<ActaInicioObra>(result);
        }

        /// <summary><![CDATA[Método de negocio Array[T] Create(string).]]></summary>
        /// <param name="numero"></param>
        /// <remarks>Retorna un Array de objetos T:ActaInicioObra, tomando como parámetro el número de Frente de Obra.</remarks>
        /// <returns>ActaInicioObra</returns>
        /// <response code="200">ActaInicioObra</response>
        /// <response code="400">Bad request</response>
        /// <response code="422">Unprocessable Entity</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet]
        [Route("ActaInicioObraNumeroFrenteObra")]
        [ResponseType(typeof(ActaInicioObra))]
        public async Task<HttpResponseMessage> GetActaInicioObraPorNumero(string numero)
        {
            var result = await ObraComponent<ActaInicioObra>.Instance.GetByNumber(numero);
            return HttpResponseMessageResult<ActaInicioObra>(result);
        }



        #endregion

        #region ResponsableTecnicoObra
        /// <summary>
        /// Llama al método de negocio ResponsableTecnicoObra.
        /// </summary>
        /// <param name="model"> </param>
        /// <remarks></remarks>
        /// <returns></returns>
        /// <response code="201">ResponsableTecnicoObra</response>
        /// <response code="400">Bad request</response>
        /// <response code="422">Unprocessable Entity</response>
        /// <response code="500">Internal Server Error</response>
        [HttpPost]
        [Route("ResponsableTecnicoObra")]
        [ResponseType(typeof(ResponsableTecnicoObra))]
        public async Task<HttpResponseMessage> AddResponsableTecnicoObra(ResponsableTecnicoObra model)
        {

            var result = await ObraComponent<ResponsableTecnicoObra>.Instance.Create(model);
            return HttpResponseMessageCreate(model.GetType().Name, model.Numero, result);

        }

        /// <summary>
        /// Llama al método de negocio ResponsableTecnicoObra.
        /// </summary>
        /// <param name="id"></param>
        /// <remarks></remarks>
        /// <returns></returns>
        /// <response code="200">ResponsableTecnicoObra</response>
        /// <response code="400">Bad request</response>
        /// <response code="422">Unprocessable Entity</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet]
        [Route("GetResponsableTecnicoObra")]
        [ResponseType(typeof(ResponsableTecnicoObra))]
        public async Task<HttpResponseMessage> GetResponsableTecnicoObra(int id)
        {
            var result = await ObraComponent<ResponsableTecnicoObra>.Instance.GetById(id);
            return HttpResponseMessageResult(result);
        }

        #endregion

        #region AnticipoFinanciero
        /// <summary>
        /// Invoca al método de negocio ObraService.AnticipoFinanciero
        /// </summary>
        /// <param name="model"></param>
        /// <remarks></remarks>
        /// <returns></returns>
        /// <response code="201">AnticipoFinanciero</response>
        /// <response code="400">Bad request</response>
        /// <response code="422">Unprocessable Entity</response>
        /// <response code="500">Internal Server Error</response>
        [HttpPost]
        [Route("AnticipoFinanciero")]
        [ResponseType(typeof(AnticipoFinanciero))]
        public async Task<HttpResponseMessage> AnticipoFinanciero(AnticipoFinanciero model)
        {
            var result = await ObraComponent<AnticipoFinanciero>.Instance.Create(model);
            return HttpResponseMessageCreate(model.GetType().Name, model.Numero, result);
        }

        /// <summary>
        /// Invoca al método de negocio ObraService.AnticipoFinanciero
        /// </summary>
        /// <param name="id"></param>
        /// <remarks></remarks>
        /// <returns></returns>
        /// <response code="200">AnticipoFinanciero</response>
        /// <response code="400">Bad request</response>
        /// <response code="422">Unprocessable Entity</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet]
        [Route("GetAnticipoFinanciero")]
        [ResponseType(typeof(AnticipoFinanciero))]
        public async Task<HttpResponseMessage> GetAnticipoFinanciero(int id)
        {
            var result = await ObraComponent<AnticipoFinanciero>.Instance.GetById(id);
            return HttpResponseMessageResult(result);
        }
        #endregion

        #region AmpliacionesAdicionales
        /// <summary>
        /// Llama al método de negocio del servicio ObraService.
        /// </summary>
        /// <param name="model"></param>
        /// <remarks></remarks>
        /// <returns></returns>
        /// <response code="201">AmpliacionesAdicionales</response>
        /// <response code="400">Bad request</response>
        /// <response code="422">Unprocessable Entity</response>
        /// <response code="500">Internal Server Error</response>
        [HttpPost]
        [Route("AmpliacionAdicional")]
        [ResponseType(typeof(AmpliacionAdicional))]
        public async Task<HttpResponseMessage> AmpliacionAdicional(AmpliacionAdicional model)
        {
            var result = await ObraComponent<AmpliacionAdicional>.Instance.Create(model);
            return HttpResponseMessageCreate(model.GetType().Name, model.Numero, result);
        }

        /// <summary>
        /// Llama al método de negocio del servicio ObraService.
        /// </summary>
        /// <param name="id"></param>
        /// <remarks></remarks>
        /// <returns></returns>
        /// <response code="200">AmpliacionesAdicionales</response>
        /// <response code="400">Bad request</response>
        /// <response code="422">Unprocessable Entity</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet]
        [Route("GetAmpliacionAdicional")]
        [ResponseType(typeof(AmpliacionAdicional))]
        public async Task<HttpResponseMessage> GetAmpliacionAdicional(int id)
        {
            var result = await ObraComponent<AmpliacionAdicional>.Instance.GetById(id);
            return HttpResponseMessageResult(result);
        }
        #endregion

        #region ProrrogaPlazo
        /// <summary>
        /// Invoca al método de negocio ObraService.ProrrogaPlazo
        /// </summary>
        /// <param name="model"></param>
        /// <remarks></remarks>
        /// <returns></returns>
        /// <response code="201">ProrrogaPlazo</response>
        /// <response code="400">Bad request</response>
        /// <response code="422">Unprocessable Entity</response>
        /// <response code="500">Internal Server Error</response>
        [HttpPost]
        [Route("ProrrogaPlazo")]
        [ResponseType(typeof(ProrrogaPlazo))]
        public async Task<HttpResponseMessage> ProrrogaPlazo(ProrrogaPlazo model)
        {
            var result = await ObraComponent<ProrrogaPlazo>.Instance.Create(model);
            return HttpResponseMessageCreate(model.GetType().Name, model.Numero, result);
        }

        /// <summary>
        /// Invoca al método de negocio ObraService.ProrrogaPlazo
        /// </summary>
        /// <param name="id"></param>
        /// <remarks></remarks>
        /// <returns></returns>
        /// <response code="200">ProrrogaPlazo</response>
        /// <response code="400">Bad request</response>
        /// <response code="422">Unprocessable Entity</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet]
        [Route("GetProrrogaPlazo")]
        [ResponseType(typeof(ProrrogaPlazo))]
        public async Task<HttpResponseMessage> GetProrrogaPlazo(int id)
        {
            var result = await ObraComponent<ProrrogaPlazo>.Instance.GetById(id);
            return HttpResponseMessageResult(result);
        }
        #endregion

        #region SuspensionObra
        /// <summary>
        /// Llama al método de negocio del servicio ObraService.SuspensionObra()
        /// </summary>
        /// <param name="model"></param>
        /// <remarks></remarks>
        /// <returns></returns>
        /// <response code="201">SuspensionObra</response>
        /// <response code="400">Bad request</response>
        /// <response code="422">Unprocessable Entity</response>
        /// <response code="500">Internal Server Error</response>
        [HttpPost]
        [Route("SuspensionObra")]
        [ResponseType(typeof(SuspensionObra))]
        public async Task<HttpResponseMessage> SuspensionObra(SuspensionObra model)
        {
            var result = await ObraComponent<SuspensionObra>.Instance.Create(model);
            return HttpResponseMessageCreate(model.GetType().Name, model.Numero, result);
        }

        /// <summary>
        /// Llama al método de negocio del servicio ObraService.SuspensionObra().
        /// </summary>
        /// <param name="id"></param>
        /// <remarks></remarks>
        /// <returns></returns>
        /// <response code="200">SuspensionObra</response>
        /// <response code="400">Bad request</response>
        /// <response code="422">Unprocessable Entity</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet]
        [Route("GetSuspensionObra")]
        [ResponseType(typeof(SuspensionObra))]
        public async Task<HttpResponseMessage> GetSuspensionObra(int id)
        {
            var result = await ObraComponent<SuspensionObra>.Instance.GetById(id);
            return HttpResponseMessageResult(result);
        }
        #endregion

        #region SubcontratistasAutorizado
        /// <summary>
        /// Invoca al método de negocio ObraService.SubcontratistasAutorizado()
        /// </summary>
        /// <param name="model"></param>
        /// <remarks></remarks>
        /// <returns></returns>
        /// <response code="201">SubcontratistasAutorizado</response>
        /// <response code="400">Bad request</response>
        /// <response code="422">Unprocessable Entity</response>
        /// <response code="500">Internal Server Error</response>
        [HttpPost]
        [Route("SubContratistaAutorizado")]
        [ResponseType(typeof(SubcontratistaAutorizado))]
        public async Task<HttpResponseMessage> SubContratistaAutorizado(SubcontratistaAutorizado model)
        {
            var result = await ObraComponent<SubcontratistaAutorizado>.Instance.Create(model);
            return HttpResponseMessageCreate(model.GetType().Name, model.Numero, result);
        }

        /// <summary>
        /// Invoca al método de negocio ObraService.SubcontratistasAutorizado().
        /// </summary>
        /// <param name="id"></param>
        /// <remarks></remarks>
        /// <returns></returns>
        /// <response code="200">SubcontratistasAutorizado</response>
        /// <response code="400">Bad request</response>
        /// <response code="422">Unprocessable Entity</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet]
        [Route("GetSubContratistaAutorizado")]
        [ResponseType(typeof(SubcontratistaAutorizado))]
        public async Task<HttpResponseMessage> GetSubContratistaAutorizado(int id)
        {
            var result = await ObraComponent<SubcontratistaAutorizado>.Instance.GetById(id);
            return HttpResponseMessageResult(result);
        }
        #endregion

        #region AvanceFisico
        /// <summary>
        /// Invoca al método de negocio ObraService.AvanceFisico
        /// </summary>
        /// <param name="model"></param>
        /// <remarks></remarks>
        /// <returns></returns>
        /// <response code="201">AvanceFisico</response>
        /// <response code="400">Bad request</response>
        /// <response code="422">Unprocessable Entity</response>
        /// <response code="500">Internal Server Error</response>
        [HttpPost]
        [Route("AvanceFisico")]
        [ResponseType(typeof(AvanceFisico))]
        public async Task<HttpResponseMessage> AvanceFisico(AvanceFisico model)
        {
            var result = await ObraComponent<AvanceFisico>.Instance.Create(model);
            return HttpResponseMessageCreate(model.GetType().Name, model.Numero, result);
        }

        /// <summary>
        /// Invoca al método de negocio ObraService.AvanceFisico
        /// </summary>
        /// <param name="id"></param>
        /// <remarks></remarks>
        /// <returns></returns>
        /// <response code="200">AvanceFisico</response>
        /// <response code="400">Bad request</response>
        /// <response code="422">Unprocessable Entity</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet]
        [Route("GetAvanceFisico")]
        [ResponseType(typeof(AvanceFisico))]
        public async Task<HttpResponseMessage> GetAvanceFisico(int id)
        {
            var result = await ObraComponent<AvanceFisico>.Instance.GetById(id);
            return HttpResponseMessageResult(result);
        }
        #endregion

        #region RedeterminacionPrecioTramiteAprobada
        /// <summary>
        /// Invoca al método de negocio ObraService.RedeterminacionPrecioTramiteAprobada
        /// </summary>
        /// <param name="model"></param>
        /// <remarks></remarks>
        /// <returns></returns>
        /// <response code="201">RedeterminacionPrecioTramiteAprobada</response>
        /// <response code="400">Bad request</response>
        /// <response code="422">Unprocessable Entity</response>
        /// <response code="500">Internal Server Error</response>
        [HttpPost]
        [Route("RedeterminacionPrecioTramiteAprobada")]
        [ResponseType(typeof(RedeterminacionPrecioTramiteAprobada))]
        public async Task<HttpResponseMessage> RedeterminacionPrecioTramiteAprobada(RedeterminacionPrecioTramiteAprobada model)
        {
            var result = await ObraComponent<RedeterminacionPrecioTramiteAprobada>.Instance.Create(model);
            return HttpResponseMessageCreate(model.GetType().Name, model.Numero, result);
        }

        /// <summary>
        /// Invoca al método de negocio ObraService.RedeterminacionPrecioTramiteAprobada
        /// </summary>
        /// <param name="id"></param>
        /// <remarks></remarks>
        /// <returns></returns>
        /// <response code="200">RedeterminacionPrecioTramiteAprobada</response>
        /// <response code="400">Bad request</response>
        /// <response code="422">Unprocessable Entity</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet]
        [Route("GetRedeterminacionPrecioTramiteAprobada")]
        [ResponseType(typeof(RedeterminacionPrecioTramiteAprobada))]
        public async Task<HttpResponseMessage> GetRedeterminacionPrecioTramiteAprobada(int id)
        {
            var result = await ObraComponent<RedeterminacionPrecioTramiteAprobada>.Instance.GetById(id);
            return HttpResponseMessageResult(result);
        }
        #endregion

        #region PenalidadSancionAplicada
        /// <summary>
        /// Invoca al método de negocio ObraService.PenalidadSancionAplicada
        /// </summary>
        /// <param name="model"></param>
        /// <remarks></remarks>
        /// <returns></returns>
        /// <response code="201">PenalidadSancionAplicada</response>
        /// <response code="400">Bad request</response>
        /// <response code="422">Unprocessable Entity</response>
        /// <response code="500">Internal Server Error</response>
        [HttpPost]
        [Route("PenalidadSancionAplicada")]
        [ResponseType(typeof(PenalidadSancionAplicada))]
        public async Task<HttpResponseMessage> PenalidadSancionAplicada(PenalidadSancionAplicada model)
        {
            var result = await ObraComponent<PenalidadSancionAplicada>.Instance.Create(model);
            return HttpResponseMessageCreate(model.GetType().Name, model.Numero, result);
        }

        /// <summary>
        /// Invoca al método de negocio ObraService.PenalidadSancionAplicada
        /// </summary>
        /// <param name="id"></param>
        /// <remarks></remarks>
        /// <returns></returns>
        /// <response code="200">PenalidadSancionAplicada</response>
        /// <response code="400">Bad request</response>
        /// <response code="422">Unprocessable Entity</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet]
        [Route("GetPenalidadSancionAplicada")]
        [ResponseType(typeof(PenalidadSancionAplicada))]
        public async Task<HttpResponseMessage> GetPenalidadSancionAplicada(int id)
        {
            var result = await ObraComponent<PenalidadSancionAplicada>.Instance.GetById(id);
            return HttpResponseMessageResult(result);
        }
        #endregion

        
    }
}
