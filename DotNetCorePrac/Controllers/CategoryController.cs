using Microsoft.AspNetCore.Mvc;

namespace DotNetCorePrac.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
