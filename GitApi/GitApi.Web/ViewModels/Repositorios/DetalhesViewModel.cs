using GitApi.Web.GitRepositorios.Response;
using System.Collections.Generic;

namespace GitApi.Web.ViewModels.Repositorios
{
    public class DetalhesViewModel
    {
        public DetalhesViewModel(IList<ColaboradoresResponse> colaboradores, RepositoriosResponse repositorios)
        {
            this.Colaboradores = colaboradores;
            this.Repositorios = repositorios;
        }

        public IList<ColaboradoresResponse> Colaboradores { get; set; }

        public RepositoriosResponse Repositorios { get; set; }
    }
}