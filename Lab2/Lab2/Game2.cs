using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Game2 :Game
    {
        //int leght = 4;
        //int height = 4;
        public Game2()
        {
            int tmp=0;
            items = new Item[16]; 
            Random rnd = new Random();
            int[] numbers = new int[16];
           
            for (int i = 0; i < 16;i++ )
            {
                bool fl = false;
                do
                {
                    fl = false;
                    tmp = rnd.Next(0, 16);
                    for(int j=0;j<i;j++)
                    {
                        if (tmp == numbers[j]) { fl = true; }
                    }
                }
                while (fl);
                numbers[i] = tmp;
            }


            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    items[i * 4 + j] = new Item(numbers[i * 4 + j], i, j);
                }

            }

             
        }
        //public Boolean finish()
        //{
        //    int i = 0;
        //    int j = 0;
        //    int c;

        //    for (c = 1; c < leght * height; c++)
        //    {
        //        if (items[i] != c) return false;

        //        if (i < leght - 1) i++;
        //        else { i = 0; j++; }
        //    }
        //    return true;
        //}


        //public Boolean Finish()
        //{

        //    var ep =new Item [1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,0]; 
        //      var res = true; 
        //      for (var i = 0; i <= 16; i++) { 
        //      //for (var j = 0; j < 4; j++) { 
        //              if (ep[] != ep[i]) { 
        //      res = false; 
        //      //} 
        //      } 
        //      } 
        //      return res;

        // int nw = 4;
        //// int height = 4;
        // bool temp = false;
        // int value = 1;
        // for (int i = 0; i < this.Length; ++i)
        // {
        //     //for (int j = 0; j < height; ++j)
        //     //{
        //     if (items[i].value == value)
        //         {

        //             temp = true;
        //         }
        //         else
        //         {
        //             return false;
        //         }
        //         ++value;
        //    // }

        // }
        // return temp;

        // }

        //public Boolean EndGame()
        //{
        //    bool fl = false;
        //    int value = 1;
        //    for (int i = 0; i < 4; ++i)
        //    {
        //        for (int j = 0; j < 4; ++j)
        //        {
        //            if ( Point(i, j) == value)
        //            {

        //                fl = true;
        //                value++;
        //                if (value == Lenght)
        //                {
        //                    value = 0;
        //                }
        //            }
        //            else
        //            {
        //                return false;
        //            }

        //        }


        //    }
        //    return fl;
        //}


        //public bool Win
        //{
        //    get
        //    {
        //        for (int i = 0; i < items.Length; i++)
        //        {
        //            for (int j = 0; j < items.Length; j++)
        //            {
        //                if (i == items.Length - 1 && j == items.Length - 1 && this[i, j] == 0)
        //                    continue;
        //                else if (this[i, j] == i * items.Length + j + 1 && (i != items.Length - 1 || j != items.Length - 1))
        //                    continue;
        //                else return false;
        //            }
        //        }
        //        return true;
        //    }
        //}



    }
}
