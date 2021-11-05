using System;
using System.Collections.Generic;
using System.Text;
using LibreriaSegura.Models;

namespace LibreriaSegura.Admin
{
    public class AdmUsuario
    {
        public bool autenticar(Usuario usuario)
        {
            if (usuario.Nombre == "juan" && usuario.Password == "1234")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
