using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsolePourTestTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int i = 1;
            int j = 2;
            Assert.AreEqual(3, i + j);
        }
    }
}
