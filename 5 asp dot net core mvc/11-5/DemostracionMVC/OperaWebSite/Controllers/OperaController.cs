using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using OperaWebSite.Models;
using OperaWebSite.Data;
using System.Data.Entity;


namespace OperaWebSite.Controllers
{
    public class OperaController : Controller
    {


        //Crear instancia del dbcontext

        private OperaDbContext context = new OperaDbContext();





        // GET: Opera o /Opera/Index
        public ActionResult Index()
        {
            //Traer todas Operas usando EF
            var operas = context.Operas.ToList();

            //el controller retorna una vista "Index" con la lista de operas
            return View("Index", operas);
        }



        // ---------------------------------------------------
        // Creamos dos métodos para la inserción de la opera en la DB
        // ---------------------------------------------------



        //Primer Create por GET para retornar la vista de registro
        [HttpGet]//El Get es implicito asi y todo lo podemos indicar
        public ActionResult Create()
        {
            //creamos la instancia con valores en las propiedades
            Opera opera = new Opera();

            //retornamos la vista "Create" que tiene el objeto opera
            return View("Create", opera);
        }




        //Segundo Create es por Post para insertar la nueva opera en la base
        //cuando el usuario en la vista Create hace click en enviar
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


        // ---------------------------------------------------
        // Creamos un método para mostar detalles de un item
        // ---------------------------------------------------

        //GET
        // Opera/Detail/id
        // Opera/Detail/2
        [HttpGet]//opcional porque el default es GET
        public ActionResult Detail(int id)
        {
            Opera opera = context.Operas.Find(id);

            if (opera != null)
            {
                return View("Detail", opera);
            }
            else
            {
                return HttpNotFound();
            }
        }


        // ---------------------------------------------------
        // Creamos dos métodos para borrar un item
        // ---------------------------------------------------

        //primero preguntamos si esta seguro de borrar el item

        //GET /Opera/Delete/Id
        [HttpGet]
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


        //se confirma la eliminacion del item y se concluye la eliminacion

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

        // ---------------------------------------------------
        // Creamos dos métodos para editar detalles de un item
        // ---------------------------------------------------

        //GET /Opera/Edit/id
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Opera opera = context.Operas.Find(id);

            if (opera != null)
            {
                return View("Edit", opera);
            }
            else
                return HttpNotFound();
        }

        [HttpPost]
        [ActionName("Edit")]
        public ActionResult EditConfirmed(Opera opera)
        {
            if (ModelState.IsValid)
            {
                context.Entry(opera).State = EntityState.Modified;
                context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View("Edit", opera);
        }




    }
}