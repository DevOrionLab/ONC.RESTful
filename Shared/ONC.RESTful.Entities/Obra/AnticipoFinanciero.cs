using ONC.RESTful.Entities.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace ONC.RESTful.Entities.Obra
{
    
    
    /// <summary>
    /// 27. Anticipo financiero.
    /// </summary>
    public class AnticipoFinanciero : IdentityBase
    {
        /// <summary>
        /// Valor alfanumérico que representa el Número de solicitud
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(256)]
        public string NumeroSolicitud { get; set; }

        /// <summary>
        /// Fecha de solicitud
        /// </summary>
        [Required] public DateTime FechaSolicitud { get; set; }

        /// <summary>
        /// Valor alfanumérico que representa el N° EE del trámite
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(256)] 
        public string NumeroEE { get; set; }

        /// <summary>
        /// Valor numérico que representa el Monto de Anticipo Financiero solicitado
        /// </summary>
        [Required] public double MontoAnticipoFinancieroSolicitado { get; set; }

        /// <summary>
        /// Combo que representa Modalidad de pago de anticipo financiero
        /// </summary>
        [Required] public TipoModalidadPagoAnticipo ModalidadPagoAnticipoFinanciero { get; set; }

        /// <summary>
        /// Fecha de último pago
        /// </summary>
        [Required] public DateTime FechaUltimoPago { get; set; }

        /// <summary>
        /// Valor numérico que representa el Monto pagado
        /// </summary>
        [Required] public double MontoPagado { get; set; }

        /// <summary>
        /// Fecha de firma de la autorización del pago
        /// </summary>
        [Required] public DateTime FechaFirmaAutorizacionPago { get; set; }
    }
}