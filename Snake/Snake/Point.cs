using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
     class Point
     {
         public int x;
         public int y;
         public char symbl;

        public Point(int _x, int _y, char _symbl)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"\t Enter new point: ");
            x = _x; 
            y = _y;
            symbl = _symbl;
            
        }

        public void Draw()
         {
             Console.SetCursorPosition(x, y);
             Console.Write(symbl);
         }
     }
}
