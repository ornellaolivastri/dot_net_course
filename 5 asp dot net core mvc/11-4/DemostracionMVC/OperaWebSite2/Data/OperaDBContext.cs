using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using OperaWebSite2.Models;


namespace OperaWebSite2.Data
{
    public class OperaDBContext : DbContext
    {
        public OperaDBContext( ) : base ("keyDB") { }

        public DbSet<Opera> Operas { get; set; }

    }
}