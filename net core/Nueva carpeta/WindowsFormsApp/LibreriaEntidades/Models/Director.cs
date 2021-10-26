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
    }

}
