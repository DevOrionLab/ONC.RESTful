using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Microsoft.Practices.EnterpriseLibrary.Data;
using ONC.RESTful.Entities;
using ONC.RESTful.Entities.Obra;

namespace ONC.RESTful.Data.Obra
{
    public class FrenteObraDac : DataAccessComponent
    {
        /// <summary>
        /// OBRA.FrenteObra.EstadoFrenteObra = 3  AND NumeroFrenteObra = '81-0001-FDO18'
        /// </summary>
        /// <param name="estado"> Valor numérico que representa el Estado del Frente de Obra.</param>
        /// <param name="numero"> Valor alfanumérico que representa el Número del Frente de Obra.</param>
        /// <returns>Devuelve un objeto FrenteObraGetEstadoNumero.</returns>
        public dynamic SelectByEstadoAndNumero(string numero, int estado)
        {
            const string SQL_STATEMENT = "[OBRA_SelectFrenteObraByNumeroAndEstado]";

            dynamic result = null;

            // Conexión a la base de datos.
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (var cmd = db.GetStoredProcCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@numero", DbType.String, numero);
                db.AddInParameter(cmd, "@estado", DbType.Int32, estado);

                using (var dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        result = dr.ToExpando();
                    }
                }
            }

            return result;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public bool GetByNumber(string numero)
        {
            const string SQL_STATEMENT = "SELECT NumeroFrenteObra FROM OBRA.FrenteObra WHERE NumeroFrenteObra = @numero";

            var result = false;

            // Conexión a la base de datos.
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (var cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@numero", DbType.String, numero);

                using (var dr = db.ExecuteReader(cmd))
                {
                    result = dr.Read();
                }
            }

            return result;

        }

        /// <summary>
        /// OBRA.FrenteObra.NumeroFrenteObra
        /// </summary>
        /// <param name="numero"> Valor alfanumérico que representa el Número del Frente de Obra.</param>
        /// <param name="idUnidadEjecutora"> Valor numérico que representa la Unidad Ejecutora.</param> 
        /// <returns>Devuelve un objeto dynamic.</returns>
        public List<dynamic> SelectByNumeroToExpando(string numero, long idUnidadEjecutora)
        {
            const string SQL_STATEMENT = "[OBRA_SelectFrenteObraByNumero]";

            var result = new List<dynamic>();
            // Conexión a la base de datos.
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (var cmd = db.GetStoredProcCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@numero", DbType.String, numero);
                db.AddInParameter(cmd, "@idUnidadEjecutora", DbType.Int64, idUnidadEjecutora);
                using (var dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        var item = dr.ToExpando();
                        result.Add(item);
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public dynamic SelectByNumeroContratoToExpando(string numeroContrato)
        {
            const string SQL_STATEMENT =
                "SELECT NumeroFrenteObra, NombreFrenteObra,NumeroObra, GrupoObra,TipoProyectoObra, razonSocialProveedor , cuitProveedor, numeroContrato FROM " +
                "OBRA.FrenteObra INNER JOIN OBRA.Obra ON OBRA.FrenteObra.IdObra = OBRA.Obra.Id INNER JOIN " +
                "OBRA.ObraDatosGenerales ON OBRA.Obra.IdObraDatosGenerales = OBRA.ObraDatosGenerales.Id INNER JOIN " +
                "OC.DocumentoContractual ON OBRA.FrenteObra.Id = OC.DocumentoContractual.IdFrenteObra AND OBRA.FrenteObra.Id = OC.DocumentoContractual.IdFrenteObra	" +
                "WHERE 	NumeroContrato = @numeroContrato";

            dynamic result = null;
            // Conexión a la base de datos.
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (var cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@numeroContrato", DbType.String, numeroContrato);
                using (var dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        result = dr.ToExpando();
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
        private FdoNumero ParseFrenteObraGetEstadoNumero(IDataReader dr)
        {
            var result = new FdoNumero
            {
                NombreFrenteObra = GetDataValue<string>(dr, "NombreFrenteObra"),
                NumeroFrenteObra = GetDataValue<string>(dr, "NumeroFrenteObra"),
                NumeroObra = GetDataValue<string>(dr, "NumeroObra"),
                TipoProyectoObra = GetDataValue<string>(dr, "TipoProyectoObra"),
                GrupoObra = GetDataValue<string>(dr, "GrupoObra"),
                RazonSocial = GetDataValue<string>(dr, "RazonSocial"),
                NumeroCUIT = GetDataValue<string>(dr, "NumeroCUIT")
            };

            return result;
        }
    }
}
