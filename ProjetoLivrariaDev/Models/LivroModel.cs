using System.ComponentModel.DataAnnotations;

namespace ProjetoLivrariaDev.Models
{
    public class LivroModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O ISBN é obrigatório.")]
        public string Isbn { get; set; }

        [Required(ErrorMessage = "O título do livro é obrigatório.")]
        public string Nome { get; set; }

        public string Descricao { get; set; }

        [Required(ErrorMessage = "O valor é obrigatório.")]
        [Range(0.01, 999999.99, ErrorMessage = "O valor deve ser maior que zero.")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public decimal Valor { get; set; }
    }
}
