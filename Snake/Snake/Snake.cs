

using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace Snake;

public class Snake
{
    static void Main()
    {
        Point point1 = new Point();
        point1.x = 5;
        point1.y = 10;
        point1.symbl = '*';
        point1.Draw();

        Point point2 = new Point();
        point2.x = 1;
        point2.y = 6;
        point2.symbl = '%';
        point2.Draw();

        Console.ReadLine();
    }
}