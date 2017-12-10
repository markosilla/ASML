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

        }
    }
}
