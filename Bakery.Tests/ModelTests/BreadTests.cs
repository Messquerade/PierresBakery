using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Models.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructorTest()
    {
      Bread testBread = new Bread(26);
      Assert.AreEqual(26, testBread.TotalLoaves);
    }

    [TestMethod]
    public void GetBreadCost_CalulateZeroLoafCost_0()
    {
      Bread testBread = new Bread(0);
      Assert.AreEqual(0, testBread.GetBreadCost());
    }

    [TestMethod]
    public void GetBreadCost_CalculateTenLoavesCost_35()
    {
      Bread testBread = new Bread(10);
      Assert.AreEqual(35, testBread.GetBreadCost());
    }
  }
}