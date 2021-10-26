using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibreriaSegura.Models
{
    public class Usuario
    {
        //constructor con parámetro
        public Usuario(string nombre, string password)
        {
            Nombre = nombre;
            Password = password;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }

}
