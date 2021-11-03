using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Olivastri_Ornella.Models;
using Olivastri_Ornella.Data;

namespace Olivastri_Ornella.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoController : ControllerBase
    {
        
        
        private readonly DBContextWSAuto context;

        public AutoController(DBContextWSAuto context)
        {
            this.context = context;
        }


        // Para mostrar todos los autos
        // api/auto
        [HttpGet]
        public IEnumerable<Auto> Get()
        {
            return context.Autos.ToList();
        }


        // Para mostrar los autos segun modelo
        // api/auto/traerPorNombre/modelo
        [HttpGet("traerPorNombre/{modelo}")]
        public IEnumerable<Auto> traerPorNombre(string modelo)
        {
            var autos =
            (
            from producto in context.Autos
            where producto.Modelo == modelo
            select producto
            ).ToList();

            return autos;
        }









    }
}
