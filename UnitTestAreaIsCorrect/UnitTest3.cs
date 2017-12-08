using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Circle;


namespace UnitTestAreaIsCorrect9
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAreaIsCorrect9()
        {
            int radius = 9;
            double expected = radius * radius * Math.PI;

            CircleClass circle = new CircleClass { radius = 9 };

            Assert.AreEqual(expected, circle.GetArea(circle));

        }
    }
}
