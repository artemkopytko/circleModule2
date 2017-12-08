using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Circle;


namespace UnitTestAreaIsCorrect11
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAreaIsCorrect11()
        {
            int radius = 11;
            double expected = radius * radius * Math.PI;

            CircleClass circle = new CircleClass { radius = 11 };

            Assert.AreEqual(expected, circle.GetArea(circle));

        }
    }
}
