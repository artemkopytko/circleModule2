using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Circle;


namespace UnitTestAreaIsCorrect7
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestAreaIsCorrect7()
        {
            int radius = 7;
            double expected = radius * radius * Math.PI;

            CircleClass circle = new CircleClass { radius = 7 };

            Assert.AreEqual(expected, circle.GetArea(circle));

        }
    }
}
