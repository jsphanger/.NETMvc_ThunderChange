using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JAThunderNAT.Models;

namespace JAThunderNAT.Tests
{
    [TestClass]
    public class ChangegiverTest
    {
        [TestMethod]
        public void GetChange()
        {
            var change = ThunderChange.MakeChange(".99");
            Assert.IsTrue(change.Keys.Count > 0);
            Assert.AreEqual(change["half-dollar"], 1);
            Assert.AreEqual(change["quarter"], 1);
            Assert.AreEqual(change["dime"], 2);
            Assert.AreEqual(change["penny"], 4);

            change = ThunderChange.MakeChange("1.56");
            Assert.AreEqual(change["silver-dollar"], 1);
            Assert.AreEqual(change["half-dollar"], 1);
            Assert.AreEqual(change["nickel"], 1);
            Assert.AreEqual(change["penny"], 1);

            change = ThunderChange.MakeChange("12.85");
            Assert.IsTrue(change.Keys.Count > 0);
            Assert.AreEqual(change["silver-dollar"], 12);
            Assert.AreEqual(change["half-dollar"], 1);
            Assert.AreEqual(change["quarter"], 1);
            Assert.AreEqual(change["dime"], 1);
        }
    }
}
