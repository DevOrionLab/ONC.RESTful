using ONC.RESTful.Data.Obra;
using ONC.RESTful.Entities.Obra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONC.RESTful.Business.Obra
{
    public sealed class FrenteObraComponent
    {
        private static readonly Lazy<FrenteObraComponent> lazy = new Lazy<FrenteObraComponent>(() => new FrenteObraComponent());

        public static FrenteObraComponent Instance => lazy.Value;

        private FrenteObraComponent()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="estado"> Valor numérico que representa el Estado del FrenteObra.</param>
        /// <param name="numero"> Valor alfanumérioco que representa el Número del FrenteObra.</param>
        /// <returns>Devuelve un objeto FrenteObraGetEstadoNumero.</returns>
        public FrenteObraGetEstadoNumero Find(int estado, string numero)
        {
            var result = default(FrenteObraGetEstadoNumero);

            // Declaracion del componente de acceso a datos.
            var dac = new FrenteObraDac();

            // Paso 1: llamar a SelectByEstadoAndNumero en FrenteObraDac.
            result = dac.SelectByEstadoAndNumero(estado, numero);
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="estado"></param>
        /// <param name="numero"></param>
        /// <returns></returns>
        public dynamic FindToExpando(int estado, string numero)
        {
            var result = default(dynamic);

            // Declaracion del componente de acceso a datos.
            var dac = new FrenteObraDac();

            // Paso 1: llamar a SelectByEstadoAndNumeroToExpando en FrenteObraDac.
            result = dac.SelectByEstadoAndNumeroToExpando(estado, numero);
            return result;
        }
    }
}
