using GitApi.Web.GitRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace GitApi.Web.Controllers
{
    public class RepositoriosController : Controller
    {
        private readonly GitClient gitClient;

        public RepositoriosController(GitClient gitClient)
        {
            this.gitClient = gitClient;
        }

        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> ObterRepositoriosUsuario()
        {
            gitClient.ObterRepositoriosUsuario();
            return View("Index");
        }
    }
}