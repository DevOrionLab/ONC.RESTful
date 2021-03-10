using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using ONC.RESTful.Entities.Enums;

namespace ONC.RESTful.Entities.Obra
{
    public class CertificacionAjusteRedeterminacion : IdentityBase
    {
        /// <summary>
        /// N° de certificado
        /// </summary>
        [Required] public int NumeroCertificado { get; set; }


        /// <summary>
        /// Tipo de certificado
        /// </summary>
        [Required] public TipoCertificado TipoCertificado { get; set; }

        /// <summary>
        /// N° Redeterminación
        /// </summary>
        [Required] public int NumeroRedeterminacion { get; set; }

        /// <summary>
        /// Tipo de procedimiento de redeterminación
        /// </summary>
        [Required] public TipoProcedimientoRedeterminacion TipoProcedimientoRedeterminacion { get; set; }

        /// <summary>
        /// Mes de salto/disparo última redeterminación aprobada
        /// </summary>
        [Required] public int MesSaltoUltimaRedeterminacionAprobada { get; set; }

        /// <summary>
        /// Año de salto/disparo última redeterminación aprobada
        /// </summary>
        [Required] 
        public int AnioSaltoUltimaRedeterminacionAprobada { get; set; }

        /// <summary>
        /// Fecha inicio período
        /// </summary>
        [Required] 
        public DateTime FechaInicioPeriodo { get; set; }

        /// <summary>
        /// Fecha fin período
        /// </summary>
        [Required] 
        public DateTime FechaFinPeriodo { get; set; }

        /// <summary>
        /// Monto bruto del certificado de ajuste por redeterminación
        /// </summary>
        [Required] public double MontoBrutoCertificadoAjusteRedeterminacion { get; set; }

        /// <summary>
        /// Monto deducción Fondo de Reparo
        /// </summary>
        [Required] public double MontoDeduccionFondoReparo { get; set; }

        /// <summary>
        /// Monto cubierto por garantía de Fondo de Reparo
        /// </summary>
        [Required] public double MontoCubiertoGarantiaFondoReparo { get; set; }

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
        /// Monto neto del certificado de ajuste por redeterminación
        /// </summary>
        [Required] public double MontoNetoCertificadoAjusteRedeterminacion { get; set; }

        /// <summary>
        /// Fecha de firma de la autorización del pago
        /// </summary>
        [Required] public DateTime FechaFirmaAutorizacionPago { get; set; }

        /// <summary>
        /// Certificado de ajuste por redeterminación
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(256)] 
        public string CertificadoAjusteRedeterminacion { get; set; }

        /// <summary>
        /// Planilla de medición de certificado de ajuste por redeterminación
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(256)] 
        public string PlanillaMedicionCertificadoAjusteRedeterminacion { get; set; }

    }
}
