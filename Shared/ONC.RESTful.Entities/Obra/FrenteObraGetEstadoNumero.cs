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
        /// NombreFrenteObra
        /// </summary>
        [DataMember]
        public string NombreFrenteObra { get; set; }

        /// <summary>
        /// NumeroFrenteObra
        /// </summary>
        [DataMember]
        public string NumeroFrenteObra { get; set; }

        /// <summary>
        /// NombreGrupoObraTipoProyecto
        /// </summary>
        [DataMember]
        public string NombreGrupoObraTipoProyecto { get; set; }

        /// <summary>
        /// NroGrupoObra
        /// </summary>
        [DataMember]
        public string NroGrupoObra { get; set; }

        /// <summary>
        /// RazonSocial
        /// </summary>
        [DataMember]
        public string RazonSocial { get; set; }

        /// <summary>
        /// NumeroCUIT
        /// </summary>
        [DataMember]
        public string NumeroCUIT { get; set; }

    }
}
