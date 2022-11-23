using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;
using System.Collections.Generic;

namespace SalesWebMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Departement> list = new List<Departement>();
            list.Add(new Departement { Id = 1, Name = "Eletronics"});
            list.Add(new Departement { Id = 2, Name = "Fashion"});

            return View(list);
        }


    }
}
