using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONC.RESTful.Framework
{
    public class CustomSqlException : Exception
    {
        public CustomSqlException()
        {
        }

        public CustomSqlException(string message, SqlException innerException) : base(message, innerException)
        {
        }
    }
    public static class Constants
    {
        public const int EXIT_FAILURE = -1;
    }
}
