using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Из_Методички.classes
{
    public class Rectangle : Point
    {
        public double Width { get; private set; }
        public double Height { get; private set; }

        public Rectangle(int x, int y, double width, double height, string color, bool isVisible)
            : base(x, y, color, isVisible)
        {
            Width = width;
            Height = height;
        }

        public double CalculateArea()
        {
            return Width * Height;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Прямоугольник: Ширина = {Width}, Высота = {Height}, Площадь = {CalculateArea()}");
        }
    }
}
