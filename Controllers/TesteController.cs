using Microsoft.AspNetCore.Mvc;

namespace ControleFinanceiro.Controllers
{
    public class TesteController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Página teste";
            return View();
        }
    }
}
