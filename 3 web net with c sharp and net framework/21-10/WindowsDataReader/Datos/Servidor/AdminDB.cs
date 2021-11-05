using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace Datos.Servidor
{
    internal static class AdminDB
    {

        /// <summary>
        /// Funcion que permite establecer la coneccion con la base northwind
        /// </summary>
        /// <returns>retorna el objeto de coneccion</returns>
        internal static SqlConnection ConectarBase()

        {
           string cadena = Datos.Properties.Settings.Default.KeyDBNorthwind;
            SqlConnection connection = new SqlConnection(cadena);
            connection.Open();
            return connection;

        }
       
    }
}
