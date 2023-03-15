using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Snack : Figura
    {
        public Snack(Point tail, int lenght, Directions direction )
        { 
            pList = new List<Point>();

            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
            
        }
    }
}
