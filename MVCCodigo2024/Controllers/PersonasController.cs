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
        public ActionResult Edit()
        {
            PersonaModel persona = new PersonaModel();
   

            return View(persona);
        }
        [HttpGet]
        public ActionResult Delete()
        {
            PersonaModel persona = new PersonaModel();

            return View(persona);
        }
        [HttpGet]
        public ActionResult Details()
        {
            PersonaModel persona = new PersonaModel();

            return View(persona);
        }
    }
}