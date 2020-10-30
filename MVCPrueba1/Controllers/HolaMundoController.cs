using MVCPrueba1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPrueba1.Controllers
{
    public class HolaMundoController : Controller
    {
        // GET: HolaMundo
        public ActionResult HolaMundo()
        {
            return View();
        }

        public JsonResult MensajeHolaMundo(Dialogo dialogo)
        {
            List<Dialogo> ListDialogo = new List<Dialogo>();

            dialogo.Mensaje = dialogo.Mensaje + " Otro Mensaje";

            ListDialogo.Add(dialogo);
            ListDialogo.Add(dialogo);


            //CONEXION AL WS


            return Json(ListDialogo, JsonRequestBehavior.AllowGet);
        }
    }
}