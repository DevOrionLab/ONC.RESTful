using System.ComponentModel.DataAnnotations;

namespace ONC.RESTful.Entities.Obra
{
    /// <summary>
    /// 
    /// </summary>
    public class PenalidadSancionAplicada : IdentityBase
    {
        /// <summary>
        /// Motivo de multas o sanciones 
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(256)] 
        public string MotivoMultasSanciones { get; set; }

        /// <summary>
        /// Monto de las multas
        /// </summary>
        [Required] public double MontoMultas { get; set; }

    }
}