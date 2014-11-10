using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Rect rectangle = new Rect();
        private Random r = new Random(DateTime.Now.TimeOfDay.Milliseconds);

            
        public Form1()
        {

            InitializeComponent();
            rectangle.X = 50;
            rectangle.Y = 50;
            rectangle.Widht = 150;
            rectangle.Height = 100;
            rectangle.Color = Color.DeepPink;
            DoubleBuffered = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            rectangle.Draw(e.Graphics);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (rectangle.IsInsaide(e.X, e.Y))
            {
                rectangle.Color = Color.DarkTurquoise;
            }
            else
            {
                rectangle.Color = Color.DarkRed;
            }
            Refresh();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            rectangle.X = r.Next(0, this.Width);
            rectangle.Y = r.Next(0, this.Height);
            Refresh();
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            rectangle.Height = r.Next(0, 150);
            rectangle.Widht = r.Next(0, 150);
            Refresh();
        }

        
    }
}
