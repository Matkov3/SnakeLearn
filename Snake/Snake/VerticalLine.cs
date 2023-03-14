using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class VerticalLine : Figura
    {
       

        public VerticalLine(int x, int yRight, int yLeft, char symb)
        {
                pList =new List<Point>();

                for (int y = yRight; y <= yLeft; y++)
                {
                    Point p = new Point(x, y, symb);
                    pList.Add(p);
                }
        }


        
    }
}
