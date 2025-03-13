using Microsoft.AspNetCore.Mvc;
using PernasSolidarias.Data;

namespace PernasSolidarias.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LoginController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Autenticar(string email, string senha)
        {
            var usuario = _context.Usuarios.FirstOrDefault(l => l.Email == email && l.Senha == senha);

            if (usuario == null)
            {
                ViewBag.Mensagem = "E-mail ou senha inválidos";
                return View("Index");
            }

            // Salvar sessão do usuário
            HttpContext.Session.SetString("UsuarioLogado", usuario.Email ?? "");

            return RedirectToAction("Dashboard", "Home");
        }
    }
}
