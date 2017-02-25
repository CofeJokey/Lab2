using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab2
{
    class Program
    {
        static public void Play(Game game4)
        {
            while (true)
            {
                Console.WriteLine("Играйте дальше, пока не нажмете 60");
                try
                {
                    int tmp=Convert.ToInt16(Console.ReadLine());
                    if (tmp!=60)
                    {
                        game4.Shift(tmp);
                    }
                    else break;
                    game4.Print();
                }
                catch
                {
                    Console.WriteLine("Недопустимый символ, попробуйте еще раз");
                }
            }
        }
        static void Main(string[] args)
        {
            Game game5 = new Game(7, 8, 0, 2, 3, 1, 4, 6, 5, 9, 10, 11, 12, 13, 14, 15);

            Game2 game4 = new Game2();
            game4.Print();
            while (true)
            {
                Console.WriteLine("Выберите действие:" + Environment.NewLine + "1 - играть" + Environment.NewLine + "6 - выход");


                try
                {
                    int key = Convert.ToInt16(Console.ReadLine());
                    if (key <= 0 || key > 6) { throw new Exception(); }

                    switch (key)
                    {
                        case 1:
                           // Console.WriteLine("Двигаайте цифру");
                           // game4.Shift(Convert.ToInt16(Console.ReadLine()));
                           // game4.Print();
                            Play(game4);
                            break;
                        case 6:
                            Environment.Exit(0);
                            break;
                        default:
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Недопустимый символ, попробуйте еще раз");
                }
            }
            
        }
    }

   
}