using Microsoft.AspNetCore.Mvc;

namespace PL.Controllers
{
    public class EquipoController : Controller
    {
        public IActionResult GetAll()
        {
            return View();
        }
    }
}
