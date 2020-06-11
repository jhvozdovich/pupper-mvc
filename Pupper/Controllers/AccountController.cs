using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using PupperMvc.Models;
using System.Threading.Tasks;
using PupperMvc.ViewModels;


namespace PupperMvc.Controllers
{
  public class AccountController : Controller
  {
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;

    public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
    {
      _userManager = userManager;
      _signInManager = signInManager;
    }

    public ActionResult Index()
    {
      return RedirectToAction("Index", "Home");
    }

    // public IActionResult Register()
    // {
    //   return View("Register");
    // }

    // [HttpPost]
    // public async Task<ActionResult> Register(RegisterViewModel model)
    // {
    //   var user = new ApplicationUser { UserName = model.Email };
    //   IdentityResult result = await _userManager.CreateAsync(user, model.Password);
    //   if (result.Succeeded)
    //   {
    //     return RedirectToAction("Index");
    //   }
    //   else
    //   {
    //     return RedirectToAction("Index");
    //   }
    // }

    // public ActionResult Login()
    // {
    //   return RedirectToAction("Index");
    // }

    [HttpPost]
    public async Task<ActionResult> Login(LoginViewModel model)
    {
      await _signInManager = ApplicationUser.SignInByAPI(model.UserName, model.Password);
      Microsoft.AspNetCore.Identity.SignInResult result = _signInManager;
      // Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, isPersistent: true, lockoutOnFailure: false);
      if (result.Succeeded)
      {
        return RedirectToAction("Index");
      }
      else
      {
        return RedirectToAction("Index");
      }
    }

    // [HttpPost]
    // public async Task<ActionResult> LogOff()
    // {
    //   await _signInManager.SignOutAsync();
    //   return RedirectToAction("Index");
    // }
  }
}