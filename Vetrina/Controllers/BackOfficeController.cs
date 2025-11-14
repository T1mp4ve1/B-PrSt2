using Microsoft.AspNetCore.Mvc;

namespace Vetrina.Controllers
{
    public class BackOfficeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
