using GitApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GitApi.Web.ViewModels.FavoritosModels
{
    public class FavoritosListarViewModel
    {
        public FavoritosListarViewModel() { }

        public FavoritosListarViewModel(IList<Favoritos> favoritos)
        {
            this.Itens = favoritos.Select(x => new FavoritosListarViewModel() { IdRepositorioGit = x.IdRepositorioGit, NomeRepositorio = x.NomeRepositorio }).ToList();
        }

        public string NomeRepositorio { get; private set; }

        public int IdRepositorioGit { get; private set; }

        public IList<FavoritosListarViewModel> Itens { get; private set; }
    }
}