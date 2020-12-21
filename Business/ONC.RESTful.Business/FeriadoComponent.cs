//====================================================================================================
// Base code generated with Motion: BC Gen (Build 3.0.5701.25371)
// Layered Architecture Solution Guidance (http://layerguidance.codeplex.com)
//
// Generated by vh_co at LAPTOP-AI0568T3 on 12/18/2020 16:06:14 
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
        /// Add business method. 
        /// </summary>
        /// <param name="feriado">A feriado value.</param>
        /// <returns>Returns a Feriado object.</returns>
        public Feriado Add(Feriado feriado)
        {
            Feriado result = default(Feriado);

            // Data access component declarations.
            var feriadoDAC = new FeriadoDAC();

            // Step 1 - Calling Create on FeriadoDAC.
            result = feriadoDAC.Create(feriado);
            return result;

        }

        /// <summary>
        /// Remove business method. 
        /// </summary>
        /// <param name="id">A id value.</param>
        public void Remove(int id)
        {
            // Data access component declarations.
            var feriadoDAC = new FeriadoDAC();

            // Step 1 - Calling DeleteById on FeriadoDAC.
            feriadoDAC.DeleteById(id);

        }

        /// <summary>
        /// Select business method. 
        /// </summary>
        /// <returns>Returns a List<Feriado> object.</returns>
        public List<Feriado> Select()
        {
            List<Feriado> result = default(List<Feriado>);

            // Data access component declarations.
            var feriadoDAC = new FeriadoDAC();

            // Step 1 - Calling Select on FeriadoDAC.
            result = feriadoDAC.Select();
            return result;

        }

        /// <summary>
        /// Find business method. 
        /// </summary>
        /// <param name="id">A id value.</param>
        /// <returns>Returns a Feriado object.</returns>
        public Feriado Find(int id)
        {
            Feriado result = default(Feriado);

            // Data access component declarations.
            var feriadoDAC = new FeriadoDAC();

            // Step 1 - Calling SelectById on FeriadoDAC.
            result = feriadoDAC.SelectById(id);
            return result;

        }

        /// <summary>
        /// Edit business method. 
        /// </summary>
        /// <param name="feriado">A feriado value.</param>
        public void Edit(Feriado feriado)
        {
            // Data access component declarations.
            var feriadoDAC = new FeriadoDAC();

            // Step 1 - Calling UpdateById on FeriadoDAC.
            feriadoDAC.UpdateById(feriado);

        }
    }
}