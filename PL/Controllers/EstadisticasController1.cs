﻿using Microsoft.AspNetCore.Mvc;

namespace PL.Controllers
{
    public class EstadisticasController : Controller
    {
        public IActionResult GetAll()
        {
            return View();
        }
    }
}
