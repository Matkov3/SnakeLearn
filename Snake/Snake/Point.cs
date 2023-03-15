using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Point
     {
         public int x;
         public int y;
         public char symbl;

        public Point(int _x, int _y, char _symbl)
        {
            Console.WriteLine();
            x = _x; 
            y = _y;
            symbl = _symbl;
            
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;    
            symbl = p.symbl;
        }

        public void Move( int offset, Directions directions)
        {
            if (directions ==Directions.RIGHT)
            {
                x = x + offset;
            }
            else if (directions == Directions.LEFT)
            {
                x = x - offset;
            }
            else if (directions == Directions.UP)
            {
                y = y + offset;
            }
            else if (directions == Directions.DOWN)
            {
                y = y - offset;
            }
        }

        public void Draw()
         {
             Console.SetCursorPosition(x, y);
             Console.Write(symbl);
         }

        public override string ToString()
        {
            return x + "," + y + "," + symbl;
        }
     }
}
