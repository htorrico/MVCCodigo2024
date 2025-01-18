using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCodigo2024.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo        
        public string Mensaje()
        {
            return "Hola Mundo";
        }

        public string MensajeHTML()
        {
            return "<H1>Hola Mundo</H1>";
        }

        public string Formulario()
        {
            string simpleForm = @"
<form action='/submit' method='post'>
    <label for='name'>Name:</label><br>
    <input type='text' id='name' name='name'><br><br>
    <label for='email'>Email:</label><br>
    <input type='email' id='email' name='email'><br><br>
    <input type='submit' value='Submit'>
</form>";

            return simpleForm;
            
        }

        public string Formulario2()
        {

            string formulario = "";//leer un archivo cargarlo en esta variable

            return formulario;
        }

        public ActionResult Index()
        {
            return View();
        }


 

    }
}