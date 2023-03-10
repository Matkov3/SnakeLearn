

using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace Snake;

public class Snake
{
    
    static void Main()
    {
        
        Point point1 = new Point(5,7, '*');
        point1.Draw();
        Console.WriteLine();
        
        Point point2 = new Point(9,6,'#');
        point2.Draw();
        Console.WriteLine();

        Point point3 = new Point(3,10,'&');
        point3.Draw();
        Console.WriteLine();

        Point point4 = new Point(9,1,'@');
        point4.Draw();
        Console.WriteLine();
        
        List<Point> points = new List<Point>(4);
        points.Add(point1);
        points.Add(point2);
        points.Add(point3);
        points.Add(point4);

        foreach (var symble in points)
        {
            Console.Write($"{symble.symbl}\n");
        }



        Console.ReadLine();
        
    }
   
}