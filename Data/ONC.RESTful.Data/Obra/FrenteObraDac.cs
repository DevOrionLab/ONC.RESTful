using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using ONC.RESTful.Entities;
using ONC.RESTful.Entities.Obra;

namespace ONC.RESTful.Data.Obra
{
    public class FrenteObraDac : DataAccessComponent
    {
        /// <summary>
        /// COMPRAS_NACION.OBRA.FrenteObra.EstadoFrenteObra = 3  AND NumeroFrenteObra = '81-0001-FDO18'
        /// </summary>
        /// <param name="estado"> Valor numérico que representa el Estado del Frente de Obra.</param>
        /// <param name="numero"> Valor alfanumérico que representa el Número del Frente de Obra.</param>
        /// <returns>Devuelve un objeto FrenteObraGetEstadoNumero.</returns>
        public FrenteObraGetEstadoNumero SelectByEstadoAndNumero(int estado, string numero)
        {
            const string SQL_STATEMENT =
                "SELECT NombreFrenteObra, NumeroFrenteObra, NombreObra as NombreGrupoObra_tipoProyecto, NumeroObra as NroGrupoObra,   RazonSocial,  NumeroCUIT " +
                "FROM COMPRAS_NACION.OBRA.FrenteObra " +
                "INNER JOIN COMPRAS_NACION.OBRA.FrenteObraDatosGenerales ON COMPRAS_NACION.OBRA.FrenteObra.IdDatosGenerales = COMPRAS_NACION.OBRA.FrenteObraDatosGenerales.Id " +
                "INNER JOIN COMPRAS_NACION.OBRA.Obra ON COMPRAS_NACION.OBRA.FrenteObra.IdObra = COMPRAS_NACION.OBRA.Obra.Id " +
                "INNER JOIN COMPRAS_NACION.OBRA.ObraDatosGenerales ON COMPRAS_NACION.OBRA.ObraDatosGenerales.Id = COMPRAS_NACION.OBRA.Obra.IdObraDatosGenerales " +
                "INNER JOIN COMPRAS_NACION.RPP.Proveedor ON COMPRAS_NACION.OBRA.FrenteObra.IdContratista = COMPRAS_NACION.RPP.Proveedor.IdProveedor " +
                "INNER JOIN COMPRAS_NACION.RPP.Empresa ON COMPRAS_NACION.RPP.Proveedor.IdEmpresa = COMPRAS_NACION.RPP.Empresa.IdEmpresa " +
                "WHERE COMPRAS_NACION.OBRA.FrenteObra.EstadoFrenteObra=@estado AND NumeroFrenteObra =@numero";

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
        /// COMPRAS_NACION.OBRA.FrenteObra.EstadoFrenteObra = 3  AND NumeroFrenteObra = '81-0001-FDO18'
        /// </summary>
        /// <param name="estado"> Valor numérico que representa el Estado del Frente de Obra.</param>
        /// <param name="numero"> Valor alfanumérico que representa el Número del Frente de Obra.</param>
        /// <returns>Devuelve un objeto dynamic.</returns>
        public dynamic SelectByEstadoAndNumeroToExpando(int estado, string numero)
        {
            const string SQL_STATEMENT =
                "SELECT NombreFrenteObra, NumeroFrenteObra, NombreObra as NombreGrupoObra_tipoProyecto, NumeroObra as NroGrupoObra,   RazonSocial,  NumeroCUIT " +
                "FROM COMPRAS_NACION.OBRA.FrenteObra " +
                "INNER JOIN COMPRAS_NACION.OBRA.FrenteObraDatosGenerales ON COMPRAS_NACION.OBRA.FrenteObra.IdDatosGenerales = COMPRAS_NACION.OBRA.FrenteObraDatosGenerales.Id " +
                "INNER JOIN COMPRAS_NACION.OBRA.Obra ON COMPRAS_NACION.OBRA.FrenteObra.IdObra = COMPRAS_NACION.OBRA.Obra.Id " +
                "INNER JOIN COMPRAS_NACION.OBRA.ObraDatosGenerales ON COMPRAS_NACION.OBRA.ObraDatosGenerales.Id = COMPRAS_NACION.OBRA.Obra.IdObraDatosGenerales " +
                "INNER JOIN COMPRAS_NACION.RPP.Proveedor ON COMPRAS_NACION.OBRA.FrenteObra.IdContratista = COMPRAS_NACION.RPP.Proveedor.IdProveedor " +
                "INNER JOIN COMPRAS_NACION.RPP.Empresa ON COMPRAS_NACION.RPP.Proveedor.IdEmpresa = COMPRAS_NACION.RPP.Empresa.IdEmpresa " +
                "WHERE COMPRAS_NACION.OBRA.FrenteObra.EstadoFrenteObra=@estado AND NumeroFrenteObra =@numero";

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
