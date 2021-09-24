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

    // [TestMethod]
    // public void GetBreadCost_CalulateZeroLoafCost_0()
    // {
    //   Bread testBread = new Bread(0);
    //   Assert.AreEqual(0, testBread.GetBreadCost());
    // }

    // [TestMethod]
    // public void GetBreadCost_CalculateTenLoavesCost_35()
    // {
    //   Bread testBread = new Bread(10);
    //   Assert.AreEqual(35, testBread.GetBreadCost());
    // }

    // [TestMethod]
    // public void GetBreadCost_CalculateElevenLoavesCost_40()
    // {
    //   Bread testBread = new Bread(11);
    //   Assert.AreEqual(40, testBread.GetBreadCost());
    // }
    
    // [TestMethod]
    // public void GetBreadCost_CalculateTwelveLoavesCost_40()
    // {
    //   Bread testBread = new Bread(12);
    //   Assert.AreEqual(40, testBread.GetBreadCost());
    // }
  }
}