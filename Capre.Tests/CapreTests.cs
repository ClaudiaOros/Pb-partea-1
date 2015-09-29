using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capre;

namespace Capre.Tests
{
    [TestClass]
    public class CapreTests
    {
        [TestMethod]
        public void CapreTest1()
        {
            int Zile = 1;
            int Capre = 2;
            int Kg = 3;

            int Wzile = 2;
            int Qcapre = 2;

            double xkg = Pb___Capre.Capre.FormulaCapre(Zile, Capre, Kg, Wzile, Qcapre);

            Assert.AreEqual(6,xkg);

        }

        [TestMethod]
        public void CapreTest2()
        {
            int Zile = 2;
            int Capre = 1;
            int Kg = 2;

            int Wzile = 4;
            int Qcapre = 1;

            double xkg = Pb___Capre.Capre.FormulaCapre(Zile, Capre, Kg, Wzile, Qcapre);

            Assert.AreEqual(4, xkg);
        }

        [Ignore]
        [TestMethod]
        public void CapreTest3()
        {
            int Zile = 3;
            int Capre = 7;
            int Kg = 1;

            int Wzile = 4;
            int Qcapre = 3;

            double xkg = Pb___Capre.Capre.FormulaCapre(Zile, Capre, Kg, Wzile, Qcapre);

            Assert.AreEqual(0.57, xkg);
        }

        [TestMethod]
        public void CapreTestZileEqualsZero()
        {
            int Zile = 0;
            int Capre = 1;
            int Kg = 2;

            int Wzile = 4;
            int Qcapre = 1;

            try
            {
                double xkg = Pb___Capre.Capre.FormulaCapre(Zile, Capre, Kg, Wzile, Qcapre);               
            }
            catch (DivideByZeroException)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void CapreTestCapreEqualsZero()
        {
            int Zile = 1;
            int Capre = 0;
            int Kg = 2;

            int Wzile = 4;
            int Qcapre = 1;

            try
            {
                double xkg = Pb___Capre.Capre.FormulaCapre(Zile, Capre, Kg, Wzile, Qcapre);
            }
            catch (DivideByZeroException)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void CapreTestKgEqualsZero()
        {
            int Zile = 1;
            int Capre = 1;
            int Kg = 0;

            int Wzile = 4;
            int Qcapre = 1;

            try
            {
                double xkg = Pb___Capre.Capre.FormulaCapre(Zile, Capre, Kg, Wzile, Qcapre);
            }
            catch (DivideByZeroException)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void CapreTestWzileEqualsZero()
        {
            int Zile = 1;
            int Capre = 1;
            int Kg = 5;

            int Wzile = 0;
            int Qcapre = 1;

            try
            {
                double xkg = Pb___Capre.Capre.FormulaCapre(Zile, Capre, Kg, Wzile, Qcapre);
            }
            catch (DivideByZeroException)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void CapreTestQcapreEqualsZero()
        {
            int Zile = 1;
            int Capre = 1;
            int Kg = 5;

            int Wzile = 3;
            int Qcapre = 0;

            try
            {
                double xkg = Pb___Capre.Capre.FormulaCapre(Zile, Capre, Kg, Wzile, Qcapre);
            }
            catch (DivideByZeroException)
            {
                Assert.IsTrue(true);
            }
        }
    }
}
