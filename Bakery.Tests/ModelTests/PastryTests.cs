using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Models.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void ConstructorTest_CheckType_Pastry()
    {
      Pastry testPastry = new Pastry(26);
      Assert.AreEqual(typeof(Pastry), testPastry.GetType());
    }

    [TestMethod]
    public void GetTotalPastries_ReturnNumber_Int()
    {
      Pastry testPastry = new Pastry(26);
      Assert.AreEqual(26, testPastry.TotalPastries);
    }

    [TestMethod]
    public void SetTotalPastries_ReturnUpdatedNumber_Int()
    {
      Pastry testPastry = new Pastry(26);
      testPastry.TotalPastries = 27;
      Assert.AreEqual(27, testPastry.TotalPastries);
    }

    [TestMethod]
    public void GetPastryCost_CalculateZeroPastryCost_0()
    {
      Pastry testPastry = new Pastry(0);
      Assert.AreEqual(0, testPastry.GetPastryCost());
    }

    [TestMethod]
    public void GetPastryCost_CalculateFourPastryCost_7()
    {
      Pastry testPastry = new Pastry(4);
      Assert.AreEqual(7, testPastry.GetPastryCost());
    }

    [TestMethod]
    public void GetPastryCost_CalculateFivePastryCost_9()
    {
      Pastry testPastry = new Pastry(5);
      Assert.AreEqual(9, testPastry.GetPastryCost());
    }
    
    [TestMethod]
    public void GetPastryCost_CalculateSixPastryCost_10()
    {
      Pastry testPastry = new Pastry(6);
      Assert.AreEqual(10, testPastry.GetPastryCost());
    }
  }
}