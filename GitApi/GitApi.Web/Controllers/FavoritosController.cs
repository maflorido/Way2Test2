using GitApi.Data;
using GitApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitApi.Web.Controllers
{
    public class FavoritosController : Controller
    {
        private UnitOfWork contexto;

        public FavoritosController(UnitOfWork contexto)
        {
            this.contexto = contexto;
        }

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult AdicionarFavorito(string nomeRepositorio, int idRepositorioGit)
        {
            try
            {
                this.contexto.FavoritosRepository.Incluir(new Favoritos()
                {
                    IdRepositorioGit = idRepositorioGit,
                    NomeRepositorio = nomeRepositorio
                });

                this.contexto.Save();

                return Json(new { mensagem = "Repositório incluído como favorito com sucesso."  });
            }
            catch(Exception ex)
            {
                return Json(new { mensagem = ex.Message });
            }
        }
    }
}