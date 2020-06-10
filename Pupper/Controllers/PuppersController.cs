using Microsoft.AspNetCore.Mvc;
using PupperMvc.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace PupperMvc.Controllers
{
  public class PuppersController : Controller
  {
    // PuppersController()
    // {

    // }

    public IActionResult Index()
    {
      var allPuppers = Doggo.GetAll();
      return View("Index", allPuppers);
    }

    public IActionResult Details(int id)
    {
      var doggo = Doggo.GetDetails(id);
      return View(doggo);
    }

    // public IActionResult Edit(int id)
    // {

    // }

    public IActionResult Create()
    {
      return View("Create");
    }

    [HttpPost]
    public IActionResult Create(Doggo doggo)
    {
      Doggo.Post(doggo);
      return RedirectToAction("Index");
    }

    // public IActionResult Delete(int id)
    // {

    // }

    // [HttpPost("Delete")]
    // public IActionResult DeleteConfirmed(int id)
    // {

    // }
  }
}