using System;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Net.Http;
using System.Web.Http.Filters;
using ONC.RESTful.Framework.Logging;

namespace ONC.RESTful.Services.Http.Utils
{
    /// <summary>
    /// 
    /// </summary>
    public class CustomExceptionFilter : ExceptionFilterAttribute
    {
        /// <summary>
        /// 
        /// </summary>
        public CustomExceptionFilter()
        {
                
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="actionExecutedContext"></param>
        public void OnExceptionObsolete(HttpActionExecutedContext actionExecutedContext)
        {
            //var exceptionMessage = string.Empty;
            var exceptionMessage = actionExecutedContext.Exception.InnerException == null ? actionExecutedContext.Exception.Message : actionExecutedContext.Exception.InnerException.Message;
            //We can log this exception message
            var response = new HttpResponseMessage(HttpStatusCode.InternalServerError)
            {
                Content = new StringContent("El servicio lanzó una excepción no controlada."),
                ReasonPhrase = "Error interno del servidor. Póngase en contacto con su administrador.."
            };
            actionExecutedContext.Response = response;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public override void OnException(HttpActionExecutedContext context)
        {
            var exceptionType = context.Exception.GetType().ToString();
            var exception = context.Exception.InnerException ?? context.Exception;

            HttpResponseMessage httpResponseMessage;

            LoggingService.Instance.Error(exception);
            switch (exceptionType)
            {
                case "System.Data.DuplicateNameException":

                    httpResponseMessage = CreateHttpResponseMessage(context.Request, HttpStatusCode.BadRequest, "Se encuentro un nombre de objeto de base de datos duplicado");
                    break;

                case "System.Data.ObjectNotFoundException":
                case "System.Data.Entity.Core.ObjectNotFoundException":

                    httpResponseMessage = CreateHttpResponseMessage(context.Request, HttpStatusCode.NotFound, "No se encuentra el objeto solicitado.");
                    break;

                case "System.UnauthorizedAccessException":

                    httpResponseMessage = CreateHttpResponseMessage(context.Request, HttpStatusCode.Forbidden, "Excepción de acceso no autorizado");
                    break;

                case "System.ComponentModel.DataAnnotations.ValidationException":

                    httpResponseMessage = CreateHttpResponseMessage(context.Request, HttpStatusCode.BadRequest, "Se ha producido un error durante la validación de un campo de datos.");
                    break;

                case "System.Data.SqlClient.SqlException":
                    httpResponseMessage = CreateHttpResponseMessage(context.Request, HttpStatusCode.InternalServerError, "El servicio lanzó una SqlException no controlada.");
                    break;

                case "System.Data.Entity.Infrastructure.DbUpdateException":
                    httpResponseMessage = CreateHttpResponseMessage(context.Request, HttpStatusCode.InternalServerError, "Ha ocurrido un error. Por favor intente de nuevo.");
                    break;

                case "System.Data.Entity.Core.OptimisticConcurrencyException":
                case "System.Data.OptimisticConcurrencyException":
                    httpResponseMessage = CreateHttpResponseMessage(context.Request, HttpStatusCode.InternalServerError, "Ha ocurrido un error. Por favor intente de nuevo. Si el error persiste, póngase en contacto con su administrador.");
                    break;

                default:
                    httpResponseMessage = CreateHttpResponseMessage(context.Request, HttpStatusCode.InternalServerError, $"{exceptionType}: El servicio lanzó una excepción no controlada.");
                    break;
            }
            context.Response = httpResponseMessage;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="statusCode"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        public HttpResponseMessage CreateHttpResponseMessage(HttpRequestMessage request, HttpStatusCode statusCode, string error)
        {
            return request.CreateResponse(statusCode, error);
        }

    }
}