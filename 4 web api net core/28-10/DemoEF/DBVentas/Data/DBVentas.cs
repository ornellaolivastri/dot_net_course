using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespaces añadido ---------------
using System.Data.Entity;
using DBVentas.Models;
//--------------------------------

namespace DBVentas.Data
{
    public class DBVentas : DbContext
    {
        //constructor
        public DBVentasContext() : base("KeyDbClinica") { }

        //propiedades DbSet<m>
        public DbSet<Paciente> Pacientes { get; set; }
    
}
