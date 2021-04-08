using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ONC.RESTful.Entities.Obra
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    [DataContract]
    public class FdoNumero
    {
        /// <summary>
        /// Valor alfanumérico que representa el Número del Frente de Obra
        /// </summary>
        [DataMember]
        public string NumeroFrenteObra { get; set; }

        /// <summary>
        /// Valor alfanumérico que representa el Nombre del Frente de Obra
        /// </summary>
        [DataMember]
        public string NombreFrenteObra { get; set; }

        /// <summary>
        /// Valor alfanumérico que representa el Número Grupo de Obra
        /// </summary>
        [DataMember]
        public string NumeroObra { get; set; }

        /// <summary>
        /// Valor alfanumérico que representa el Nombre Grupo de Obra.
        /// </summary>
        [DataMember]
        public string GrupoObra { get; set; }

        /// <summary>
        /// Valor alfanumérico que representa el TipoProyectoObra.
        /// </summary>
        [DataMember]
        public string TipoProyectoObra { get; set; }
        
        /// <summary>
        /// Valor de cadena que representa la Razón Social
        /// </summary>
        [DataMember]
        public string RazonSocial { get; set; }

        /// <summary>
        /// Valor alfanumérico que representa el Número de CUIT
        /// </summary>
        [DataMember]
        public string NumeroCUIT { get; set; }

    }
}
