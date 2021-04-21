using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Microsoft.IdentityModel.Tokens;
using ONC.RESTful.Framework.Logging;

namespace ONC.RESTful.Services.Http.Security
{
    /// <summary>
    /// Validador de tokens para solicitud de autorización mediante DelegatingHandler
    /// </summary>
    public class TokenValidationHandler : DelegatingHandler
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        private static bool TryRetrieveToken(HttpRequestMessage request, out string token)
        {
            token = null;
            IEnumerable<string> authzHeaders;
            if (!request.Headers.TryGetValues("Authorization", out authzHeaders) || authzHeaders.Count() > 1)
            {
                return false;
            }
            var bearerToken = authzHeaders.ElementAt(0);
            token = bearerToken.StartsWith("Bearer ") ? bearerToken.Substring(7) : bearerToken;
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            //HttpStatusCode statusCode;

            // Determinar si existe un jwt o no
            if (!TryRetrieveToken(request, out var token))
            {
                return base.SendAsync(request, cancellationToken);
            }

            try
            {
                var secretKey = ConfigurationManager.AppSettings["JWT_SECRET_KEY"];
                var audienceToken = ConfigurationManager.AppSettings["JWT_AUDIENCE_TOKEN"];
                var issuerToken = ConfigurationManager.AppSettings["JWT_ISSUER_TOKEN"];
                var securityKey = new SymmetricSecurityKey(System.Text.Encoding.Default.GetBytes(secretKey));

                SecurityToken securityToken;
                var tokenHandler = new System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler();
                var validationParameters = new TokenValidationParameters()
                {
                    ValidAudience = audienceToken,
                    ValidIssuer = issuerToken,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    LifetimeValidator = this.LifetimeValidator,
                    IssuerSigningKey = securityKey
                };

                // Extraer y asignar el Current Principal y usuario
                Thread.CurrentPrincipal = tokenHandler.ValidateToken(token, validationParameters, out securityToken);
                HttpContext.Current.User = tokenHandler.ValidateToken(token, validationParameters, out securityToken);

                return base.SendAsync(request, cancellationToken);
            }
            catch (SecurityTokenValidationException securityTokenValidation)
            {
                var httpResponseMessage = request.CreateErrorResponse(HttpStatusCode.Unauthorized,
                    "Indica que el recurso solicitado requiere autenticación. El encabezado WWW-Authenticate contiene los detalles de cómo realizar la autenticación.");
                LoggingService.Instance.Error(securityTokenValidation);
                return Task<HttpResponseMessage>.Factory.StartNew(() => httpResponseMessage, cancellationToken);
            }
            catch (Exception ex)
            {
                var httpResponseMessage = request.CreateErrorResponse(HttpStatusCode.InternalServerError,
                    "Indica que se ha producido un error genérico del servidor.Por favor comuníquese con el administrador.");
                LoggingService.Instance.Error(ex);
                return Task<HttpResponseMessage>.Factory.StartNew(() => httpResponseMessage, cancellationToken);
            }
            

            //return Task<HttpResponseMessage>.Factory.StartNew(() => new HttpResponseMessage(statusCode) { }, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="notBefore"></param>
        /// <param name="expires"></param>
        /// <param name="securityToken"></param>
        /// <param name="validationParameters"></param>
        /// <returns></returns>
        public bool LifetimeValidator(DateTime? notBefore, DateTime? expires, SecurityToken securityToken, TokenValidationParameters validationParameters)
        {
            if (expires == null) 
                return false;

            return DateTime.UtcNow < expires;
        }
    }
}