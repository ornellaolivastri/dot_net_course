using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespaces añadido ---------------
using System.Data.Entity;
using WindowsEF.Models;
//--------------------------------

namespace WindowsEF.Data
{
    class DbClinicaContext : DbContext
    {
        //constructor
        public DbClinicaContext() : base("KeyDbClinica") { }

        //propiedades DbSet<m>
        public DbSet<Paciente> Pacientes { get; set; }

        public DbSet<Medico> Medicos { get; set; }

        public DbSet<Especialidad> Habitaciones { get; set; }

        public DbSet<Clinica> Clinicas { get; set; }


    }
}
