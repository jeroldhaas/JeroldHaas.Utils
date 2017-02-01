using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using JeroldHaas.Utils.Enums;

namespace JeroldHaas.Utils.Test
{
    [TestClass]
    public class TestUtils
    {
        public enum Foo
        {
            One,
            Two,
            Three
        }

        [TestMethod]
        public void NameOf_Returns_Name_Of_Enumeration()
        {
            var one = Foo.One;
            var oneName = one.Name();

            Assert.AreEqual("One", oneName, false, "Case Sensitive Test");
            Assert.AreEqual("one", oneName, true, "Case Insensitive Test");
        }
    }
}
