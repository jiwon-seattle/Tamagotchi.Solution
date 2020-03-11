using System;

namespace Tamagotchi.Models
{
  public class Tamagotchi
  {
    public string Name { get; set; }
    public string City { get; set; }

    public Tamagotchi(string name)
    {
      Name = name;
      City = "Seattle";
    }

    public bool MethodName()
    {
      return true;
    }
  }
}