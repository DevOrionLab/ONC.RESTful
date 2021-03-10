using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ONC.RESTful.Entities.Enums;
using ONC.RESTful.Framework;

namespace ONC.RESTful.Entities.Obra
{
    public class IdentityBase
    {
        /// <summary>
        /// Valor numérico de solo lectura que representa al Número de Operación 
        /// </summary>
        [Key]
        [Required]
        //[JsonIgnore]
        public int Id { get; private set; }

        [JsonIgnore]
        [Required]
        public Guid TransactionId { get; internal set; }

        /// <summary>
        /// Valores: FrenteObra[1], DatosContrato[2]
        /// </summary>
        [Required]
        [EnumDataType(typeof(TipoEntidad))]
        public TipoEntidad TipoEntidad { get; set; }

        /// <summary>
        /// Cadena de caracteres que representan al Número Frente Obra o al Número de contrato 
        /// </summary>
        [Required]
        [MaxLength(256)]
        public string Numero { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        [JsonIgnore]
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IdentityBase()
        {
            this.CreatedOn = DateTime.Now;
            this.TransactionId = GuidComb.GenerateComb();
        }
    }
}
