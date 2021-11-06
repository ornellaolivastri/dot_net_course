﻿using MVCClinica.Admin;
using MVCClinica.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MVCClinica.Controllers
{
    public class MedicoController : Controller
    {


        public ActionResult Index()
        {
            return View("Index", AdmMedico.Listar());
        }




        [HttpGet]
        public ActionResult Create()
        {
            Medico medico = new Medico();
            return View("Create", medico);
        }



        public ActionResult Create(Medico medico)
        {
            if (ModelState.IsValid)
            {
                AdmMedico.Cargar(medico);
                return RedirectToAction("Index");
            }
            return View("Create", medico);
        }



        public ActionResult Detail(int id)
        {
            Medico medico = AdmMedico.Listar(id);
            if (medico == null)
                return HttpNotFound();

            return View("Detail", medico);
        }



        public ActionResult Edit(int id)
        {
            Medico medico = AdmMedico.Buscar(id);
            if (medico == null)
                return HttpNotFound();

            return View("Edit", medico);
        }



        [HttpPost]
        public ActionResult Edit(Medico medico)
        {
            if (ModelState.IsValid)
            {
                AdmMedico.Modificar(medico);
                return RedirectToAction("Index");
            }
            return View("Edit", medico);
        }



        public ActionResult Delete(int id)
        {
            Medico medico = AdmMedico.Listar(id);
            if (medico == null)
                return HttpNotFound();

            return View("Delete", medico);
        }



        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Medico medico = AdmMedico.Listar(id);
            if (medico == null)
                return HttpNotFound();

            AdmMedico.Eliminar(medico);

            return RedirectToAction("Index");
        }



        public ActionResult SearchByEspecialidad(string especialidad)
        {
            if (especialidad == null)
                return RedirectToAction("Index");
            
            return View("Index", AdmMedico.ListarEspecialidad(especialidad));
        }
    }
}