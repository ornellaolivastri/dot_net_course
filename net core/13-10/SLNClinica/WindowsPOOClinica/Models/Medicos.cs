using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsPOOClinica
{
    //default es private
    public class Medico
    {
        #region constructores

        //por defecto
        public Medico() { }

        //con paramtetros
        public Medico(string Nombre, string apellido, string matricula)
        {
            //inicializamos las propiedades
            this.Nombre = Nombre;
            Apellido = apellido;
            Matricula = matricula;

        }


        #endregion


        #region propiedades autoimplementadas

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Matricula { get; set; }


        #endregion
    }
}
