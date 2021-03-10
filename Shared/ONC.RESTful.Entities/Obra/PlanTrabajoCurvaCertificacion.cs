using System;
using System.ComponentModel.DataAnnotations;

namespace ONC.RESTful.Entities.Obra
{
    /// <summary>
    /// 
    /// </summary>
    public class PlanTrabajoCurvaCertificacion : IdentityBase
    {
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
        public string NumeroEE { get; set; }

        /// <summary>
        /// Motivo/Causa de la modificación de plan de trabajo
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(1000)] 
        public string MotivoCausaModificacion { get; set; }

        /// <summary>
        /// Fecha de aprobación
        /// </summary>
        [Required] public DateTime FechaAprobacion { get; set; }

        /// <summary>
        /// Plan de trabajos original (propuesta)
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(256)] 
        public string PlanTrabajosOriginal { get; set; }

        /// <summary>
        /// Curva de Certificación original (propuesta)
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(256)] 
        public string CurvaCertificaciónOriginal { get; set; }

        /// <summary>
        /// Plan de trabajos real (actualizada mes a mes)
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(256)] 
        public string PlanTrabajosReal { get; set; }

        /// <summary>
        /// Curva de Certificación real (actualizada mes a mes)
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(256)] 
        public string CurvaCertificaciónReal { get; set; }
    }
}