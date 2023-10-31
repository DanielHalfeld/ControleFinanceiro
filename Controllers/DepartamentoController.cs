using ControleFinanceiro.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControleFinanceiro.Controllers
{
    public class DepartamentoController : Controller
    {
        public static IList<Departamento> departamentos = new List<Departamento>()
        {
            new Departamento()
            {
                DepartamentoId = 1,
                Nome = "financeiro",
            },
            new Departamento()
            {
                DepartamentoId = 2,
                Nome = "adminstrativo",
             
            }
        };
        public IActionResult Index()
        {
            return View(departamentos);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create(Departamento departamento)
        {
            departamento.DepartamentoId = departamentos.Select(i => i.DepartamentoId).Max() + 1;
            departamentos.Add(departamento);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(long id)
        {
            return View(departamentos.Where(i => i.DepartamentoId == id).First());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Edit(Departamento departamento)
        {
            departamentos.Remove(departamentos.Where(i => i.DepartamentoId == departamento.DepartamentoId).First());
            departamentos.Add(departamento);
            return RedirectToAction("Index");
        }
    }
}
