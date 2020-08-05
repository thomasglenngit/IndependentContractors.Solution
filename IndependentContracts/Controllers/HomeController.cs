using Microsoft.AspNetCore.Mvc;

namespace IndependentContracts.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }
    }
}