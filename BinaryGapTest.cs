using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility
{
    [TestClass]
    public class BinaryGapTest
    {
        [TestMethod]
        public void FindLargestBinaryGap1()
        {
            var number = 1041;
            var maxBinGapLength = BinaryGapSolution.FindLargestBinaryGap(number);
            Assert.AreEqual(5, maxBinGapLength);
        }

        [TestMethod]
        public void FindLargestBinaryGap2()
        {
            var number = 32;
            var maxBinGapLength = BinaryGapSolution.FindLargestBinaryGap(number);
            Assert.AreEqual(0, maxBinGapLength);
        }

        [TestMethod]
        public void FindLargestBinaryGap3()
        {
            var number = 805306369;
            var maxBinGapLength = BinaryGapSolution.FindLargestBinaryGap(number);
            Assert.AreEqual(27, maxBinGapLength);
        }

        [TestMethod]
        public void FindLargestBinaryGap4()
        {
            var number = 2147483647;
            var maxBinGapLength = BinaryGapSolution.FindLargestBinaryGap(number);
            Assert.AreEqual(0, maxBinGapLength);
        }

        [TestMethod]
        public void FindLargestBinaryGap5TrailingZeroes()
        {
            var number = 6;
            var maxBinGapLength = BinaryGapSolution.FindLargestBinaryGap(number);
            Assert.AreEqual(0, maxBinGapLength);
        }
    }
}
