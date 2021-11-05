using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WindowsEFLinq.Data;
using System.Linq;

namespace WindowsEFLinq
{
    public partial class Form1 : Form
    {
        //crear una instancia de entity framework
        NorthwindContext context = new NorthwindContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTraerTodo_Click(object sender, EventArgs e)
        {
            //traemos todos los productos
            var lista = (from p in context.Products
                         select p).ToList();

            gridProductos.DataSource = lista;
        }

        private void btnTraerPorCategoria_Click(object sender, EventArgs e)
        {
            var lista = (from p in context.Products
                         where p.CategoryID == 2
                         select p).ToList();

            gridProductos.DataSource = lista;

        }

        private void btnTraerPorNombreProducto_Click(object sender, EventArgs e)
        {
            string nombreProducto = "Queso Cabrales";

            var producto = (from p in context.Products
                            where p.ProductName == nombreProducto
                            select p).SingleOrDefault();

            //no se pueden mostrar objetos en una grid, entonces lo mostramos en un message box
            MessageBox.Show(producto.ProductName + " " + producto.UnitPrice.ToString());
        }


        private void btnTraerPorID_Click(object sender, EventArgs e)
        {
            int id = 2;

            var producto = (from p in context.Products
                            where p.ProductID == id
                            select p).SingleOrDefault();

            MessageBox.Show(producto.ProductName + " " + producto.UnitPrice.ToString());

        }

        private void btnTraerProductoCategoria_Click(object sender, EventArgs e)
        {
            var lista = (from
                         c in context.Categories
                         join
                         p in context.Products
                         on c.CategoryID equals p.CategoryID
                         select new
                         //tipo anonimo
                         {
                             c.CategoryID, 
                             c.CategoryName,
                             Product = p.ProductName, 
                             p.UnitPrice
                         }

             ).ToList();

            gridProductos.DataSource = lista;
        }
    }
}
