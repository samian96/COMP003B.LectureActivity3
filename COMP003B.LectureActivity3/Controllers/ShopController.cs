using Microsoft.AspNetCore.Mvc;

namespace COMP003B.LectureActivity3.Controllers
{
    public class ShopController : Controller
    {
        [HttpGet]
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]

        public IActionResult Details(int id)
        {
            return View(id);
        }
    }
}
