using System;


namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');            
            p1.Draw();            
            
            Point p2 = new Point(2, 3, '#');            
            p2.Draw();

            HorizontalLine lineG = new HorizontalLine(4, 10, 8, '+');
            lineG.Draw();

            VerticalLine lineV = new VerticalLine(8, 15, 3, '|');
            lineV.Draw();
            
        }       

    }
}
