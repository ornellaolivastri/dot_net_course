﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsPOOClinica.Models
{
    class Paciente
    {
        #region propiedades autoimplementadas
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public string Domicilio { get; set; }

        public int NroHistoriaClinica { get; set; }

        #endregion
    }
}
