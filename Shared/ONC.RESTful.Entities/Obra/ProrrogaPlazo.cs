using System;
using System.ComponentModel.DataAnnotations;
using ONC.RESTful.Entities.Enums;

namespace ONC.RESTful.Entities.Obra
{
    /// <summary>
    /// 
    /// </summary>
    public class ProrrogaPlazo : IdentityBase
    {
        /// <summary>
        /// Número de solicitud de modificación de obra
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(256)] 
        public string NumeroSolicitudModificacionObra { get; set; }

        /// <summary>
        /// Fecha vigente de finalización
        /// </summary>
        [Required]
        public DateTime FechaVigenteFinalizacion { get; set; }

        /// <summary>
        /// Cantidad del plazo de ejecución vigente
        /// </summary>
        [Required] 
        public int CantidadPlazoEjecucionVigente { get; set; }

        /// <summary>
        /// Unidad de tiempo del plazo de ejecución vigente
        /// </summary>
        [Required] public TipoDia UnidadTiempoPlazoEjecucionVigente { get; set; }

        /// <summary>
        /// Motivo/Causa de la prórroga
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(1000)] 
        public string MotivoCausaLaProrroga { get; set; }

        /// <summary>
        /// Cantidad de días de plazo de prórroga solicitado
        /// </summary>
        [Required] 
        public int CantidadDiasPlazoProrrogaSolicitado { get; set; }

        /// <summary>
        /// Tipo de días de plazo de prórroga solicitado
        /// </summary>
        [Required] 
        public TipoDia TipoDiasPlazoProrrogaSolicitado { get; set; }

        /// <summary>
        /// Nueva fecha de finalización de obra
        /// </summary>
        [Required] 
        public DateTime NuevaFechaFinalizacionObra { get; set; }

        /// <summary>
        /// Cantidad de días de nuevo plazo de ejecución
        /// </summary>
        [Required] 
        public int CantidadDiasNuevoPlazoEjecucion { get; set; }

        /// <summary>
        /// Tipo de días de nuevo plazo de ejecución
        /// </summary>
        [Required] public TipoDia TipoDiasNuevoPlazoEjecucion { get; set; }

        /// <summary>
        /// N° GEDO Acto Administrativo aprobación
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(256)] 
        public string NumeroGEDOActoAdministrativoAprobacion { get; set; }

        /// <summary>
        /// Fecha de aprobación (firma del acto administrativo)
        /// </summary>
        [Required] 
        public DateTime FechaAprobacion { get; set; }

        /// <summary>
        /// Acto Administrativo
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(256)] 
        public string ActoAdministrativo { get; set; }

        /// <summary>
        /// Plan de Trabajos vigente
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(256)] 
        public string PlanTrabajosVigente { get; set; }

        /// <summary>
        /// Plan de Trabajos aprobado
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(256)] 
        public string PlanTrabajosAprobado { get; set; }
    }
}