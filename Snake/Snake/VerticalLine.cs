using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class VerticalLine
    {
        List<Point> points;

        public VerticalLine(int x, int yRight, int yLeft, char symb)
        {
                points =new List<Point>();

                for (int y = yRight; y <= yLeft; y++)
                {
                    Point p = new Point(x, y, symb);
                    points.Add(p);
                }
        }


        public void DrawVertyc()
        {
            foreach (Point p in points)
            {
                p.Draw();
            }
        }
    }
}
