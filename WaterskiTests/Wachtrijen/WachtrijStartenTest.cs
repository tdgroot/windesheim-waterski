using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Waterski;
using Waterski.Wachtrijen;

namespace WaterskiTests.Wachtrijen
{
    [TestClass]
    public class WachtrijStartenTest
    {
        [TestMethod]
        public void TestVoegSporterToeAanRij()
        {
            var wachtrij = new WachtrijStarten();

            Assert.AreEqual(wachtrij.Wachtrij.Count, 0);
            wachtrij.VoegSporterToeAanRij(new Sporter());
            Assert.AreEqual(wachtrij.Wachtrij.Count, 1);
        }
    }
}
