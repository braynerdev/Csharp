using ExercicioShape.Model.Enum;
using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioShape.Model.Entities
{
    internal class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public Circle(double radius, Colors color)
            : base(color)
        {
            Radius = radius;
        }

        public override double area()
        {
            return Math.PI * Math.Pow(Radius,2);
        }

        public override string ToString()
        {
            return $"Area do Circle: {area().ToString("F2",CultureInfo.InvariantCulture)} - {Color}";
        }
    }
}
