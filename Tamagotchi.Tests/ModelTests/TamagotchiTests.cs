using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tamagotchi.Models;

namespace Tamagotchi.Tests
{
  [TestClass]
  public class TamagotchiTests : IDisposable
  {
    public void Dispose()
    {
      Tamagotchi.ClearAll();
    }

    [TestMethod]
    public void TamagotchiConstructor_CreateTamagotchi_Tamagotchi()
    {
      string name = "cutiepie";
      Tamagotchi tamagotchi = new Tamagotchi(name);
      Assert.AreEqual(name, tamagotchi.Name)
      Assert.AreEqual(20, tamagotchi.Food);
      Assert.AreEqual(20, tamagotchi.Happiness);
      Assert.AreEqual(20, tamagotchi.Sleep);
      Assert.AreEqual(typeof(Tamagotchi), tamagotchi.GetType());
    }

    [TestMethod]
    public void HasId_CreateTamagotchiWithId_AdoptedTamagotchi()
    {
      Tamagotchi tamagotchi = new Tamagotchi("cutiePie");
      int result = tamagotchi.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_FindMyTamagotchi_Tamagotchi()
    {
      string name = "princess";
      string name2 = "prince";
      Tamagotchi tamagotchi = new Tamagotchi(name);
      Tamagotchi tamagotchi2 = new Tamagotchi(name2);

      Tamagotchi result = Tamagotchi.Find(2);

      Assert.AreEqual(tamagotchi2, result);
    }

    [TestMethod]
    public void GetAll_GetAllTamagotchis_List()
    {
      Tamagotchi tamagotchi = new Tamagotchi("cutiePie");
      Tamagotchi tamagotchi2 = new Tamagotchi("ugly");
      List<Tamagotchi> expected = new List<Tamagotchi> { tamagotchi, tamagotchi2 };
      List<Tamagotchi> result = Tamagotchi.GetAll();
      Assert.AreEqual(expected, result);
    }
  }
}