using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;

namespace Tamagotchi.Controllers
{
  public class TamagotchisController : Controller
  {
    [HttpGet("/tamagotchi")]
    public ActionResult Index()
    {
      List<Tama> allTama = Tama.GetAll();
      return View(allTama);
    }
    [HttpGet("/tamagotchi/new")]
    public ActionResult CreateForm()
    {
      return View();
    }
    [HttpPost("/tamagotchi")]
    public ActionResult Create()
    {
      Tama newTama = new Tama(Request.Form["new-name"]);
      List<Tama> allTama = Tama.GetAll();
      return View("Index", allTama);
    }
    [HttpGet("tamagotchi/{id}")]
    public ActionResult Details(int id)
    {
      Tama indiv = Tama.Find(id);
      return View(indiv);
    }
  }
}
