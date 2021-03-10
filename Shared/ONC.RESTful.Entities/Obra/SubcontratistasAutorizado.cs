using System.ComponentModel.DataAnnotations;

namespace ONC.RESTful.Entities.Obra
{
    public class SubcontratistaAutorizado : IdentityBase
    {
        /// <summary>
        /// Nombre de la Sub Contratista
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(256)]
        public string NombreSubContratista { get; set; }

        /// <summary>
        /// CUIT de la Sub Contratista
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(13)] 
        public string CUITSubContratista { get; set; }

        /// <summary>
        /// Tarea
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(256)] 
        public string Tarea { get; set; }

        /// <summary>
        /// Representante Técnico
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(256)] 
        public string RepresentanteTecnico { get; set; }

    }
}