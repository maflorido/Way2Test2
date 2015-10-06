using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitApi.Domain.Entities
{
    public class Favoritos
    {
        public int Id { get; set; }

        public string NomeRepositorio { get; set; }

        public int IdRepositorioGit { get; set; }
    }
}
