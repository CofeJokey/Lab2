﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Game3 :Game2
    {
        private List<int> Steps;
        static int StepCount =0;
       Dictionary<int, Point> Step = new Dictionary<int, Point>();
        public Game3(int el1, int el2, int el3, int el4, int el5, int el6, int el7, int el8,
            int el9, int el10, int el11, int el12, int el13, int el14, int el15, int el16)
            : base( el1, el2,  el3,  el4,  el5,  el6,  el7,  el8,
             el9,  el10,  el11,  el12,  el13,  el14,  el15,  el16)
        { 
        Steps = new List<int>();
        //StepCount = 0;
        }



        public void History(int newvalue)
        {
            StepCount++;
            Step[StepCount] = items[newvalue].point;
        }

        

        public void StepBack(int value)
        {
           // int i = StepCount;
            this.Shift(value,this);

          //  this.Shift(Steps[i], this);
          //  i--;
        }
   }
}
