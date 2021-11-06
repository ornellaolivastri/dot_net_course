using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using OperaWebSite2.Data;
using OperaWebSite2.Models;
using System.Data.Entity;

namespace OperaWebSite2.Controllers
{
    public class OperaController : Controller
    {

        //crear instancia del dbcontext

        private OperaDBContext context = new OperaDBContext();


        // GET: Opera o /Opera/Index
        public ActionResult Index()
        {
            //Traer todas Operas usando EF
            var operas = context.Operas.ToList();

            //el controller retorna una vista "Index" con la lista de operas
            return View("Index", operas);
        }
            
            // ------- Creamos dos metodos de insercion de la opera en la base de datos ----------



            //primer create por get para retornar la vista del registro
            [HttpGet] //en realidad el get es implicito pero se puede especificar si se requiere

            public ActionResult Create()
            {
                Opera opera = new Opera();

                //retornamos la vista "create" que tiene el objeto opera
                return View("Create", opera);

            }


            //Segundo create es por post para insertar la nueva opera en la base
            //cuando el usuario en la vista create hace click en enviar
            //Opera/Create -->POST

            [HttpPost]
            public ActionResult Create(Opera opera)
            {
                if (ModelState.IsValid)
                {
                    context.Operas.Add(opera);
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }

            return View("Create", opera);
            }


        // GET
        // Opera/Detail/id
        // Opera/Detail/2
        // el [http] es default, no hace falta agregarlo
        public ActionResult Detail(int id)
        {
            Opera opera = context.Operas.Find(id);

            if(opera != null)
            {
                return View("Detail", opera);
            }
            else
            {
                return HttpNotFound();
            }

        }


        //GET  /Opera/Delete/Id

        public ActionResult Delete(int id)
        {
            Opera opera = context.Operas.Find(id);


            if (opera != null)
            {
                return View("Delete", opera);
            }
            else
            {
                return HttpNotFound();
            }

        }  



        // /Opera/Delete
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {

            Opera opera = context.Operas.Find(id);

            context.Operas.Remove(opera);
            context.SaveChanges();

            return RedirectToAction("Index");

        }


    }
}