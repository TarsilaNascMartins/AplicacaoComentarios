using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace DesafioMVC.Models
{
    public class Cliente
    {

  
        public int Id { get; set; }

        [Required (ErrorMessage="O nome é obrigatório")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "A idade é obrigatório")]
        [Range(0,150, ErrorMessage ="A idade deve estar entre 0 e 150")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "O produto é obrigatório")]
        public string? Produto { get; set; }
        [Required(ErrorMessage = "O título é obrigatório")]
        public string? Titulo { get; set; }

        [Required(ErrorMessage = "O comentario é obrigatório")]
        public string? Comentario { get; set; }

        [EmailAddress(ErrorMessage ="O email inserido é inválido")]
        public string?Email { get; set; }
        [Required(ErrorMessage = "A avaliação é obrigatório")]
        public int? Avaliacao { get; set; }

    }

}
