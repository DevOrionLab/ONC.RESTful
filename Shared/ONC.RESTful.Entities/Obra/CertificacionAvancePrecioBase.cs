using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using ONC.RESTful.Entities.Enums;

namespace ONC.RESTful.Entities.Obra
{
    public class CertificacionAvancePrecioBase : IdentityBase
    {
        

        /// <summary>
        /// N° de certificado
        /// </summary>
        [Required] public int NumeroCertificado { get; set; }


        /// <summary>
        /// N° EE del trámite
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(256)] 
        public string NumeroDelEE { get; set; }

        /// <summary>
        /// Tipo de certificado
        /// </summary>
        [Required] public TipoCertificado TipoCertificado { get; set; }

        /// <summary>
        /// Tipo de precios
        /// </summary>
        [Required] public TipoPrecio TipoPrecios { get; set; }

        /// <summary>
        /// Fecha inicio período
        /// </summary>
        [Required] public DateTime FechaInicioPeriodo { get; set; }

        /// <summary>
        /// Fecha fin período
        /// </summary>
        [Required] public DateTime FechaFinPeriodo { get; set; }

        /// <summary>
        /// Monto bruto del certificado a precios base
        /// </summary>
        [Required] public double MontoBrutoCertificadoPreciosBase { get; set; }

        /// <summary>
        /// Monto deducción Anticipo Financiero
        /// </summary>
        [Required] public double MontoDeduccionAnticipoFinanciero { get; set; }

        /// <summary>
        /// Monto deducción Fondo de Reparo a precios base
        /// </summary>
        [Required] public double MontoDeduccionFondoReparoPreciosBase { get; set; }

        /// <summary>
        /// Monto cubierto por garantía de Fondo de Reparo a precios base
        /// </summary>
        [Required] public double MontoCubiertoGarantiaFondoReparoPreciosBase { get; set; }

        /// <summary>
        /// Monto deducción por multas o sanciones
        /// </summary>
        [Required] public double MontoDeduccionMultasSanciones { get; set; }

        /// <summary>
        /// Monto de otras deducciones
        /// </summary>
        [Required] public double MontoOtrasDeducciones { get; set; }

        /// <summary>
        /// Descripción de otras deducciones
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(1000)] 
        public string DescripcionOtrasDeducciones { get; set; }

        /// <summary>
        /// Monto neto del certificado a precios base
        /// </summary>
        [Required] public double MontoNetoCertificadoPreciosBase { get; set; }

        /// <summary>
        /// Fecha de último pago
        /// </summary>
        [Required] public DateTime FechaUltimoPago { get; set; }

        /// <summary>
        /// Monto pagado
        /// </summary>
        [Required] public double MontoPagado { get; set; }

        /// <summary>
        /// Fecha de aprobación (firma del acto administrativo)
        /// </summary>
        [Required] public DateTime FechaAprobacion { get; set; }

        /// <summary>
        /// Acta de medición
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(256)] 
        public string ActaMedicion { get; set; }

        /// <summary>
        /// Registro fotográfico: ( permite varios archivos de este tipo, se genera un GEDO por cada archivo subido)
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(256)] 
        public string RegistroFotografico { get; set; }

        /// <summary>
        /// Certificado de Avance de Obra 
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(256)] 
        public string CertificadoAvanceObra { get; set; }

        /// <summary>
        /// Planilla de medición
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(256)] 
        public string PlanillaMedicion { get; set; }
    }
}