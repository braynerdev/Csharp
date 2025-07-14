using ExercicioShape.Model.Enum;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioShape.Model.Entities
{
    abstract internal class AbstractShape : IShape
    {
        public Colors Color { get; set; }

        protected AbstractShape(Colors color)
        {
            Color = color;
        }

        public abstract double area();

    }
}
