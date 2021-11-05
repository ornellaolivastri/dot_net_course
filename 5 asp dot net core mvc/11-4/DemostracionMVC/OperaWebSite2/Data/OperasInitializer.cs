using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using OperaWebSite2.Models;
using OperaWebSite2.Data;
using System.Data.Entity;

namespace OperaWebSite2.Data
{
    public class OperasInitializer : DropCreateDatabaseAlways<OperaDBContext>
    {

        //protected override void Seed(OperaDbContext context)
        //{
        //    base.Seed(context);
        //}
        protected override void Seed(OperaDBContext context)
        {
            var operas = new List<Opera>
            {
               new Opera {
                  Title = "Cosi Fan Tutte",
                  Year = 1790,
                  Composer = "Mozart"
               }
            };
            operas.ForEach(s => context.Operas.Add(s));

            context.SaveChanges();


        }
    }
}
