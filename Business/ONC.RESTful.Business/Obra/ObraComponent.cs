using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using ONC.RESTful.Data.EF6;
using ONC.RESTful.Data.Obra;
using ONC.RESTful.Entities.Enums;
using ONC.RESTful.Entities.Obra;
using ONC.RESTful.Framework;
using ONC.RESTful.Framework.Logging;

namespace ONC.RESTful.Business.Obra
{
    //public sealed class ObraComponent
    public class ObraComponent<T> where T : IdentityBase, new()
    {
        private static readonly Lazy<ObraComponent<T>> lazy = new Lazy<ObraComponent<T>>(() => new ObraComponent<T>());
        public static ObraComponent<T> Instance => lazy.Value;

        private static readonly Lazy<BaseDataService<T>> Lazydb = new Lazy<BaseDataService<T>>(() => new BaseDataService<T>());
        private static BaseDataService<T> db => Lazydb.Value;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <exception cref="SqlException"></exception>
        /// <returns></returns>
        public async Task<int> Create(T model)
        {
            var request = HttpContext.Current.Request;

            if (!Validate(model.Numero))
            {
                return Constants.EXIT_FAILURE;
            }

            var task = Task.Run(() =>
            {
                try
                {
                    var result = db.Create(model);
                    return result.Id;
                }
                catch (DbEntityValidationException ex)
                {
                    throw DbEntityValidation(ex);
                }
                catch (Exception e)
                {
                    LoggingService.Instance.Error(e.InnerException);
                    throw;
                }
            });

            await task.ContinueWith(antecedent =>
                {
                    var apiLog = new ApiLog()
                    {
                        IdentityId = model.TransactionId,
                        IdentityName = typeof(T).Name,
                        Numero = model.Numero,
                        Message = $"SCOPE_IDENTITY(): {antecedent.Result}",
                        IpAddress = request.UserHostAddress,
                        UserAgent = request.UserAgent,
                        PathAndQuery = request.Url.PathAndQuery,
                        HttpReferer = (request.UrlReferrer == null) ? string.Empty : request.UrlReferrer.PathAndQuery,
                        TipoEntidad = model.TipoEntidad
                    };
                    var log = new BaseDataService<ApiLog>();
                    log.Create(apiLog);

                }, TaskContinuationOptions.OnlyOnRanToCompletion);

            return task.Result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<T> GetById(int id)
        {
            var entity = db.GetById(id);
            return await Task.FromResult(entity);
        }
        public async Task<List<T>> GetByNumber(string numero)
        {
            var entity = db.Get(o => o.Numero == numero);
            return await Task.FromResult(entity);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numeroFrenteObra"></param>
        /// <returns></returns>
        private bool Validate(string numeroFrenteObra)
        {
            var dac = new FrenteObraDac();
            var result = dac.GetByNumber(numeroFrenteObra);
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ex"></param>
        /// <returns></returns>
        private static DbEntityValidationException DbEntityValidation(DbEntityValidationException ex)
        {
            var errorMessages = ex.EntityValidationErrors
                .SelectMany(x => x.ValidationErrors)
                .Select(x => x.ErrorMessage);

            var fullErrorMessage = string.Join("; ", errorMessages);
            LoggingService.Instance.Log(fullErrorMessage);

            var exceptionMessage = string.Concat(ex.Message, " Los errores de validación son: ", fullErrorMessage);

            return new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
        }

    }
}