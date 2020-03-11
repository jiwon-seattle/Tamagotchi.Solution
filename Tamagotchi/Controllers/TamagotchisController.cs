using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TamagotchiGame.Models;

namespace TamagotchiGame.Controllers
{
  public class TamagotchisController : Controller
  {
    [HttpGet("/tamagotchis/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/tamagotchis")]
    public ActionResult Create(string name)
    {
      Tamagotchi tama = new Tamagotchi(name);
      List<Tamagotchi> allTamagotchis = Tamagotchi.GetAll();
      return View("index", allTamagotchis);
    }

    [HttpGet("/tamagotchis/{id}")]
    public ActionResult Show(int id)
    {
      Tamagotchi tama = Tamagotchi.Find(id);
      return View(tama);
    }

    [HttpPost("/tamagotchis/{id}")]
    public ActionResult Feed(int id)
    {
      Tamagotchi tama = Tamagotchi.Find(id);
      tama.Food++;
      return View("Show", tama);
    }
  }
}