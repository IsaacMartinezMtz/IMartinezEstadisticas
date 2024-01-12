using Microsoft.AspNetCore.Mvc;

namespace PL.Controllers
{
    public class JugadorController : Controller
    {
        public IActionResult GetAll()
        {
            return View();
        }
    }
}
