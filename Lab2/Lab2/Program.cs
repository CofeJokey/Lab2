using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game3 = new Game(7, 8, 0, 2, 3, 1, 4, 6, 5);
            game3.Print();
            Game game4 = new Game(7, 8, 0, 2, 3, 1, 4, 6, 5,9,10,11,12,13,14,15);
            game4.Print();
            Console.WriteLine(game4.GetLocation(4));

        }
    }
}
