using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hello;

namespace UnitTestProject1
{
    [TestClass]
    
    public class UnitTest1
    {
        private Calculation cal;
        [TestInitialize]
        public void SetUp()
        {
            this.cal = new Calculation(5, 5);
        }
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(cal.Execute("+"), 10);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(cal.Execute("-"), 0);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(cal.Execute("*"), 25);
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(cal.Execute("/"), 1);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivedByZero()
        {
            Calculation c = new Calculation(5, 0);
            c.Execute("/");
        }
    }
}
