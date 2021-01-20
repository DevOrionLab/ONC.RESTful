using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ONC.RESTful.Entities.Obra
{
    [Serializable]
    [DataContract]
    public class FrenteObraGetEstadoNumero
    {
        /// <summary>
        /// Valor alfanumérico que representa el Nombre del Frente de Obra
        /// </summary>
        [DataMember]
        public string NombreFrenteObra { get; set; }

        /// <summary>
        /// Valor alfanumérico que representa el Número del Frente de Obra
        /// </summary>
        [DataMember]
        public string NumeroFrenteObra { get; set; }

        /// <summary>
        /// Valor alfanumérico que representa el Nombre Grupo de Obra y Tipo Proyecto
        /// </summary>
        [DataMember]
        public string NombreGrupoObraTipoProyecto { get; set; }

        /// <summary>
        /// Valor alfanumérico que representa el Número Grupo de Obra
        /// </summary>
        [DataMember]
        public string NroGrupoObra { get; set; }

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
