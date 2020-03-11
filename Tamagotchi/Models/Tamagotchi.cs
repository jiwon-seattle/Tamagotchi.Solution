using System;

namespace Tamagotchi.Models
{
  public class Tamagotchi
  {
    public string Name { get; set; }
    public string Food { get; set; }
    public string Sleep { get; set; }
    public string Happiness { get; set; }
    private bool _life;
    public static List<Tamagotchi> _instances = new List<Tamagotchi>() { };
    public int Id { get; };

    public Tamagotchi(string name)
    {
      Name = name;
      Food = 20;
      Sleep = 20;
      Happiness = 20;
      _life = true;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Tamagotchi> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Tamagotchi Find(int id)
    {
      return _instances[id - 1];
    }

    public void SetLife()
    {
      if (Sleep <= 0 || Food <= 0 || Happiness <= 0)
      {
        _life = false;
      }
    }

    public bool GetLife()
    {
      return _life;
    }

    public static void PassTime()
    {
      foreach (Tamagotchi tamagotchi in _instances)
      {
        tamagotchi.Food -= 1;
        tamagotchi.Hapiness -= 1;
        tamagotchi.Sleep -= 1;
        SetLife();
      }
    }
  }
}