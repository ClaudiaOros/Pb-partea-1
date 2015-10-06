using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pavage;

namespace Pavage.Tests
{
    [TestClass]
    public class PavageTests
    {
        [TestMethod]
        public void PavageTest()
        {
            int mLength = 6;
            int nWidth = 6;
            int aStone = 4;

            int totalStones = Pavage.CalculateFormulaForPavage(mLength, nWidth, aStone);

            Assert.AreEqual(4, totalStones);
        }
    }
}
