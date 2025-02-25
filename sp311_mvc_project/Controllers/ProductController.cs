using Microsoft.AspNetCore.Mvc;

namespace sp311_mvc_project.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
