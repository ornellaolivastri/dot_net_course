using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using LibreriaPolimorfismo.Musicos;

namespace LibreriaPolimorfismo.Musicos
{
    public class Violinista : MusicoCuerda
    {
        //TODO  falta implementar la funcion afinar violin
        public override string afinarInstrumento()
        {
            return "afinando el violin..";
        }
    }
}
