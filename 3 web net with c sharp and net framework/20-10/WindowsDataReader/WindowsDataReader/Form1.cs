using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsDataReader.Models;

namespace WindowsDataReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTraerProductos_Click(object sender, EventArgs e)
        {
            //READER

            //una variable para leer la cadena de conexion en App.config
            string cadena = WindowsDataReader.Properties.Settings.Default.KeyNorthwind;

            //agrego el using del proveedor de BD con el que trabajamos

            //creamos un objeto de conexion con la clase SqlConnection
            SqlConnection connection = new SqlConnection(cadena);

            //una varibale con la consulta SQL
            string consultaSQL = "SELECT  ProductID      , ProductName       , SupplierID       , CategoryID       , QuantityPerUnit       , UnitPrice       , UnitsInStock       , UnitsOnOrder       , ReorderLevel       , Discontinued   FROM  dbo . Products ";

            //Crear un objeto SqlCommand
            SqlCommand command = new SqlCommand(consultaSQL, connection);

            //declarar un objeto sqlDataReader
            SqlDataReader reader;

            //antes de ejecutar se debe abrir la coneccion
            connection.Open();


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

            //cerrar la conexión a la Base de datos y cerrar reader
            connection.Close();
            reader.Close();
            gridProductos.DataSource = list;

        }
    }
}
