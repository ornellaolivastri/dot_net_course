using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPolimorfismo.Escuela
{
    public class Alumno : Persona
    {
        public int NroMatricula { get; set; }

        public override string imprimir()
        {
            return base.imprimir() + ". Su matricula es: " + NroMatricula.ToString();
        }
    }
}
