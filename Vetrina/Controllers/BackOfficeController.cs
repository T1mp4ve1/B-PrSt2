using Microsoft.AspNetCore.Mvc;
using Vetrina.Models;

namespace Vetrina.Controllers
{
    public class BackOfficeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(ProductType product)
        {
            DataVetrina.Products.Add(product);
            DataVetrina.SaveProduct();
            return RedirectToAction("Index");
        }
    }
}
