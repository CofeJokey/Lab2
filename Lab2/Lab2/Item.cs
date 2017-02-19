using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Point
    {
        public int x;
        public int y;
        public void Print()
        {
            Console.WriteLine("x = {0}, y = {1}", x+1, y+1);
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    
    class Item
    {
        public int value;
        public Point point;

        public Item(int el, int x,int y)
        {
            this.value = el;
            this.point = new Point(x, y);
        }

    }
}
