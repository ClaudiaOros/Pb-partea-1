using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sportiv;

namespace Sportiv.Tests
{
    [TestClass]
    public class SportivTests
    {
        [TestMethod]
        public void SportivTest1()
        {
            int numarRunde = 10;
            int numarRepetitii = Sportiv.FormulaSportiv(numarRunde);

            Assert.AreEqual(110, numarRepetitii, "Numarul de repetitii nu e cel asteptat.");
        }
    }
}
