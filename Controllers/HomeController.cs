using Microsoft.AspNetCore.Mvc;

namespace Tamagotchi.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
