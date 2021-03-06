using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TamagotchiGame.Models;

namespace TamagotchiGame.Controllers
{
  public class TamagotchisController : Controller
  {
    [HttpGet("/tamagotchis")]
    public ActionResult Index()
    {
      return View(Tamagotchi.GetAll());
    }

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
      return View("Index", allTamagotchis);
    }

    [HttpGet("/tamagotchis/{id}")]
    public ActionResult Show(int id)
    {
      Tamagotchi tama = Tamagotchi.Find(id);
      return View(tama);
    }

    [HttpPost("/tamagotchis/{id}/feed")]
    public ActionResult Feed(int id)
    {
      Tamagotchi tama = Tamagotchi.Find(id);
      tama.Food++;
      return View("Show", tama);
    }

    [HttpPost("/tamagotchis/{id}/play")]
    public ActionResult Play(int id)
    {
      Tamagotchi tama = Tamagotchi.Find(id);
      tama.Happiness++;
      return View("Show", tama);
    }

    [HttpPost("/tamagotchis/{id}/sleep")]
    public ActionResult Sleep(int id)
    {
      Tamagotchi tama = Tamagotchi.Find(id);
      tama.Sleep++;
      return View("Show", tama);
    }

    [HttpPost("/tamagotchis/time")]
    public ActionResult Decrease()
    {
      Tamagotchi.PassTime();
      List<Tamagotchi> allTamagotchis = Tamagotchi.GetAll();
      return View("Index", allTamagotchis);
    }

    [HttpGet("tamagotchis/deleteAll")]
    public ActionResult DeleteAll()
    {
      Tamagotchi.ClearAll();
      List<Tamagotchi> allTamagotchis = Tamagotchi.GetAll();
      return View("Index", allTamagotchis);
    }

  }
}