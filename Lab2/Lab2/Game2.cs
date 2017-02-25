using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Game2 :Game
    {
        public Game2()
        {
            int tmp=0;
            items = new Item[16]; 
            Random rnd = new Random();
            int[] numbers = new int[16];
            for (int i = 0; i < 16;i++ )
            {
                bool isExist=false;
                do
                {
                    isExist = false;
                    tmp = rnd.Next(0, 16);
                    for(int j=0;j<i;j++)
                    {
                        if (tmp == numbers[j]) { isExist = true; }
                    }
                }
                while (isExist);
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
    }
}
