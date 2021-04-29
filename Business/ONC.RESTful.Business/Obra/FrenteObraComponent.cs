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
        public dynamic FdoByEstadoAndNumero(string numero, int estado)
        {
            //var result = default(FrenteObraGetEstadoNumero);

            // Declaracion del componente de acceso a datos.
            var dac = new FrenteObraDac();

            // Paso 1: llamar a SelectByEstadoAndNumero en FrenteObraDac.
            var result = dac.SelectByEstadoAndNumero(numero, estado);
            return result;
        }

        /// <summary>
        /// Contrato vigente : mayor id y estado > 3
        /// Contrato original: menor id y estado > 3
        /// </summary>
        /// <param name="numero"></param>
        /// <param name="idUnidadEjecutora">id Unidad Ejecutora de Seguimiento</param>
        /// <returns>Devuelve un objeto FrenteObra detallado</returns>
        public dynamic FdoDetalladoPorNumero(string numero, long idUnidadEjecutora)
        {
            var dac = new FrenteObraDac();

            // Paso 1: llamar a SelectByNumeroToExpando en FrenteObraDac.
            var result = dac.SelectByNumeroToExpando(numero, idUnidadEjecutora);

            if (result.Count == 0)
                return null;

            var contratoVigente = result.First();
            var contratoOriginal = result.Last();

            contratoVigente.NumeroContratoOriginal = contratoOriginal.NumeroContratoVigente;
            contratoVigente.MontoOriginalContrato = contratoOriginal.MontoVigenteContratoPrecioBase;
            contratoVigente.FechaPerfeccionamientoContratoOriginal = contratoOriginal.FechaPerfeccionamiento;

            ((IDictionary<string, object>)contratoVigente).Remove("FechaPerfeccionamiento");
            ((IDictionary<string, object>)contratoVigente).Remove("EstadoDocumentoContractual");

            return contratoVigente;
        }

        public object FdoPorNumeroContrato(string numeroContrato)
        {
            var dac = new FrenteObraDac();

            // Paso 1: llamar a SelectByNumeroToExpando en FrenteObraDac.
            var result = dac.SelectByNumeroContratoToExpando(numeroContrato);

            return result;
        }
    }
}
