using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaEntidades.ModelsBase;

namespace LibreriaEntidades.Models
{
    public class Director : Empleado
    {
        public string PostGrado { get; set; }

        //se agrega el constructor heredado, añadiendo el constructor padre como parametro
        public Director(string nombre, string apellido, string dni, int PostGrado) : base(nombre, apellido, dni, PostGrado) { }
    }
}
