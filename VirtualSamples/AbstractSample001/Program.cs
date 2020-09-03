using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSample001
{
    abstract class Shape
    {
        public abstract double GetArea();
    }

    class Square : Shape
    {
        double _side;
        public Square(double side)
        {
            _side = side;
        }
        public override double GetArea()
        {
            return Math.Pow(_side, 2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(5);
            Console.WriteLine(square.GetArea());
            Console.ReadLine();
        }
    }
}
