using GitApi.Web.GitRepositorios;
using GitApi.Web.ViewModels.Repositorios;
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
            var retorno = await gitClient.ObterRepositoriosUsuario();

            return PartialView("_ListagemRepositorios", retorno);
        }

        public async Task<ActionResult> ObterRepositoriosNome(IndexViewModel model)
        {
            var retorno = await gitClient.ObterRepositoriosPorNome(model.NomeRepositorio);

            return PartialView("_ListagemRepositoriosNome", retorno);
        }

        public async Task<ActionResult> Detalhes(string nome, string login)
        {
            var repositorios = await gitClient.ObterRepositorioPorNome(nome);

            var colaboradores = await gitClient.ObterColaboradoresRepositorio(login, nome);

            DetalhesViewModel viewmodel = new DetalhesViewModel(colaboradores, repositorios.Items[0]);

            return PartialView("_Detalhes", viewmodel);

        }
    }
}