using System;

namespace Circle
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Counting circle area");
            CircleClass firstCircle = new CircleClass { radius = 5 };
            CircleClass secondCircle = new CircleClass { radius = 7 };
            CircleClass thirdCircle = new CircleClass { radius = 9 };
            CircleClass fourthCircle = new CircleClass { radius = 11 };
            Console.WriteLine("Circle №1, radius = {0}, area = {1}", firstCircle.radius, firstCircle.GetArea(firstCircle));
            Console.WriteLine("Circle №2, radius = {0}, area = {1}", secondCircle.radius, secondCircle.GetArea(secondCircle));
            Console.WriteLine("Circle №3, radius = {0}, area = {1}", thirdCircle.radius, thirdCircle.GetArea(thirdCircle));
            Console.WriteLine("Circle №4, radius = {0}, area = {1}", fourthCircle.radius, fourthCircle.GetArea(fourthCircle));
            Console.WriteLine("Total area = {0}", firstCircle.GetArea(firstCircle) + secondCircle.GetArea(secondCircle) + thirdCircle.GetArea(thirdCircle) + fourthCircle.GetArea(fourthCircle));
        }
    }


    public class CircleClass
    {
        public double radius = 0.0;

        public double GetArea(CircleClass circle)
        {
            return Math.PI * circle.radius * circle.radius;
        }
    }
}
