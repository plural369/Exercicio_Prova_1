using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercicio_Prova_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exercicio_Prova_1.Controllers
{
    public class BibliotecaController : Controller
    {

        private static IList<BibliotecaModel> bibliotecas = new List<BibliotecaModel>()
        {
             new BibliotecaModel()
            {
                Id = 1,
                Nome = "Audi a3",
                Autor = "Azul",
                Editora = "Stadia",
                Ano_de_Lançamento = 1000,
                Genero = "Ação",
                Idioma = "Português",
                Introducao = "Era uma vez....."

            }
        };

        public IActionResult Index()
        {
            return View(bibliotecas);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BibliotecaModel biblioteca)
        {
            if (ModelState.IsValid)
            {
                bibliotecas.Add(biblioteca);
                return RedirectToAction(nameof(Index));
            }
            return View(biblioteca);
        }
    }
}
