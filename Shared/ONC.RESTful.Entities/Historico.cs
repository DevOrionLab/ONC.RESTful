//====================================================================================================
// Entities
// ONC.RESTful.Entities
//
// Generado por vcontreras on 22/12/2020
//====================================================================================================

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;


namespace ONC.RESTful.Entities
{
    
    [Serializable]
    [DataContract]
    public partial class Historico
    {
        
        [DataMember]
        public int IdHistorico { get; set; }

        
        [DataMember]
        public int Idint { get; set; }

       
        [DataMember]
        public Guid Iduniq { get; set; }

       
        [DataMember]
        public string nombre { get; set; }

       
        [DataMember]
        public string comentario { get; set; }

      
        [DataMember]
        public DateTime fecha { get; set; }

       
        [DataMember]
        public Guid usuario { get; set; }

       
        [DataMember]
        public string nombreusuario { get; set; }

        
        [DataMember]
        public bool estado { get; set; }

        
        [DataMember]
        public int tipo { get; set; }
    }
}
