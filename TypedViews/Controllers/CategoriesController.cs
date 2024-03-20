using Microsoft.AspNetCore.Mvc;

namespace TypedViews.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Edit(int ? id)
        {
            //return View();
            if (id.HasValue) { 
                return new ContentResult { Content = id.ToString() };
            }
            else {
                return new ContentResult { Content = "Not found content" };
            }
        }
    }
}
