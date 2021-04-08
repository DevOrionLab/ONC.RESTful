using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ONC.RESTful.Entities.Obra
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    [DataContract]
    public class FdoDetalladoPorNumero
    {
        /// <summary>
        /// Valor alfanumérico que representa el Número del Frente de Obra
        /// </summary>
        [DataMember] 
        public string NumeroFrenteObra { get; set; }

        /// <summary>
        /// Valor alfanumérico que representa el Nombre del Frente de Obra
        /// </summary>
        [DataMember] 
        public string NombreFrenteObra { get; set; }

        [DataMember] 
        public string NumeroObra { get; set; }

        [DataMember] 
        public string GrupoObra { get; set; }

        [DataMember] 
        public string TipoProyectoObra { get; set; }

        [DataMember] 
        public string RazonSocial { get; set; }

        [DataMember] 
        public string NumeroCUIT { get; set; }

        [DataMember] 
        public string NumeroProcesoContratacion { get; set; }

        [DataMember] 
        public string Organismo { get; set; }

        [DataMember] 
        public string UnidadEjecutoraSeguimiento { get; set; }

        [DataMember] 
        public DateTime FechaAdjudicacion { get; set; }

        [DataMember] 
        public string NumeroContratoOriginal { get; set; }

        [DataMember] 
        public DateTime FechaPerfeccionamientoContratoOriginal { get; set; }

        [DataMember] 
        public DateTime FechaFinalizacion { get; set; }

        [DataMember] 
        public string PlazoEjecucion { get; set; }

        [DataMember] 
        public string TipoPlazoEjecucion { get; set; }

        [DataMember] 
        public string NumeroContratoVigente { get; set; }

        [DataMember] 
        public double MontoVigenteContratoPrecioBase { get; set; }

        [DataMember] 
        public string EstadoObra { get; set; }

        [DataMember] 
        public DateTime FechaInicio { get; set; }

        [DataMember] 
        public string AnticipoFinanciero { get; set; }

        [DataMember] 
        public string PorcentajeAnticipoFinanciero { get; set; }

        [DataMember] 
        public double MontoOriginalContrato { get; set; }
    }
}