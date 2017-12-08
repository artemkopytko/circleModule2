using System;

namespace Circle
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Circle area");
            Circle c1 = new Circle { r = 5 };// c1 = firstCircle, r = Radius
            Circle c2 = new Circle { r = 7 };
            Circle c3 = new Circle { r = 9 };
            Circle c4 = new Circle { r = 11 };
            Console.WriteLine("Circle 1, rad equals {0}, area equals {1}", c1.r, c1.getArea(c1));
            Console.WriteLine("Circle 1, rad equals {0}, area equals {1}", c2.r, c1.getArea(c2));
            Console.WriteLine("Circle 1, rad equals {0}, area equals {1}", c3.r, c1.getArea(c3));
            Console.WriteLine("Circle 1, rad equals {0}, area equals {1}", c4.r, c1.getArea(c4));
            Console.WriteLine("Area sum eqals {0}", c1.getArea(c1) + c2.getArea(c2) + c3.getArea(c3) + c4.getArea(c4));
        }
    }

    public class Circle
    {
        public double r = 0.0; // radius

        public double getArea(Circle c)// <- circle & Get
        {
            return Math.PI * c.r * c.r;
        }
    }
}
