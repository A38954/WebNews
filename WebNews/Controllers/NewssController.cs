using Microsoft.AspNetCore.Mvc;

namespace WebNews.Controllers
{
    public class NewssController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
