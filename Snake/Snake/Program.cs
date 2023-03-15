

using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace Snake;

public class Program
{
    
    static void Main()
    {
        
        //Point point1 = new Point(5,7, '*');
        //point1.Draw();
        //Console.WriteLine();
        
        //Point point2 = new Point(9,6,'#');
        //point2.Draw();
        //Console.WriteLine();

        //Point point3 = new Point(3,10,'&');
        //point3.Draw();
        //Console.WriteLine();

        //Point point4 = new Point(9,1,'@');
        //point4.Draw();
        //Console.WriteLine();
        
        Console.WriteLine();
        
        //Console.SetBufferSize(70, 30);

        //HorizontalLine upLin = new HorizontalLine(0, 65, 0, '*');
        //HorizontalLine downLin = new HorizontalLine(0, 65, 25, '*');
        //VerticalLine leftLine = new VerticalLine(0, 0, 25, '*');
        //VerticalLine rightLine = new VerticalLine(65, 0,25, '*');
        //upLin.Drow();
        //downLin.Drow();
        //leftLine.Drow();
        //rightLine.Drow();

        //HorizontalLine gHorizontalLine = new HorizontalLine(4,12,10,'%');
        //gHorizontalLine.Drow();

        //VerticalLine verticalLine = new VerticalLine(5, 1,9,'*');
        //verticalLine.DrawVertyc();


        Point p = new Point(4, 9, '&');
        Snack sneck = new Snack(p, 5, Directions.DOWN);
        sneck.Drow();

        Console.ReadLine();
        
    }
   
}