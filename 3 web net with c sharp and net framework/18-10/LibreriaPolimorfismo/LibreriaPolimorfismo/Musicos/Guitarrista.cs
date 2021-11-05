using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPolimorfismo.Musicos
{
    class Guitarrista : MusicoCuerda
    {
        //TODO  falta implementar la funcion afinar guitarra
        public override string afinarInstrumento()
        {
            return "afinando guitarra..";
        }
    }
}
