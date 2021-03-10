using ONC.RESTful.Entities.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace ONC.RESTful.Entities.Obra
{
    /// <summary>
    /// 28. Ampliaciones, adicionales, economías y/o demasías.
    /// </summary>
    public class AmpliacionAdicional : IdentityBase
    {
        /// <summary>
        /// Número de solicitud de modificación de obra
        /// </summary>
        [Required] public string NumeroSolicitud { get; set; }

        /// <summary>
        /// Fecha vigente de finalización
        /// </summary>
        [Required] public DateTime FechaVigenteFinalizacion { get; set; }

        /// <summary>
        /// Cantidad del plazo de ejecución vigente
        /// </summary>
        [Required] public int CantidadPlazoEjecucionVigente { get; set; }

        /// <summary>
        /// Unidad de tiempo del plazo de ejecución vigente
        /// </summary>
        [Required] public TipoDia UnidadTiempoPlazoEjecucionVigente { get; set; }

        /// <summary>
        /// Monto original del contrato
        /// </summary>
        [Required] public double MontoOriginalContrato { get; set; }

        /// <summary>
        /// Tipo de modificación
        /// </summary>
        [Required] public TipoModificacion TipoModificacion { get; set; }

        /// <summary>
        /// Motivo/Causa de la modificación
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(2000)] 
        public string MotivoCausaModificacion { get; set; }

        /// <summary>
        /// Monto de variación del contrato a precios base
        /// </summary>
        [Required] public double MontoVariacionContratoPreciosBase { get; set; }

        /// <summary>
        /// Variación del contrato a precios base (%)
        /// </summary>
        [Required] public double VariacionContratoPreciosBase { get; set; }

        /// <summary>
        /// Nuevo monto de contrato aprobado
        /// </summary>
        [Required] public double NuevoMontoContratoAprobado { get; set; }

        /// <summary>
        /// Variación por economías (%)
        /// </summary>
        [Required] public double VariacionPorEconomias { get; set; }

        /// <summary>
        /// Variación por demasías y/o adicionales (%)
        /// </summary>
        [Required] public double VariacionPorDemasiasAdicionales { get; set; }

        /// <summary>
        /// Variación acumulada del contrato a precios base (%)
        /// </summary>
        [Required] public double VariacionAcumuladaContratoPreciosBase { get; set; }

        /// <summary>
        /// Fecha de aprobación (firma del acto administrativo)
        /// </summary>
        [Required] public DateTime FechaAprobacion { get; set; }

        /// <summary>
        /// Incluye prórroga de plazo
        /// </summary>
        [Required] public TipoIncluyeProrrogaPlazo IncluyeProrrogaPlazo { get; set; }

        /// <summary>
        /// Cantidad de días de plazo de prórroga
        /// </summary>
        [Required] public int CantidadDiasPlazoProrroga { get; set; }

        /// <summary>
        /// Tipo de días del plazo de prórroga
        /// </summary>
        [Required] public TipoDia TipoDiasPlazoProrroga { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required] public DateTime NuevaFechaFinalizacionObra { get; set; }

        /// <summary>
        /// Nueva fecha de finalización de la obra
        /// </summary>
        [Required] public int NuevoPlazoEjecucionObra { get; set; }

        /// <summary>
        /// Nuevo tipo de plazo de ejecución de la obra
        /// </summary>
        [Required] public TipoDia NuevoTipoPlazoEjecucionObra { get; set; }

        /// <summary>
        /// N° GEDO Acto Administrativo aprobación
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(256)]
        public string NumeroGedoActoAdministrativoAprobacion { get; set; }

        /// <summary>
        /// Balance de Economías y Demasías
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(1000)] 
        public string BalanceEconomiasDemasias { get; set; }
    }
}