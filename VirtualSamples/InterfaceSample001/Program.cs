using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample001
{
    interface IPoint
    {
        int X { get; set; }
        int Y { get; set; }
        double Distance { get; }
    }

    class Point : IPoint
    {
        public int X { get; set; }
        public int Y { get; set; }

        public double Distance 
        {
            get 
            {
                return Math.Sqrt(X * X + Y * Y);
            } 
        }

        public Point(int x,int y)
        {
            X = x;
            Y = y;
        }
    }

    class Point2 : IPoint
    {
        public int X { get; set; }
        public int Y { get; set; }

        public double Distance
        {
            get
            {
                return X + Y;
            }
        }
        public Point2(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Point(2, 3);
            var p1Result = p.Distance;
            PrintPoint(p);

            var p2 = new Point2(1, 3);
            var p2Result = p2.Distance;
            PrintPoint(p2);

            Console.WriteLine($"{p1Result} + {p2Result}");
            Console.ReadLine();
        }

        public static void PrintPoint(IPoint p)
        {
            Console.WriteLine($"x = {p.X}, y = {p.Y}");
        }
    }
}
