using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEntidades.Models
{
    public sealed class EmpleadoAdministrativoContable : EmpleadoAdministrativo
    {
        //se agrega el constructor heredado, añadiendo el constructor padre como parametro
        public EmpleadoAdministrativoContable(string nombre, string apellido, string dni, int nroLegajo, int CodigoContable) : base(nombre, apellido, dni, nroLegajo, CodigoContable) { }
    }
}
