using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiniFacebook.Controllers
{
    public class MasterController : Controller
    {

        [Authorize]
        // GET: Master
        public ActionResult HomePage()
        {
            return View();
        }
    }
}