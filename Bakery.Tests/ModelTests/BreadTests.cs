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
  }
}