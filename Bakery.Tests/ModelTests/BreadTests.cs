using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Models.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void ConstructorTest_CheckType_Bread()
    {
      Bread testBread = new Bread(26);
      Assert.AreEqual(typeof(Bread), testBread.GetType());
    }

    [TestMethod]
    public void GetTotalLoaves_ReturnNumberOfLoaves_Int()
    {
      Bread testBread = new Bread(26);
      Assert.AreEqual(26, testBread.TotalLoaves);
    }

    [TestMethod]
    public void SetTotalLoaves_ReturnUpdatedLoaves_Int()
    {
      Bread testBread = new Bread(26);
      testBread.TotalLoaves = 27;
      Assert.AreEqual(27, testBread.TotalLoaves);
    }

    [TestMethod]
    public void GetBreadCost_CalculateZeroLoafCost_0()
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

    [TestMethod]
    public void GetBreadCost_CalculateElevenLoavesCost_40()
    {
      Bread testBread = new Bread(11);
      Assert.AreEqual(40, testBread.GetBreadCost());
    }
    
    [TestMethod]
    public void GetBreadCost_CalculateTwelveLoavesCost_40()
    {
      Bread testBread = new Bread(12);
      Assert.AreEqual(40, testBread.GetBreadCost());
    }
  }
}