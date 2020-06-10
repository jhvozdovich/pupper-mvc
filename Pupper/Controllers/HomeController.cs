using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PupperMvc.Controllers
{
  public class HomeController : Controller
  {
    // HomeController()
    // {

    // }

    public IActionResult Index()
    {
      return View("Index");
    }
  }
}