using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WebApplication;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DemoClass obj = new DemoClass();
            Assert.AreEqual("Raj", obj.fname);
            Assert.AreEqual("Shrivastva", obj.lname);
        }
    }
}
