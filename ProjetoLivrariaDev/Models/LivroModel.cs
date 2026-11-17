using System.ComponentModel.DataAnnotations;

namespace ProjetoLivrariaDev.Models
{
    public class LivroModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O ISBN é obrigatório.")]
        public string Isbn { get; set; } = string.Empty;

        [Required(ErrorMessage = "O título é obrigatório.")]
        public string Titulo { get; set; } = string.Empty;

        public string Autor { get; set; } = string.Empty;

        public string Descricao { get; set; } = string.Empty;

        [Required(ErrorMessage = "O preço é obrigatório.")]
        [Range(0.01, 999999.99, ErrorMessage = "O preço deve ser maior que zero.")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public decimal Preco { get; set; }
    }
}