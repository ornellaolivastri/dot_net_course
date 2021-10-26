using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEntidades.Models
{
    public class EmpleadoComercial : Empleado
    {
        //se agrega el constructor heredado, añadiendo el constructor padre como parametro
        public EmpleadoComercial(string nombre, string apellido, string dni, int nroLegajo) : base(nombre, apellido, dni, nroLegajo) { }
    }
}
