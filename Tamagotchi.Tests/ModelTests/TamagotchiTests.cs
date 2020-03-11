using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tamagotchi.Models;

namespace Tamagotchi.Tests
{
  [TestClass]
  public class TamagotchiGameTests
  {
    [TestMethod]
    public void MethodName1_DescriptionOfBehavior1_ExpectedResult1()
    {
      TamagotchiGame game = new TamagotchiGame("hi", 12, "hello");
      Assert.AreEqual("hi", game.Property1);
    }

    [TestMethod]
    public void MethodName2_DescriptionOfBehavior2_ExpectedResult2()
    {
      TamagotchiGame game = new TamagotchiGame("hi", 12, "hello");
      Assert.AreEqual(true, game.MethodName());
    }
  }
}