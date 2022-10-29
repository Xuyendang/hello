using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hello;

namespace UnitTestProject1
{
    [TestClass]
    
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }
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
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\Data\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]

        [TestMethod]
        public void TestWithDataSource()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            String operation = TestContext.DataRow[2].ToString();
            operation = operation.Remove(0, 1);
            int expected = int.Parse(TestContext.DataRow[3].ToString());
            Calculation c = new Calculation(a, b);
            int actual = c.Execute(operation);
            Assert.AreEqual(expected, actual);
        }

    }
}
