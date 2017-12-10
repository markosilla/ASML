using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ASML;

namespace UnitTests
{
    [TestClass]
    public class SequenceAnalysisTests
    {

        [TestMethod]
        public void TestFindSumOfNatNrsNegative()
        {
            SequenceAnalysis s = new SequenceAnalysis();

            Assert.AreEqual("GIINRSST", s.FindUppWordAndOrderChars("This IS a STRING"));
            Assert.AreEqual("AGINRST", s.FindUppWordAndOrderChars("This2 IS2 A STRING"));
            Assert.AreEqual(string.Empty, s.FindUppWordAndOrderChars("2323 23 23"));
            Assert.AreEqual("AAAAIKLLMNOORS", s.FindUppWordAndOrderChars("Marko Silla MARKO SILLA ON AA"));
        }
    }
}
