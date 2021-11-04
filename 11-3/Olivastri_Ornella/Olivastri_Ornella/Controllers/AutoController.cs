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
        [HttpGet("traerPorNombreYModelo/{marca}/{modelo}")]
        public IEnumerable<Auto> traerPorNombreYModelo(string marca, string modelo)
        {
            var autos =
            (
            from vehiculos in context.Autos
            where vehiculos.Marca == marca && vehiculos.Modelo == modelo
            select vehiculos
            ).ToList();

            return autos;
        }









    }
}
