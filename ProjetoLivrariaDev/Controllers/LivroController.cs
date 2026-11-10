using Microsoft.AspNetCore.Mvc;
using ProjetoLivrariaDev.Models;
using ProjetoLivrariaDev.Repositories;

namespace ProjetoLivrariaDev.Controllers
{
    public class LivroController : Controller
    {
        // Lista todos os livros cadastrados
        public IActionResult Index()
        {
            var livros = RepositorioMemoria.ListaLivros;
            return View(livros);
        }

        // Exibe a tela de cadastro de livro (GET)
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        // Recebe os dados do formulário e salva na lista em memória (POST)
        [HttpPost]
        public IActionResult Cadastrar(LivroModel livro)
        {
            if (ModelState.IsValid)
            {
                // Atribui um ID incremental simples
                livro.Id = RepositorioMemoria.ListaLivros.Count + 1;

                // Adiciona o livro na lista em memória
                RepositorioMemoria.ListaLivros.Add(livro);

                return RedirectToAction("Index");
            }

            return View(livro);
        }
    }
}