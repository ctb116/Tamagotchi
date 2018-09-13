using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;

namespace Tamagotchi.Controllers
{
  public class TamagotchisController : Controller
  {
    [HttpGet("/categories/{categoryId}/tamagotchi/new")]
    public ActionResult CreateForm(int categoryId)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Category category = Category.Find(categoryId);
      return View(category);
    }
    [HttpGet("/categories/{categoryId}/tamagotchi/{id}")]
    public ActionResult Details(int categoryId, int id)
    {
      Tama item = Tama.Find(id);
      Dictionary<string, object> model = new Dictionary<string, object>();
      Category category = Category.Find(categoryId);
      model.Add("item", item);
      model.Add("category", category);
      return View(item);
    }
  }

}

//     [HttpGet("/tamagotchi")]
//     public ActionResult Index()
//     {
//       List<Tama> allTama = Tama.GetAll();
//       return View(allTama);
//     }
//     [HttpGet("/tamagotchi/new")]
//     public ActionResult CreateForm()
//     {
//       return View();
//     }
//     [HttpPost("/tamagotchi")]
//     public ActionResult Create()
//     {
//       Tama newTama = new Tama(Request.Form["new-name"]);
//       List<Tama> allTama = Tama.GetAll();
//       return View("Index", allTama);
//     }
//     [HttpGet("tamagotchi/{id}")]
//     public ActionResult Details(int id)
//     {
//       Tama indiv = Tama.Find(id);
//       return View(indiv);
//     }
//     [HttpPost("/tamagotchi/{id}/feed")]
//     public ActionResult Feed(int id)
//     {
//       List<Tama> allTama = Tama.GetAll();
//       int find = id - 1;
//       allTama[find].Feed();
//       return View("Details", allTama[find]);
//     }
//     [HttpPost("tamagotchi/{id}/sleep")]
//     public ActionResult Sleep(int id)
//     {
//       List<Tama> allTama = Tama.GetAll();
//       int find = id - 1;
//       allTama[find].Rest();
//       return View("Details", allTama[find]);
//     }
//     [HttpPost("tamagotchi/{id}/play")]
//     public ActionResult Play(int id)
//     {
//       List<Tama> allTama = Tama.GetAll();
//       int find = id - 1;
//       allTama[find].Play();
//       return View("Details", allTama[find]);
//     }
//     [HttpPost("tamagotchi/time")]
//     public ActionResult AddTime()
//     {
//       Tama.Time();
//       List<Tama> allTama = Tama.GetAll();
//       return View("Index", allTama);
//     }
//   }
//
// }
