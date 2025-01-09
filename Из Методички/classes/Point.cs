using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Из_Методички.classes
{
    public class Point : Figure
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Point(int x, int y, string color, bool visible)
            : base(color, visible)
        {
            X = x;
            Y = y;
        }

        public override void MoveHorizontal(int distance)
        {
            X += distance;
        }

        public override void MoveVertical(int distance)
        {
            Y += distance;
        }

        public override void Display()
        {
            Console.WriteLine($"Точка: ({X}, {Y}), Цвет: {Color}, Видимость: {Visible}");
        }
    }
}
