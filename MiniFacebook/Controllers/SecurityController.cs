using MiniFacebook.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MiniFacebook.Controllers
{
    public class SecurityController : Controller
    {
        private ISecurityService _service = null;
        public SecurityController(ISecurityService service) 
        {
            _service=service;

        }
        // GET: Security
        public ActionResult Logon()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Logon(LogonViewModel model)
        {
            if (ModelState.IsValid)
            {
                if(_service.IsValidUser(model))
                {
                    FormsAuthentication.SetAuthCookie(model.nombre, false);
                    return RedirectToAction("HomePage", "Master");
                }
            }
            else
            {
                ModelState.AddModelError("", "Usuario o Contraseña invalidos");
            }
            return View(model);
        }



        public ActionResult Register()
        {

            return View();
        }

         [HttpPost]
        public ActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid) 
            {
                //_service.SaveUserToDB(model);
                model.Mensaje = "Usuario Registrado con Exito";
                return View(model);

            }

            return View(model);
        }

    }
}