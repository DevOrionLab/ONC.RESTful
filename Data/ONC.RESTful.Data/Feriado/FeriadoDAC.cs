//====================================================================================================
// Data Access Component
// ONC.RESTful.Data
//
// Generado por vcontreras on 19/12/2020
//====================================================================================================

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using ONC.RESTful.Entities;

namespace ONC.RESTful.Data
{

    /// <summary>
    /// Feriado. componente de acceso a datos. Gestiona las operaciones CRUD para la tabla Feriado.
    /// </summary>
    public partial class FeriadoDAC : DataAccessComponent
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="feriado"></param>
        /// <returns></returns>
        public Feriado Create(Feriado feriado)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.Feriado ([dia], [mes], [ano], [tipo], [fecha]) " +
                "VALUES(@dia, @mes, @ano, @tipo, @fecha); SELECT SCOPE_IDENTITY();";

            // Connect to database.
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@dia", DbType.Int32, feriado.dia);
                db.AddInParameter(cmd, "@mes", DbType.Int32, feriado.mes);
                db.AddInParameter(cmd, "@ano", DbType.Int32, feriado.ano);
                db.AddInParameter(cmd, "@tipo", DbType.AnsiString, feriado.tipo);
                db.AddInParameter(cmd, "@fecha", DbType.DateTime, feriado.fecha);

                // Get the primary key value.
                feriado.id = Convert.ToInt32(db.ExecuteScalar(cmd));
            }

            return feriado;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="feriado"></param>
        public void UpdateById(Feriado feriado)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.Feriado " +
                "SET " +
                    "[dia]=@dia, " +
                    "[mes]=@mes, " +
                    "[ano]=@ano, " +
                    "[tipo]=@tipo, " +
                    "[fecha]=@fecha " +
                "WHERE [id]=@id ";

            // Connect to database.
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@dia", DbType.Int32, feriado.dia);
                db.AddInParameter(cmd, "@mes", DbType.Int32, feriado.mes);
                db.AddInParameter(cmd, "@ano", DbType.Int32, feriado.ano);
                db.AddInParameter(cmd, "@tipo", DbType.AnsiString, feriado.tipo);
                db.AddInParameter(cmd, "@fecha", DbType.DateTime, feriado.fecha);
                db.AddInParameter(cmd, "@id", DbType.Int32, feriado.id);

                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void DeleteById(int id)
        {
            const string SQL_STATEMENT = "DELETE dbo.Feriado " +
                                         "WHERE [id]=@id ";

            // Connect to database.
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@id", DbType.Int32, id);


                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Feriado SelectById(int id)
        {
            const string SQL_STATEMENT =
                "SELECT [id], [dia], [mes], [ano], [tipo], [fecha] " +
                "FROM dbo.Feriado  " +
                "WHERE [id]=@id ";

            Feriado feriado = null;

            // Connect to database.
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@id", DbType.Int32, id);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new Feriado
                        feriado = LoadFeriado(dr);
                    }
                }
            }

            return feriado;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Feriado> Select()
        {
            const string SQL_STATEMENT =
                "SELECT [id], [dia], [mes], [ano], [tipo], [fecha] " +
                "FROM dbo.Feriado ";

            List<Feriado> result = new List<Feriado>();

            // Connect to database.
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new Feriado
                        Feriado feriado = LoadFeriado(dr);

                        // Add to List.
                        result.Add(feriado);
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        private Feriado LoadFeriado(IDataReader dr)
        {
            // Create a new Feriado
            Feriado feriado = new Feriado();

            // Read values.
            feriado.id = GetDataValue<int>(dr, "id");
            feriado.dia = GetDataValue<int>(dr, "dia");
            feriado.mes = GetDataValue<int>(dr, "mes");
            feriado.ano = GetDataValue<int>(dr, "ano");
            feriado.tipo = GetDataValue<string>(dr, "tipo");
            feriado.fecha = GetDataValue<DateTime>(dr, "fecha");

            return feriado;
        }
    }
}

