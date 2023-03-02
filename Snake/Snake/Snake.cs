

using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace Snake;

public class Snake
{
    static void Main()
    {
        Point point1 = new Point(5,7, '*');
        point1.Draw();
       
        Point point2 = new Point(9,16,'#');
        point2.Draw();

        Console.ReadLine();
    }
}