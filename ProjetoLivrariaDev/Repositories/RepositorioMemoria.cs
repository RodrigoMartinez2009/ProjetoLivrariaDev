using ProjetoLivrariaDev.Models;

namespace ProjetoLivrariaDev.Repositories
{
    public static class RepositorioMemoria
    {
        // Utilizador fixo para testes de login sem banco de dados
        public static LoginModel UsuarioFixo = new LoginModel
        {
            Id = 1,
            Nome = "Desenvolvedor Teste",
            Email = "admin@livraria.com",
            SenhaHash = "123" // Senha simples para teste em memória
        };

        // Lista em memória para armazenar os livros cadastrados
        public static List<LivroModel> ListaLivros = new List<LivroModel>();
    }
}