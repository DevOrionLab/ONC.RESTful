using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ONC.RESTful.Framework;

namespace ONC.RESTful.Entities.Obra 
{
    /// <summary>
    /// 
    /// </summary>
    public class ActaInicioObra : IdentityBase
    {
        /// <summary>
        /// Fecha del Acta de Inicio
        /// </summary>
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Fecha { get; set; }

        /// <summary>
        /// Acta de Inicio. Formato hash Blockchain Federal Argentina
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(256)]
        public string ActaDeInicio { get; set; }
    }
}
