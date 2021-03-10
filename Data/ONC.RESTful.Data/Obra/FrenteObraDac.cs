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
        public FrenteObraGetEstadoNumero SelectByEstadoAndNumero(int estado, string numero)
        {
            const string SQL_STATEMENT =
                "SELECT NombreFrenteObra, NumeroFrenteObra, NombreObra as NombreGrupoObra_tipoProyecto, NumeroObra as NroGrupoObra,   RazonSocial,  NumeroCUIT " +
                "FROM OBRA.FrenteObra " +
                "INNER JOIN OBRA.FrenteObraDatosGenerales ON OBRA.FrenteObra.IdDatosGenerales = OBRA.FrenteObraDatosGenerales.Id " +
                "INNER JOIN OBRA.Obra ON OBRA.FrenteObra.IdObra = OBRA.Obra.Id " +
                "INNER JOIN OBRA.ObraDatosGenerales ON OBRA.ObraDatosGenerales.Id = OBRA.Obra.IdObraDatosGenerales " +
                "INNER JOIN RPP.Proveedor ON OBRA.FrenteObra.IdContratista = RPP.Proveedor.IdProveedor " +
                "INNER JOIN RPP.Empresa ON RPP.Proveedor.IdEmpresa = RPP.Empresa.IdEmpresa " +
                "WHERE OBRA.FrenteObra.EstadoFrenteObra=@estado AND NumeroFrenteObra =@numero";

            FrenteObraGetEstadoNumero result = null;

            // Conexión a la base de datos.
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@estado", DbType.Int32, estado);
                db.AddInParameter(cmd, "@numero", DbType.String, numero);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        result = ParseFrenteObraGetEstadoNumero(dr);
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
        /// OBRA.FrenteObra.EstadoFrenteObra = 3  AND NumeroFrenteObra = '81-0001-FDO18'
        /// </summary>
        /// <param name="estado"> Valor numérico que representa el Estado del Frente de Obra.</param>
        /// <param name="numero"> Valor alfanumérico que representa el Número del Frente de Obra.</param>
        /// <returns>Devuelve un objeto dynamic.</returns>
        public dynamic SelectByEstadoAndNumeroToExpando(int estado, string numero)
        {
            const string SQL_STATEMENT =
                "SELECT NombreFrenteObra, NumeroFrenteObra, NombreObra as NombreGrupoObra_tipoProyecto, NumeroObra as NroGrupoObra,   RazonSocial,  NumeroCUIT " +
                "FROM OBRA.FrenteObra " +
                "INNER JOIN OBRA.FrenteObraDatosGenerales ON OBRA.FrenteObra.IdDatosGenerales = OBRA.FrenteObraDatosGenerales.Id " +
                "INNER JOIN OBRA.Obra ON OBRA.FrenteObra.IdObra = OBRA.Obra.Id " +
                "INNER JOIN OBRA.ObraDatosGenerales ON OBRA.ObraDatosGenerales.Id = OBRA.Obra.IdObraDatosGenerales " +
                "INNER JOIN RPP.Proveedor ON OBRA.FrenteObra.IdContratista = RPP.Proveedor.IdProveedor " +
                "INNER JOIN RPP.Empresa ON RPP.Proveedor.IdEmpresa = RPP.Empresa.IdEmpresa " +
                "WHERE OBRA.FrenteObra.EstadoFrenteObra=@estado AND NumeroFrenteObra =@numero";

            dynamic result = null;

            // Conexión a la base de datos.
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@estado", DbType.Int32, estado);
                db.AddInParameter(cmd, "@numero", DbType.String, numero);

                using (IDataReader dr = db.ExecuteReader(cmd))
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
        private FrenteObraGetEstadoNumero ParseFrenteObraGetEstadoNumero(IDataReader dr)
        {
            var result = new FrenteObraGetEstadoNumero();

            // Leer valores.
            result.NombreFrenteObra = GetDataValue<string>(dr, "NombreFrenteObra");
            result.NumeroFrenteObra = GetDataValue<string>(dr, "NumeroFrenteObra");
            result.NombreGrupoObraTipoProyecto = GetDataValue<string>(dr, "NombreGrupoObra_tipoProyecto");
            result.NroGrupoObra = GetDataValue<string>(dr, "NroGrupoObra");
            result.RazonSocial = GetDataValue<string>(dr, "RazonSocial");
            result.NumeroCUIT = GetDataValue<string>(dr, "NumeroCUIT");

            return result;
        }
    }
}
