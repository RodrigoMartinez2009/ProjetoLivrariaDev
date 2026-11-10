using System.ComponentModel.DataAnnotations;

namespace ProjetoLivrariaDev.Models
{
    public class LoginModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O e-mail é obrigatório.")]
        [EmailAddress(ErrorMessage = "E-mail inválido.")]
        public string Email { get; set; }

        public string Senha { get; set; }

        [Required(ErrorMessage = "A senha hash é obrigatória.")]
        public string SenhaHash { get; set; }
    }
}
