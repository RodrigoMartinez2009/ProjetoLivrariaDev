using Microsoft.AspNetCore.Mvc;
using ProjetoLivrariaDev.Models;
using ProjetoLivrariaDev.Repositories;

namespace ProjetoLivrariaDev.Controllers
{
    public class ContaController : Controller
    {
        // Exibe a tela de Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // Processa o envio do formulário de Login
        [HttpPost]
        public IActionResult Login(string email, string senha)
        {
            var usuario = RepositorioMemoria.UsuarioFixo;

            // Valida se o email e a senha batem com o usuário fixo em memória
            if (usuario != null && usuario.Email == email && usuario.SenhaHash == senha)
            {
                // Redireciona para a Home se o login der certo
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Erro = "E-mail ou senha inválidos!";
            return View();
        }
    }
}