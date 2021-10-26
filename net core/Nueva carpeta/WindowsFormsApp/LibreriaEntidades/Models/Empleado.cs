using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaEntidades.ModelsBase;

namespace LibreriaEntidades.Models
{
    //herencia
    //empleado hereda de persona
    public class Empleado : Persona
    {
        public int NroLegajo { get; set; }
    }

}
