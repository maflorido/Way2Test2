using Newtonsoft.Json;
using System;

namespace GitApi.Web.GitRepositorios.Response
{
    public class RepositoriosResponse
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Language { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdateDate { get; set; }

        public Owner Owner;
    }
}