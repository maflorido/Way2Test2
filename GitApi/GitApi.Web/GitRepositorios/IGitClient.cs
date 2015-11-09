using GitApi.Web.GitRepositorios.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GitApi.Web.GitRepositorios
{
    public interface IGitClient
    {
        Task<IList<RepositoriosResponse>> ObterRepositoriosUsuario();

        Task<BuscaPorNomeResponse> ObterRepositoriosPorNome(string nomeRepositorio);

        Task<BuscaPorNomeResponse> ObterRepositorioPorNome(string nomeRepositorio);

        Task<IList<ColaboradoresResponse>> ObterColaboradoresRepositorio(string owner, string nomeRepositorio);
    }
}
