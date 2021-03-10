using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using ONC.RESTful.Entities.Enums;

namespace ONC.RESTful.Entities.Obra
{
    /// <summary>
    /// 
    /// </summary>
    public class CertificacionAvancePrecioRedeterminado : IdentityBase
    {

        public int Id { get; set; }

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
        /// Fecha inicio período
        /// </summary>
        [Required] public DateTime FechaInicioPeriodo { get; set; }

        /// <summary>
        /// Fecha fin período
        /// </summary>
        [Required] public DateTime FechaFinPeriodo { get; set; }

        /// <summary>
        /// Tipo de precios
        /// </summary>
        [Required] public TipoPrecio TipoPrecios { get; set; }

        /// <summary>
        /// N° redeterminación
        /// </summary>
        [Required] public int NumeroRedeterminacion { get; set; }

        /// <summary>
        /// Tipo de procedimiento
        /// </summary>
        [Required] public TipoProcedimientoRedeterminacion TipoProcedimiento { get; set; }

        /// <summary>
        /// Mes de salto/disparo última redeterminación aprobada
        /// </summary>
        [Required] public int MesSaltoUltimaRedeterminacionAprobada { get; set; }

        /// <summary>
        /// Año de salto/disparo última redeterminación aprobada
        /// </summary>
        [Required] public DateTime AnioSaltoUltimaRedeterminacionAprobada { get; set; }

        /// <summary>
        /// Monto bruto del certificado a precios base
        /// </summary>
        [Required] public double MontoBrutoCertificadoPreciosBase { get; set; }

        /// <summary>
        /// Monto deducción Anticipo Financiero
        /// </summary>
        [Required] public double MontoDeduccionAnticipoFinanciero { get; set; }

        /// <summary>
        /// Monto bruto del certificado a precios redeterminados
        /// </summary>
        [Required] public double MontoBrutoCertificadoPreciosRedeterminados { get; set; }

        /// <summary>
        /// Monto deducción Fondo de Reparo a precios redeterminados
        /// </summary>
        [Required] public double MontoDeduccionFondoReparoPreciosRedeterminados { get; set; }

        /// <summary>
        /// Monto cubierto por garantía de Fondo de Reparo a precios redeterminados
        /// </summary>
        [Required] public double MontoCubiertoGarantiaFondoReparoPreciosRedeterminados { get; set; }

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
        [Required] public string DescripcionOtrasDeducciones { get; set; }

        /// <summary>
        /// Monto neto del certificado a precios redeterminados
        /// </summary>
        [Required] public double MontoNetoCertificadoPreciosRedeterminados { get; set; }

        /// <summary>
        /// N° GEDO Certificado aprobado
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(256)] 
        public string NumeroGedoCertificadoAprobado { get; set; }

        /// <summary>
        /// % de avance físico certificado
        /// </summary>
        [Required] public double AvanceFisicoCertificado { get; set; }

        /// <summary>
        /// % de avance físico acumulado
        /// </summary>
        [Required] public double AvanceFisicoAcumulado { get; set; }

        /// <summary>
        /// Fecha de firma de la autorización del pago
        /// </summary>
        [Required] public DateTime FechaFirmaAutorizacionPago { get; set; }

        /// <summary>
        /// Fecha de último pago
        /// </summary>
        [Required] public DateTime FechaUltimoPago { get; set; }

        /// <summary>
        /// Tipo de pago
        /// </summary>
        [Required] public TipoPago TipoPago { get; set; }

        /// <summary>
        /// Monto pagado
        /// </summary>
        [Required] public double MontoPagado { get; set; }

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
