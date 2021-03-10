using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONC.RESTful.Entities.Obra
{
    /// <summary>
    /// 
    /// </summary>
    public class RedeterminacionPrecioTramiteAprobada : IdentityBase
    {
        /// <summary>
        /// Tipo de procedimiento de redeterminación
        /// </summary>
        [Required] public int TipoProcedimientoRedeterminacion { get; set; }

        /// <summary>
        /// Número de solicitud
        /// </summary>
        [Required] public int NumeroSolicitud { get; set; }

        /// <summary>
        /// Fecha de solicitud
        /// </summary>
        [Required] public DateTime FechaSolicitud { get; set; }

        /// <summary>
        /// N° EE del trámite
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(256)] 
        public string NumeroEETramite { get; set; }

        /// <summary>
        /// Nuevo monto de contrato aprobado
        /// </summary>
        [Required] public double NuevoMontoContratoAprobado { get; set; }

        /// <summary>
        /// Variación del contrato ($)
        /// </summary>
        [Required] public double VariacionContratoPeso { get; set; }

        /// <summary>
        /// Variación del contrato (%)
        /// </summary>
        [Required] public double VariacionContratoPorcentaje { get; set; }

        /// <summary>
        /// Variación acumulada del contrato ($)
        /// </summary>
        [Required] public double VariacionAcumuladaContratoPeso { get; set; }

        /// <summary>
        /// Variación acumulada del contrato (%)
        /// </summary>
        [Required] public double VariacionAcumuladaContratoPorcentaje { get; set; }

        /// <summary>
        /// Fecha de firma del Acta de Redeterminación de Precios con la contratista
        /// </summary>
        [Required] public DateTime FechaFirmaActa { get; set; }

        /// <summary>
        /// Fecha de aprobación (firma del acto administrativo)
        /// </summary>
        [Required] public DateTime FechaAprobacion { get; set; }

        /// <summary>
        /// Tabla VNR
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(256)] 
        public string TablaVnr { get; set; }

        /// <summary>
        /// Cómputo y presupuesto vigente
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(256)] 
        public string ComputoPresupuestoVigente { get; set; }

        /// <summary>
        /// Cómputo y presupuesto con adecuación provisoria/precios redeterminados
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(256)] 
        public string ComputoPresupuestoConAdecuaciónProvisoria { get; set; }

        /// <summary>
        /// Acto Administrativo que autoriza redeterminación/adecuación provisoria
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(256)] 
        public string ActoAdministrativoAutorizaRedeterminacion { get; set; }

        /// <summary>
        /// Acta de Redeterminación de Precios con la contratista
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(256)] 
        public string ActaRedeterminacionPreciosContratista { get; set; }

    }
}
