using ExercicioShape.Model.Enum;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioShape.Model.Entities
{
    internal class Rectangle : AbstractShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Colors color)
            : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return $"Area do Rectangle {area().ToString("F2", CultureInfo.InvariantCulture)} - {Color}";
        }
    }
}
