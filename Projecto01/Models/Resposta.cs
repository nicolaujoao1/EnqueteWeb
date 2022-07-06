using System.ComponentModel.DataAnnotations;

namespace Projecto01.Models
{
    public class Resposta
    {

        [Required(ErrorMessage ="O campo Email deve ser preenchido")]
        public string? Nome { get; set; }
        [Required(ErrorMessage = "O campo Email deve ser preenchido")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "O campo Resposta deve ser preenchido")]
        [EmailAddress(ErrorMessage ="O email digitado é invalido")]
        public bool? Sim { get; set; }

    }
}
