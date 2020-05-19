using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Prueba_practica_mvc.Models;

namespace Prueba_practica_mvc.Controllers{

[Route("/usuarios/")]
public class UsersController : Controller
    {
        public IActionResult Index(){
            return View();
        }

        
    }
}