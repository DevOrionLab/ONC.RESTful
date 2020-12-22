//====================================================================================================
// Business Component.
// ONC.RESTful.Business
//
// Generado por vcontreras on 19/12/2020
//====================================================================================================

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ONC.RESTful.Entities;
using ONC.RESTful.Data;


namespace ONC.RESTful.Business
{
    /// <summary>
    /// Feriado business component.
    /// </summary>
    public partial class FeriadoComponent
    {
        /// <summary>
        /// Add (Método de negocio) 
        /// </summary>
        /// <param name="feriado">Objeto feriado.</param>
        /// <returns>Returns a Feriado object.</returns>
        public Feriado Add(Feriado feriado)
        {
            Feriado result = default(Feriado);

            // Declaracion del componente de acceso a datos.
            var feriadoDAC = new FeriadoDAC();

            // Paso 1 - llamar a  Create en FeriadoDAC.
            result = feriadoDAC.Create(feriado);
            return result;

        }

        /// <summary>
        /// Remove (Método de negocio) 
        /// </summary>
        /// <param name="id">Valor del id.</param>
        public void Remove(int id)
        {
            // Declaracion del componente de acceso a datos.
            var feriadoDAC = new FeriadoDAC();

            // Paso 1 - llamar a  DeleteById en FeriadoDAC.
            feriadoDAC.DeleteById(id);

        }

        /// <summary>
        /// Select (Método de negocio) 
        /// </summary>
        /// <returns> List<Feriado></returns>
        public List<Feriado> Select()
        {
            List<Feriado> result = default(List<Feriado>);

            // Declaracion del componente de acceso a datos.
            var feriadoDAC = new FeriadoDAC();

            // Paso 1 - llamar a  Select en FeriadoDAC.
            result = feriadoDAC.Select();
            return result;

        }

        /// <summary>
        /// Find (Método de negocio) 
        /// </summary>
        /// <param name="id">Valor del id..</param>
        /// <returns>Returns a Feriado object.</returns>
        public Feriado Find(int id)
        {
            Feriado result = default(Feriado);

            // Declaracion del componente de acceso a datos.
            var feriadoDAC = new FeriadoDAC();

            // Paso 1 - llamar a  SelectById en FeriadoDAC.
            result = feriadoDAC.SelectById(id);
            return result;

        }

        /// <summary>
        /// Edit (Método de negocio) 
        /// </summary>
        /// <param name="feriado">Objecto feriado.</param>
        public void Edit(Feriado feriado)
        {
            // Declaracion del componente de acceso a datos.
            var feriadoDAC = new FeriadoDAC();

            // Paso 1 - llamar a  UpdateById en FeriadoDAC.
            feriadoDAC.UpdateById(feriado);

        }
    }
}
