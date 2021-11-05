using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Olivastri_Ornella.Models;
using Microsoft.EntityFrameworkCore;


namespace Olivastri_Ornella.Data
{
    public class DBContextWSAuto : DbContext
    {
        //constructor
        public DBContextWSAuto(DbContextOptions<DBContextWSAuto> options) : base(options) { }

        public DbSet<Auto> Autos { get; set; }
    }
}
