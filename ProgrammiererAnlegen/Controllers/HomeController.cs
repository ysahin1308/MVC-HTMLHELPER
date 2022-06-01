using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using ProgrammiererAnlegen.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProgrammiererAnlegen.Controllers
{
    public class HomeController : Controller
    {
        // Ohoh, ich sehe kein Dependency Injection ;)
        // naja ab und passiert sowas ne :D

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Person person = new Person();

            AufgabenRepository aufgaben = new AufgabenRepository();
            ViewBag.DieAufgaben = new SelectList(aufgaben.Aufgaben, nameof(AufgabenClass.Id), nameof(AufgabenClass.Name),1);
            ProjektRepository projekte = new ProjektRepository();
            ViewBag.DieProjekte = new MultiSelectList(projekte.DieProjekte, nameof(Projekt.Id), nameof(Projekt.Name));

            return View(person);
        }

        [HttpPost]
        public IActionResult Index(Person person, string DieAufgaben,string[] DieProjekte)
        {
            
            AufgabenRepository aufgaben = new AufgabenRepository();
            ViewBag.DieAufgaben = new SelectList(aufgaben.Aufgaben, nameof(AufgabenClass.Id), nameof(AufgabenClass.Name), DieAufgaben);
            ProjektRepository projekte = new ProjektRepository();
            ViewBag.DieProjekte = new MultiSelectList(projekte.DieProjekte, nameof(Projekt.Id), nameof(Projekt.Name),DieProjekte);
            
            ViewBag.Aufgabe = DieAufgaben;
            ViewBag.Projekte = DieProjekte;
            return View(person);
        }

        public IActionResult Privacy()
        {   
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
