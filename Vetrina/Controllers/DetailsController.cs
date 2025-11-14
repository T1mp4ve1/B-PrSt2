using Microsoft.AspNetCore.Mvc;
using Vetrina.Models;

namespace Vetrina.Controllers
{
    public class DetailsController : Controller
    {
        public IActionResult ShowDetails(Guid id)
        {
            var product = DataVetrina.Products.FirstOrDefault(p => p.Id == id);
            return View(product);
        }
    }
}