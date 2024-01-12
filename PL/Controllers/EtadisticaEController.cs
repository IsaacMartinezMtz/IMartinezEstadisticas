using Microsoft.AspNetCore.Mvc;

namespace PL.Controllers
{
    public class EtadisticaEController : Controller
    {
        public IActionResult GetAll()
        {
            return View();
        }
    }
}
