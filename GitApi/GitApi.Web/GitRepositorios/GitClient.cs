using GitApi.Web.GitRepositorios.Response;
using GitApi.Web.GitRepositorios.Response.Error;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;


namespace GitApi.Web.GitRepositorios
{
    public class GitClient
    {
        internal async Task<IList<RepositoriosResponse>> ObterRepositoriosUsuario()
        {
            try
            {
                var client = GetClient();
                var response = await client.GetAsync(GitRepositoriosConfig.UrlRepositoriosUsuario);
                string retorno = null;

                if (response.IsSuccessStatusCode)
                {
                    retorno = await response.Content.ReadAsStringAsync();
                    return await JsonConvert.DeserializeObjectAsync<IList<RepositoriosResponse>>(retorno);
                }

                retorno = await response.Content.ReadAsStringAsync();
                ErrorResponse erro = JsonConvert.DeserializeObjectAsync<ErrorResponse>(retorno).Result;

                throw new Exception(erro.Message);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        internal async Task<IList<RepositoriosResponse>> ObterRepositoriosPorNome(string nomeRepositorio)
        {
            try
            {
                var client = GetClient();
                var response = await client.GetAsync(string.Format(GitRepositoriosConfig.UrlRepositoriosPorNome, nomeRepositorio));
                string retorno = null;

                if (response.IsSuccessStatusCode)
                {
                    retorno = await response.Content.ReadAsStringAsync();
                    return await JsonConvert.DeserializeObjectAsync<IList<RepositoriosResponse>>(retorno);
                }

                retorno = await response.Content.ReadAsStringAsync();
                ErrorResponse erro = JsonConvert.DeserializeObjectAsync<ErrorResponse>(retorno).Result;

                throw new Exception(erro.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        internal async Task<RepositoriosResponse> ObterRepositorioPorNome(string nomeRepositorio)
        {
            try
            {
                var client = GetClient();
                var response = await client.GetAsync(string.Format(GitRepositoriosConfig.UrlRepositoriosPorNome, nomeRepositorio));
                string retorno = null;

                if (response.IsSuccessStatusCode)
                {
                    retorno = await response.Content.ReadAsStringAsync();
                    return await JsonConvert.DeserializeObjectAsync<RepositoriosResponse>(retorno);
                }

                retorno = await response.Content.ReadAsStringAsync();
                ErrorResponse erro = JsonConvert.DeserializeObjectAsync<ErrorResponse>(retorno).Result;

                throw new Exception(erro.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        internal async Task<IList<ColaboradoresResponse>> ObterColaboradoresRepositorio(string owner, string nomeRepositorio)
        {
            try
            {
                var client = GetClient();
                var response = await client.GetAsync(string.Format(GitRepositoriosConfig.UrlColaboradores, owner, nomeRepositorio));
                string retorno = null;

                if (response.IsSuccessStatusCode)
                {
                    retorno = await response.Content.ReadAsStringAsync();
                    return await JsonConvert.DeserializeObjectAsync<IList<ColaboradoresResponse>>(retorno);
                }

                retorno = await response.Content.ReadAsStringAsync();
                ErrorResponse erro = JsonConvert.DeserializeObjectAsync<ErrorResponse>(retorno).Result;

                throw new Exception(erro.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private static HttpClient GetClient()
        {
            var client = new HttpClient()
            {
                BaseAddress = new Uri(GitRepositoriosConfig.Url)
            };

            client.DefaultRequestHeaders.Accept.ParseAdd("application/vnd.github.v3+json");
            client.DefaultRequestHeaders.UserAgent.ParseAdd("Repos");

            return client;
        }
    }
}