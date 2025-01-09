using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Из_Методички.classes
{ 
    public class Circle : Point
    {
        public double Radius { get; private set; }

        public Circle(int x, int y, double radius, string color, bool visible)
            : base(x, y, color, visible)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Круг: Радиус = {Radius}, Площадь = {CalculateArea():F2}");
        }
    }
}
