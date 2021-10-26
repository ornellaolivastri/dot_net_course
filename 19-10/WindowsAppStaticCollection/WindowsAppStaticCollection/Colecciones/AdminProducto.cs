using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsAppStaticCollection.Colecciones
{
    public static class AdminProducto
    {
        //SOBRECARGA DE METODOS: NOMBRARLOS IGUAL PERO QUE RECIBAN DIFERENTES PARAMETROS
        //Y OBVIO QUE HAGAN DIFERENTES COSAS
        public static List<Producto> listar()
        {
            //TODO falta implementar listar() SELECT ... FROM Producto

            List<Producto> lista = new List<Producto>()
            {
                //TODO falta implementar listar Select ....from Producto
                
                new Producto(){  CategoriaId=1, Id=1, Nombre="Teclado", Color="negro", Precio=1000},
                new Producto(){  CategoriaId=1, Id=2, Nombre="Impresora", Color="negro", Precio=1100},
                new Producto(){  CategoriaId=1, Id=3, Nombre="CPU", Color="negro", Precio=100000}
            };

            return lista;

        }

        public static List<Producto>listar(string color)
        {
            //TODO falta implementar listar SELECT ... FROM Producto WHERE Color
            //traer todos los productos por color
            return null;
        }
        public static List<Producto> listar(int categoriaId)
        {
            //TODO falta implementar listar SELECT ... FROM Producto WHERE Color
            //traer todos los productos por categoriaId
            return null;
        }

        public static Producto traerUno(int id)
        {
            //TODO falta implementar traerUno
            return null;

        }

        public static int insertar(Producto producto)
        {
            //TODO falta implementar insertar()
            return 0;

        }

        public static int modificar(Producto producto)
        {
            //TODO falta implementar insertar()
            return 0;

        }

        public static int eliminar(Producto producto)
        {
            //TODO falta implementar insertar()
            return 0;

        }
    }
}
