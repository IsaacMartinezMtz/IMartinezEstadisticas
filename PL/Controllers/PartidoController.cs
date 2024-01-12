using Microsoft.AspNetCore.Mvc;

namespace PL.Controllers
{
    public class PartidoController : Controller
    {
        public IActionResult GetAll()
        {
            return View();
        }
    }
}
