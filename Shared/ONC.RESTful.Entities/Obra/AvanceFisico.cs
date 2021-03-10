using System.ComponentModel.DataAnnotations;

namespace ONC.RESTful.Entities.Obra
{
    /// <summary>
    /// 
    /// </summary>
    public class AvanceFisico : IdentityBase
    {
        /// <summary>
        /// % de avance físico certificado.
        /// </summary>
        [Required] 
        public double AvanceFisicoCertificado { get; set; }

        /// <summary>
        /// % de avance físico acumulado.
        /// </summary>
        [Required] 
        public double AvanceFisicoAcumulado { get; set; }
    }
}