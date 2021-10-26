using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaSegura.Models
{
    //las clases son por default privadas; si queremos publicas debemos aclararlo
    public class Usuario
    {

        //propiedades autoimplementadas

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        //constructor con parametros

        public Usuario( string nombre, string password)
        {
            Nombre = nombre;
            Password = password;
        }
    }
}
