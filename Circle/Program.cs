using System;

namespace Circle
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Counting circle area");
            Circle firstCircle = new Circle { radius = 5 };
            Circle secondCircle = new Circle { radius = 7 };
            Circle thirdCircle = new Circle { radius = 9 };
            Circle fourthCircle = new Circle { radius = 11 };
            Console.WriteLine("Circle №1, radius = {0}, area = {1}", firstCircle.radius, firstCircle.GetArea(firstCircle));
            Console.WriteLine("Circle №2, radius = {0}, area = {1}", secondCircle.radius, secondCircle.GetArea(secondCircle));
            Console.WriteLine("Circle №3, radius = {0}, area = {1}", thirdCircle.radius, thirdCircle.GetArea(thirdCircle));
            Console.WriteLine("Circle №4, radius = {0}, area = {1}", fourthCircle.radius, fourthCircle.GetArea(fourthCircle));
            Console.WriteLine("Total area = {0}", firstCircle.GetArea(firstCircle) + secondCircle.GetArea(secondCircle) + thirdCircle.GetArea(thirdCircle) + fourthCircle.GetArea(fourthCircle));
        }
    }

    public class Circle
    {
        public double radius = 0.0;

        public double GetArea(Circle circle)
        {
            return Math.PI * circle.radius * circle.radius;
        }
    }
}
