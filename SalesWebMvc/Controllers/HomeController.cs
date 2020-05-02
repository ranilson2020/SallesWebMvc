using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SallesWebMvc.Models;
using SallesWebMvc.Models.ViewModels;

namespace SallesWebMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()   //Nome do Método é igual o nome da ação
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Aplicação feita em MVC.";
            ViewData["email"] = "ranilson.analista2020@hotmail.com";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Entre em contato.";

            return View();
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
