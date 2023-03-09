

using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace Snake;

public class Snake
{

    public static int Func1(int value)
    {
        return value;
    }

    public static int Func2(int value)
    {
      return   value = value + 1;
    }

   
    
    static void Main()
    {
        int x = 1;
        Func1(x);
        Console.WriteLine($"Enter x {x}");

        int y = 12;
        Func2(y);
        Console.WriteLine($"Enter y {y}");

        
    Point point1 = new Point(5,7, '*');
        point1.Draw();
        Move(point1, 34,15);
        Console.WriteLine($"Contain x {point1.x}, y {point1.y}");
       
        Point point2 = new Point(9,16,'#');
        point2.Draw();
        Reset(point2);
        Console.WriteLine($"Contains x {point2.x}, y {point2.y}");

        Console.ReadLine();


         static void Move(Point p, int dx, int dy)
        {
            p.x = p.x + dx;
            p.y = p.y + dy;
        }

         static void Reset(Point p)
         {
             p = new Point(23,17,'v');
         }

    }
   
}