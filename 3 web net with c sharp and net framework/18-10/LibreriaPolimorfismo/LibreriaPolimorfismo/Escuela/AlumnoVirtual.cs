using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPolimorfismo.Escuela
{
    public class AlumnoVirtual : Alumno
    {
        public int NroSesionVirtual { get; set; }
        public override string imprimir()
        {
            return base.imprimir() + ". Su sesion virtual es: " + NroSesionVirtual.ToString();
        }
    }
}
