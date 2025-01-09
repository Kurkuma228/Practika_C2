using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Из_Методички.classes
{
    public abstract class Figure
    {
        public string Color { get; set; }
        public bool Visible { get; set; }

        protected Figure(string color, bool visible)
        {
            Color = color;
            Visible = visible;
        }

        public abstract void MoveHorizontal(int distance);

        public abstract void MoveVertical(int distance);

        public void ChangeColor(string newColor)
        {
            Color = newColor;
        }

        public void SetVisibility(bool visibility)
        {
            Visible = visibility;
        }

        public abstract void Display();
    }
}
