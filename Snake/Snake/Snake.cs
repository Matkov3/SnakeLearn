

using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace Snake;

public class Snake
{
    static void Main()
    {
        int x1 = 1;
        int y1 = 5;
        char symb1 = '*';
        Draw(x1, y1, symb1);

        int x2 = 3;
        int y2 = 7;
        char symb2 = '%';
        Draw(x2, y2, symb2);

        Console.ReadLine();
    }

    public static void Draw(int x, int y, char symb)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(symb);
       }

}