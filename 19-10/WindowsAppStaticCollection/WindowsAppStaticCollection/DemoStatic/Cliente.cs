using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsAppStaticCollection.DemoStatic
{
    public class Cliente
    {
        public Cliente(string nombre)
        {
            Nombre = nombre;
            numeroInstancias++;
        }

        #region miembro estatico

        private static int numeroInstancias;

        public static int NroInstancias
        {
            get { return numeroInstancias; }
        }

        #endregion


        public string Nombre { get; set; }
    }
}
