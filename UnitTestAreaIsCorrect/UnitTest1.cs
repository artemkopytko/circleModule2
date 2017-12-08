using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Circle;


namespace UnitTestAreaIsCorrect5
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAreaIsCorrect5()
        {
            int radius = 5;
            double expected = radius * radius * Math.PI;

            CircleClass circle = new CircleClass { radius = 5 };

            Assert.AreEqual(expected, circle.GetArea(circle));

        }
    }
}
