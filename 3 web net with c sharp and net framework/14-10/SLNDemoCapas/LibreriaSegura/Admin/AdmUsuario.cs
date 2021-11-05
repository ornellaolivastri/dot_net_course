using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaSegura.Models;

namespace LibreriaSegura.Admin
{
    public class AdmUsuario
    {
        public bool autenticar(Usuario usuario)
        {
            return (usuario.Nombre == "juan") && (usuario.Password == "1234");
        }
    }
}
