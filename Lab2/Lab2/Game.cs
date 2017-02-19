using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Game
    {
         Item[] items;
        public int Length
        {
            get 
            {
                return Convert.ToInt32(Math.Sqrt(items.Length)); 
            }
        }
        public Game (int el1,int el2, int el3, int el4, int el5,int el6,int el7,int el8,int el9)
        {
            items = new Item[] 
            {
                new Item(el1,0,0),
                new Item(el2,0,1),
                new Item(el3,0,2),

                new Item(el4,1,0),
                new Item(el5,1,1),
                new Item(el6,1,2),

                new Item(el7,2,0),
                new Item(el8,2,1),
                new Item(el9,2,2)
            };
        }

        public Game(int el1, int el2, int el3, int el4, int el5, int el6, int el7, int el8, int el9, int el10, int el11, int el12, int el13, int el14, int el15, int el16)
        {
            items = new Item[] 
            {
                new Item(el1,0,0),
                new Item(el2,0,1),
                new Item(el3,0,2),
                new Item(el4,0,3),

                new Item(el5,1,0),
                new Item(el6,1,1),
                new Item(el7,1,2),
                new Item(el8,1,3),

                new Item(el9,2,0),
                new Item(el10,2,1),
                new Item(el11,2,2),
                new Item(el12,2,3),

                new Item(el13,3,0),
                new Item(el14,3,1),
                new Item(el15,3,2),
                new Item(el16,3,3),
            };
        }

        public Item this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                items[index] = value;
            }
        }
        public void Print()
        {
            for (int i=0;i<this.Length;i++)
            {
                for (int j = 0; j <this.Length;j++ )
                {
                    Console.Write("{0,5}",items[i*this.Length+j].value);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        
        public int GetLocation(int value)
        {
            for (int i=0;i<items.Length;i++)
            {
                if (items[i].value==value)
                {
                    return items[i].point.x * this.Length + items[i].point.y;
                }
            }
            return -1;
        }


    }
}
