using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaEntidades.ModelsBase;

namespace LibreriaEntidades.Models
{
    //la herencia se aplica con dos puntitos seguidos de la clase de la cual se hereda
    /*
    public class Empleado : Persona
    {
        public int NroLegajo { get; set; }
    }
    */
    //Luego de agregar el constructor en la clase base persona, aparece un cartel que dice que no se han dado argumentos que
    //correspondan con los parametros requeridos apellido nombre y dni,, asi que el constructor se hereda tambien, y hay que agregarlo:

    public class Empleado : Persona
    {
        public int NroLegajo { get; set; }

        //constructor- el constructor debe pasarse como parametro del constructor heredado
        public Empleado(string baseApellido, string baseNombre, string baseDNI, int nroLegajo) : base(baseApellido, baseNombre, baseDNI)
        {
            NroLegajo = nroLegajo;
        }
    }
}
