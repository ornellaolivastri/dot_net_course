using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespaces añadido ---------------
using System.Data.Entity;
using Datos.Models;
//--------------------------------

namespace Datos.Data
{
    class DbClinicaContext : DbContext
    {
        //constructor
        public DbClinicaContext() : base("KeyDbClinica") { }

        //propiedades DbSet<m>
        public DbSet<Paciente> Pacientes { get; set; }

        
    }
}
