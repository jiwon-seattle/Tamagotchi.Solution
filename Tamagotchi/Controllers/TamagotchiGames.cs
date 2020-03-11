using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;

namespace Tamagotchi.Controllers
{
  public class TamagotchiGamesController : Controller
  {
    [HttpGet("/form")]
    public ActionResult Form() { return View(); }

    [HttpPost("/result")]
    public ActionResult Result(string name, string city)
    {
      ClassName instance = new ClassName("DefaultName");
      instance.Name = name;
      instance.City = city;
      return View(instance);
    }
  }
}