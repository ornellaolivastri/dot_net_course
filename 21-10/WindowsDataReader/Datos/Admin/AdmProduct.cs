using Datos.Servidor;
using System.Data.SqlClient;
using Datos.Models;
using System.Data;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Admin
{
    public static class AdmProduct
    {
        /// <summary>
        /// Trae todos los productos de la base northwind
        /// </summary>
        /// <returns></returns>
        public static List<Product> Listar()
        {

            //una varibale con la consulta SQL
            string consultaSQL = "SELECT  ProductID      , ProductName       , SupplierID       , CategoryID       , QuantityPerUnit       , UnitPrice       , UnitsInStock       , UnitsOnOrder       , ReorderLevel       , Discontinued   FROM  dbo . Products";

            //Crear un objeto SqlCommand
            SqlCommand command = new SqlCommand(consultaSQL, AdminDB.ConectarBase());

            //declarar un objeto sqlDataReader
            SqlDataReader reader;

            //crear el objeto reader
            reader = command.ExecuteReader();

            //recorrer o leer los datos hacia adelante
            List<Product> list = new List<Product>();

            while (reader.Read())
            {
                list.Add(
                    new Product()
                    {
                        ProductID = (int)reader["ProductID"],
                        ProductName = reader[1].ToString(),
                        SupplierID = (int)reader["SupplierID"],
                        CategoryID = (int)reader["CategoryID"],
                        QuantityPerUnit = (string)reader["QuantityPerUnit"],
                        UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                        UnitsInStock = Convert.ToInt16(reader["UnitsInStock"]),
                        UnitsOnOrder = Convert.ToInt16(reader["UnitsOnOrder"]),
                        ReorderLevel = Convert.ToInt16(reader["ReorderLevel"]),
                        Discontinued = (bool)reader["Discontinued"]
                    }

                );
            }

            AdminDB.ConectarBase().Close(); //cerramos la coneccion
            reader.Close();

            return list;

        }


        public static List<Product> Listar(int CategoriaId)
        {

            //una varibale con la consulta SQL
            //AGREGAMOS EL WHERE PARA HACER UN FILTRO
            string consultaSQL = "SELECT  ProductID      , ProductName       , SupplierID       , CategoryID       , QuantityPerUnit       , UnitPrice       , UnitsInStock       , UnitsOnOrder       , ReorderLevel       , Discontinued   FROM  dbo . Products WHERE CategoryID=@CategoryID";

            //Crear un objeto SqlCommand
            SqlCommand command = new SqlCommand(consultaSQL, AdminDB.ConectarBase());

            //declarar parametro de sql (antes del execute)
            //AGREGAMOS ESTE PARAMETRO
            command.Parameters.Add("@CategoryID", SqlDbType.Int).Value = CategoriaId;

            //declarar un objeto sqlDataReader
            SqlDataReader reader;

            //crear el objeto reader
            reader = command.ExecuteReader();

            //recorrer o leer los datos hacia adelante
            List<Product> list = new List<Product>();

            while (reader.Read())
            {
                list.Add(
                    new Product()
                    {
                        ProductID = (int)reader["ProductID"],
                        ProductName = reader[1].ToString(),
                        SupplierID = (int)reader["SupplierID"],
                        CategoryID = (int)reader["CategoryID"],
                        QuantityPerUnit = (string)reader["QuantityPerUnit"],
                        UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                        UnitsInStock = Convert.ToInt16(reader["UnitsInStock"]),
                        UnitsOnOrder = Convert.ToInt16(reader["UnitsOnOrder"]),
                        ReorderLevel = Convert.ToInt16(reader["ReorderLevel"]),
                        Discontinued = (bool)reader["Discontinued"]
                    }

                );
            }

            AdminDB.ConectarBase().Close(); //cerramos la coneccion
            reader.Close();

            return list;

        }

    }
}
