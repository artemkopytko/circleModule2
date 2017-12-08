using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Circle;


namespace UnitTestIsRadiusCorrect
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAreaIsRadCor()
        {
            int radius = 5;
            double expected = true;

            CircleClass circle = new CircleClass { radius = 5 };

            Assert.AreEqual(expected, circle.IsRadiusPositive(circle));

        }
    }
}
