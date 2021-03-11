using System;
using System.ComponentModel.DataAnnotations;
using ONC.RESTful.Entities.Enums;

namespace ONC.RESTful.Entities.Obra
{
    /// <summary>
    /// 
    /// </summary>
    public class SuspensionObra : IdentityBase
    {
        /// <summary>
        /// Número de solicitud de modificación de obra
        /// </summary>
        public string NumeroSolicitudSuspensionObra { get; set; }

        /// <summary>
        /// Fecha vigente de finalización
        /// </summary>
        public DateTime FechaVigenteFinalizacion { get; set; }

        /// <summary>
        /// Cantidad del plazo de ejecución vigente
        /// </summary>
        public int CantidadPlazoEjecucionVigente { get; set; }

        /// <summary>
        /// Unidad de tiempo del plazo de ejecución vigente
        /// </summary>
        [Required] public TipoDia UnidadTiempoPlazoEjecucionVigente { get; set; }

        /// <summary>
        /// Motivo/Causa de la suspensión
        /// </summary>
        public string MotivoCausaLaSuspension { get; set; }

        /// <summary>
        /// Fecha de inicio de la suspensión
        /// </summary>
        public DateTime FechaInicioLaSuspension { get; set; }

        /// <summary>
        /// Fecha de reinicio de obra
        /// </summary>
        public DateTime FechaReinicioObra { get; set; }

        /// <summary>
        /// Fecha de aprobación (firma del acto administrativo)
        /// </summary>
        public DateTime FechaAprobacion { get; set; }

        /// <summary>
        /// Plazo de suspensión
        /// </summary>
        public int PlazoSuspension { get; set; }

        /// <summary>
        /// Nueva fecha de finalización de la obra
        /// </summary>
        public DateTime NuevaFechaFinalizacionLaObra { get; set; }

        /// <summary>
        /// N° GEDO Acto Administrativo aprobación
        /// </summary>
        public string NumeroGEDOActoAdministrativoAprobacion { get; set; }

        /// <summary>
        /// Acta de suspensión/neutralización
        /// </summary>
        public string ActaSuspensionNeutralizacion { get; set; }


        /// <summary>
        /// Plan de Trabajos vigente
        /// </summary>
        public string PlanTrabajosVigente { get; set; }

        /// <summary>
        /// Plan de Trabajos aprobado
        /// </summary>
        public string PlanTrabajosAprobado { get; set; }
    }
}