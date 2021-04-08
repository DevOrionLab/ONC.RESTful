using ONC.RESTful.Entities.Obra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONC.RESTful.UI.Process
{
    public class ObraProcess : ProcessComponent
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="estado"></param>
        /// <param name="numero"></param>
        /// <returns></returns>
        public dynamic GetFrenteObraByEstadoAndNumero(int estado, string numero)
        {
            var parameters = new Dictionary<string, object>
            {
                {"estado", estado},
                {"numero", numero}
            };
            var response = HttpGet<dynamic>("/api/FrenteObra/GetFrenteObraByEstadoAndNumeroToExpando", parameters, MediaType.Json);
            return response;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="estado"></param>
        /// <param name="numero"></param>
        /// <returns></returns>
        public FdoNumero GetObjectFrenteObraByEstadoAndNumero(int estado, string numero)
        {
            var parameters = new Dictionary<string, object>
            {
                {"estado", estado},
                {"numero", numero}
            };
            var response = HttpGet<FdoNumero>("/api/FrenteObra/GetFrenteObraByEstadoAndNumero", parameters, MediaType.Json);
            return response;
        }
    }
}
