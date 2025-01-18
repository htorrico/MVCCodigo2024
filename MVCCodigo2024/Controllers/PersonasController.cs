using MVCCodigo2024.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCodigo2024.Controllers
{
    public class PersonasController : Controller
    {

        

        // GET: Personas
        [HttpGet]
        public ActionResult Index()
        {
                      
            List<PersonaModel> personas = new List<PersonaModel>();

            if (Session["Personas"] != null)
            {
                personas = (List<PersonaModel>)Session["Personas"];
            }
            else {
                Session["Personas"] = personas;
            }

            return View(personas);
        }

        [HttpGet]
        public ActionResult Create()
        {
       
            PersonaModel persona = new PersonaModel();
       
            return View(persona);
        }

        [HttpPost]
        public ActionResult Create(PersonaModel model )
        {
            //Llena la sesión con lo que viene en la vista
            ((List<PersonaModel>) Session["Personas"]).Add(model);

            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {                      
            PersonaModel model = ((List<PersonaModel>)Session["Personas"])
                                  .Where(x=>x.PersonaID==id).FirstOrDefault();

            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(PersonaModel model)
        {

            //Buscar persona a modificar
            PersonaModel personaModificar = ((List<PersonaModel>)Session["Personas"])
                                 .Where(x => x.PersonaID == model.PersonaID).FirstOrDefault();


            personaModificar.Nombres = model.Nombres;
            personaModificar.Apellidos = model.Apellidos;
            personaModificar.Edad = model.Edad;


            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Delete(int id)
        {
            PersonaModel model = ((List<PersonaModel>)Session["Personas"])
                                 .Where(x => x.PersonaID == id).FirstOrDefault();

            return View(model);
        }


        [HttpPost]
        public ActionResult Delete(int id, PersonaModel model)
        {

            //Buscar persona a modificar
            PersonaModel personaEliminar = ((List<PersonaModel>)Session["Personas"])
                                 .Where(x => x.PersonaID == id).FirstOrDefault();


            ((List<PersonaModel>)Session["Personas"]).Remove(personaEliminar);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Details()
        {
            PersonaModel persona = new PersonaModel();

            return View(persona);
        }
    }
}