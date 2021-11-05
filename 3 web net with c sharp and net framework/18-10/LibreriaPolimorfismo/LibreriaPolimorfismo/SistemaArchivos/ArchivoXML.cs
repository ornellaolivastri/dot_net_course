using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPolimorfismo.SistemaArchivos
{
    public class ArchivoXML : Archivo
    {
        public override string log(string mensaje, string path)
        {
            //para este caso se usa el namespace System.XML
            throw new NotImplementedException();
        }
    }
}
