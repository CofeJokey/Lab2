﻿using System;
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
           // Game game3 = new Game(7, 8, 0, 2, 3, 1, 4, 6, 5, 9, 10, 11, 12, 13, 14, 15);
            Game3 game4 = new Game3(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 0, 15);
         //   Game2 game = new Game2();
            //   game4.RandomValues();
            Console.WriteLine("***** Игра в 15 ****");
            Console.WriteLine();
            game4.Print();
            while (true)
            {
                Console.WriteLine("Выберите действие:" + Environment.NewLine + "1 - играть" + Environment.NewLine + "2 - отмена хода" + Environment.NewLine + "6 - выход");


                try
                {
                    int key = Convert.ToInt16(Console.ReadLine());
                    if (key <= 0 || key > 6) { throw new Exception(); }

                    switch (key)
                    {
                        case 1:
                            Console.WriteLine("Двигайте цифру");
                            int NewValue = Convert.ToInt16(Console.ReadLine());
                            game4.Shift(NewValue,game4);
                            game4.Print();
                            if (game4.EndGame())
                            {
                                // game4.Print();
                                Console.WriteLine("Вы прошли игру");
                                break;
                            }
                         Console.WriteLine("1 - Отменить шаг, 2 - продолжить игру");
                         try
                         {
                             int keys = Convert.ToInt16(Console.ReadLine());
                             if (keys <= 0 || keys > 2) { throw new Exception(); }
                             switch (keys)
                             {
                                 case 1:
                                 //    Console.WriteLine("awdawd");   
                                     game4.StepBack(NewValue);
                                     game4.Print();
                                     break;

                                 case 2:
                                     break;

                                
                                 default: break;
                             }
                         }
                         catch
                         {
                             Console.WriteLine("Недопустимый символ, попробуйте еще раз");
                         }
                            
                            break;

                        case 2:
                            
                            Console.WriteLine("не доработано");
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

                //if (game4.EndGame())
                //{
                //    game4.Print();
                //    Console.WriteLine("Вы прошли игру");

                //}

            }
            
        }
    }

   
}