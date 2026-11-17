using Microsoft.AspNetCore.Mvc;
using ProjetoLivrariaDev.Models;
using ProjetoLivrariaDev.Repositories;

namespace ProjetoLivrariaDev.Controllers
{
    public class LivroController : Controller
    {
        public IActionResult Index()
        {
            var livros = RepositorioMemoria.ListaLivros;
            return View(livros);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(LivroModel livro)
        {
            // Atribui um ID sequencial automaticamente na memória
            livro.Id = RepositorioMemoria.ListaLivros.Count > 0
                ? RepositorioMemoria.ListaLivros.Max(l => l.Id) + 1
                : 1;

            RepositorioMemoria.ListaLivros.Add(livro);
            return RedirectToAction("Index");
        }
    }
    
}