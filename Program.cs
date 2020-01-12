using System;

namespace L20200108_Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Point point;
            point.x = 18;
            point.y = 30;
            Point anotherPoint = point;
            point.x++;
            Console.WriteLine(anotherPoint.x);
            Car myCar;
            myCar.color = 123;
            myCar.make = "Toyota";
            myCar.model = "Corolla";
            Console.WriteLine("(" + point.x + ", " + point.y + ")");

            Console.ReadLine();

        }

        static void Distance(int x1, int y1, int z1, int x2, int y2, int z2)
        {

        }
    }

    struct Point
    {
        public int x, y;
    }

    struct Car
    {
        public int color;
        public string make;
        public string model;
        public bool hasAirBags;
        public int yearOfManufacture;
        public int millage;
    }
}
