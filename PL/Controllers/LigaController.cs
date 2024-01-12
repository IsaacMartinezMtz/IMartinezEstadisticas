using Microsoft.AspNetCore.Mvc;

namespace PL.Controllers
{
    public class LigaController : Controller
    {
        public IActionResult GetAll()
        {
            return View();
        }
    }
}
