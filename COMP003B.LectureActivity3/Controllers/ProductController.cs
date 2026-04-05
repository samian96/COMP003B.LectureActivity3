using COMP003B.SP25.LectureActivity3.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.LectureActivity3.Controllers
{
    [Route("product")]

    public class ProductController : Controller
    {
        [HttpGet("create")]

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("create")]

        public IActionResult Create([FromForm] ProductController product)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }

            return RedirectToAction("Success", product);
        }

        [Route("success")]

        public IActionResult Success(ProductController product)
        {
            return View(product);
        }
    }
}
