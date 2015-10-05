using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GitApi.Web.GitRepositorios
{
    public class GitRepositoriosConfig
    {
        public static string NomeUsuario { get; set; }

        public static string Url => "https://api.github.com";

        public static string UrlRepositoriosUsuario => string.Format("users/{0}/repos", NomeUsuario);

        public static string UrlRepositoriosPorNome => "search/repositories?q={0}";

        public static string UrlColaboradores => "repos/{0}/{1}/contributors";        
    }
}