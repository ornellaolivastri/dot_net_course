using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEntidades.Models
{
    public class EmpleadoAdministrativo : Empleado
    {
        public int CodigoContable { get; set; }

        //se agrega el constructor heredado, añadiendo el constructor padre como parametro
        public EmpleadoAdministrativo(string nombre, string apellido, string dni, int nroLegajo, int CodigoContable) : base(nombre, apellido, dni, nroLegajo) { }

        //en los constructores se puede inicializar solo las variables que queramos, no necesariamente todas
    }
}
