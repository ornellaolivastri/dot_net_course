using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPolimorfismo.SistemaArchivos
{
    public abstract class Archivo
    {
        public abstract string log(string mensaje, string path);
    }
}
