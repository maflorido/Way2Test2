using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GitApi.Web.GitRepositorios.Response
{
    public class ColaboradoresResponse
    {
        public string Login { get; set; }

        public int Id { get; set; }

        [JsonProperty("contributions")]
        public int Contribuicoes { get; set; }
    }
}