using ExercicioShape.Model.Entities;
using ExercicioShape.Model.Enum;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractShape circle = new Circle(2.0, Colors.GREN);
            AbstractShape rectangle = new Rectangle(3.5, 4.2, Colors.BLUE);
            Console.WriteLine(circle.ToString());
            Console.WriteLine(rectangle.ToString());
        }
    }
}