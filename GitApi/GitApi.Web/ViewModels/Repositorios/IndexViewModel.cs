using System.ComponentModel.DataAnnotations;

namespace GitApi.Web.ViewModels.Repositorios
{
    public class IndexViewModel
    {
        [Required(ErrorMessage = "Nome é obrigatório.")]
        public string NomeRepositorio { get; set; }
    }
}