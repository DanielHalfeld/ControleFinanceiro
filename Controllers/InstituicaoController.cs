using ControleFinanceiro.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControleFinanceiro.Controllers
{
    public class InstituicaoController : Controller
    {
        public static IList<Instituicao> instituicoes = new List<Instituicao>()
        {
            new Instituicao()
            {
                InstituicaoId = 1,
                Nome = "Hogwarts",
                Endereco = "Escócia"
            },
            new Instituicao()
            {
                InstituicaoId = 2,
                Nome = "Mansão X",
                Endereco = "EUA"
            }
        };
        public IActionResult Index()
        {
            return View(instituicoes);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create (Instituicao instituicao)
        {
            instituicao.InstituicaoId = instituicoes.Select(i => i.InstituicaoId).Max() + 1;
            instituicoes.Add(instituicao);
            return RedirectToAction("Index");
        }
    }
}
