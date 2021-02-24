using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeNumber.Models;

namespace PrimeNumber.Tests 
{
  [TestClass]
  public class DivisibilityTests
  {
    [TestMethod]
    public void PrimeSifter_NumberDivisibleByTwo_False()
    {
      Calculator testEven = new Calculator();
      Assert.AreEqual(false, testEven.NumberSifter(10));
    }
  }
}