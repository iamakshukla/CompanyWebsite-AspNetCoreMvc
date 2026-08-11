using Microsoft.AspNetCore.Mvc;

namespace PracticeWebProjects.Controllers
{
    public class FirstController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
