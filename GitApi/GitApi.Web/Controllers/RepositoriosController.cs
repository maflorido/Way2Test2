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
            
            return View("_ListagemRepositorios", retorno);
        }

        public async Task<ActionResult> ObterRepositoriosNome(IndexViewModel model)
        {
            var retorno = await gitClient.ObterRepositoriosPorNome(model.NomeRepositorio);

            return View("_ListagemRepositorios", retorno);
        }

        public async Task<ActionResult> Detalhes(string nome)
        {
            var repositorios = await gitClient.ObterRepositorioPorNome(nome);

            var colaboradores = await gitClient.ObterColaboradoresRepositorio(repositorios.Owner.Login, repositorios.Name);

            DetalhesViewModel viewmodel = new DetalhesViewModel(colaboradores, repositorios);

            return View("_Detalhes", viewmodel);
        }
    }
}