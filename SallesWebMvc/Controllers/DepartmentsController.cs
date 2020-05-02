using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SallesWebMvc.Models;

namespace SallesWebMvc.Controllers  
    
 //3º Passo - Criar o controller DepartamentsControllers 
 
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {

            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 001, Name = "Informática" });
            list.Add(new Department { Id = 002, Name = "Eletrônicos" });
            list.Add(new Department { Id = 003, Name = "Perfumaria" });

            return View(list);  //Exibir a lista
        }

        // 4º passo - Criar a pasta Departments , dentro da pasta Views
    }
}