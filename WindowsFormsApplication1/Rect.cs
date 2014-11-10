using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Rect
    {
        // protected виден в наследниках и классах
        // privat только в самом классе
        public int X;
        public int Y;
        public int Widht;
        public int Height;
        public Color Color;

        public void Draw(Graphics gr)
        {
            Pen pen = new Pen(Color, 7);
            gr.DrawRectangle(pen, X, Y, Widht, Height);
        }

        public bool IsInsaide(int x, int y)
        {
            if ((X <= x) && (x <= X + Widht) && (Y <= y) && (y <= Y + Height))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
