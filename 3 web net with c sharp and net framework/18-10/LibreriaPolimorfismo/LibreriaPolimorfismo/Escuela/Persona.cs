﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPolimorfismo.Escuela
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public virtual string imprimir()
        {
            return "Apellido: " + Apellido + ". Nombre: " + Nombre;
        }
    }
}
