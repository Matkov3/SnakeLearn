using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class HorizontalLine
    {
        List<Point> pList;
        public HorizontalLine(int xRight, int xLeft, int y, char symbol)
        {
            pList = new List<Point>();

            for (int x = xRight; x <= xLeft; x++)
            {
                Point p = new Point(x, y, symbol);
                pList.Add(p);
            }
        }

        public void Drow()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
