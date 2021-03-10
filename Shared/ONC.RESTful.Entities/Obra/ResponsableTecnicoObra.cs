using System.ComponentModel.DataAnnotations;

namespace ONC.RESTful.Entities.Obra
{
    /// <summary>
    /// 
    /// </summary>
    public class ResponsableTecnicoObra : IdentityBase
    {
        /// <summary>
        /// Cadena de caracteres que representa el Nombre
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(256)]
        public string Nombre { get; set; }

        /// <summary>
        /// Cadena de caracteres que representa el Titulo
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(256)]
        public string Titulo { get; set; }

        /// <summary>
        /// Cadena de caracteres que representa la Matricula
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(256)]
        public string Matricula { get; set; }
    }
}