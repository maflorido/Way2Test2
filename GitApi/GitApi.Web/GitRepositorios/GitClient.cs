using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace GitApi.Web.GitRepositorios
{
    public class GitClient
    {
        public async void ObterRepositoriosUsuario()
        {
            var client = GetClient();
            var response = await client.GetAsync(GitRepositoriosConfig.UrlRepositoriosUsuario);

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