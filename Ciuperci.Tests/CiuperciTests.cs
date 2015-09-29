using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ciuperci;

namespace Ciuperci.Tests
{
    [TestClass]
    public class CiuperciTests
    {
        [TestMethod]
        public void CiuperciTest1()
        {
            int numarCiuperci = 12;
            int x = 2;
            int ciuperciAlbe = Ciuperci.FormulaCiuperciAlbe(numarCiuperci, x);
            int ciuperciRosii= Ciuperci.FormulaCiuperciRosii(ciuperciAlbe,x); 

            Assert.AreEqual(4, ciuperciAlbe, "Wrong number for ciuperci albe");
            Assert.AreEqual(8, ciuperciRosii, "Wrong number for ciuperci rosii");            
        }

        [TestMethod]
        public void CiuperciTest2()
        {
            int numarCiuperci = 0;
            int x = 100;
            int ciuperciAlbe = Ciuperci.FormulaCiuperciAlbe(numarCiuperci, x);
            int ciuperciRosii = Ciuperci.FormulaCiuperciRosii(ciuperciAlbe, x);

            Assert.AreEqual(0, ciuperciAlbe, "Wrong number for ciuperci albe");
            Assert.AreEqual(0, ciuperciRosii, "Wrong number for ciuperci rosii");
        }
    }
}
