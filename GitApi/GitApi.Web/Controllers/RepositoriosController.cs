using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitApi.Web.Controllers
{
    public class RepositoriosController : Controller
    {
        // GET: Repositorios
        public ActionResult Index()
        {
            return View();
        }
    }
}