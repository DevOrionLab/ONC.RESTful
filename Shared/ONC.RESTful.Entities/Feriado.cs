using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;


namespace ONC.RESTful.Entities
{
    /// <summary>
    /// Representa una fila de datos de la tabla Feriado.
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class Feriado
    {
        [DataMember]
        [DisplayName("id")]
        public int id { get; set; }

        [DataMember]
        [DisplayName("dia")]
        public int dia { get; set; }

        [DataMember]
        [DisplayName("mes")]
        public int mes { get; set; }

        [DataMember]
        [DisplayName("ano")]
        public int ano { get; set; }

        [DataMember]
        [DisplayName("tipo")]
        public string tipo { get; set; }

        [DataMember]
        [DisplayName("fecha")]
        public DateTime fecha { get; set; }

        
        public override string ToString()
        {
            return this.GetType().Name + ": " +
                string.Join(",", this.GetType().GetProperties()
                .Where(p => !p.PropertyType.IsGenericType && !p.PropertyType.IsArray)
                .Select(p => string.Format("{0}={1}", p.Name, p.GetValue(this, null))));
        }
    }
}
