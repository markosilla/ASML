using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ASML;

namespace UnitTests
{
    [TestClass]
    public class SumOfMultipleTests
    {
        [TestMethod]
        public void TestFindSumOfNatNrs()
        {
            SumOfMultiple s = new SumOfMultiple();
            Assert.AreEqual(0, s.FindSumOfNatNrs(2));
            Assert.AreEqual(3, s.FindSumOfNatNrs(3));
            Assert.AreEqual(3+5, s.FindSumOfNatNrs(5));
            Assert.AreEqual(3+5+6, s.FindSumOfNatNrs(6));
            Assert.AreEqual(33, s.FindSumOfNatNrs(10));
            Assert.AreEqual(98, s.FindSumOfNatNrs(20));
        }

        [TestMethod]
        public void TestFindSumOfNatNrsNegative()
        {
            SumOfMultiple s = new SumOfMultiple();

            Assert.AreEqual(0, s.FindSumOfNatNrs(-20));

        }
    }
}
