using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int yBottom, int yTop, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yBottom; y <= yTop; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }
}
