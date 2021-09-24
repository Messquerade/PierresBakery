using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Models.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructorTest()
    {
      Pastry testPastry = new Pastry(26);
      Assert.AreEqual(26, testPastry.TotalPastries);
    }

    [TestMethod]
    public void GetPastryCost_CalulateZeroPastryCost_0()
    {
      Pastry testPastry = new Pastry(0);
      Assert.AreEqual(0, testPastry.GetPastryCost());
    }


  }
}