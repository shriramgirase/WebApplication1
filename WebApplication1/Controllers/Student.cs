using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class Student : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
