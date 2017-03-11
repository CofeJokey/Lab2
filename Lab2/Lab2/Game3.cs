using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Game3 :Game2
    {
        static int StepCount;
        Dictionary<int, Point> Steps = new Dictionary<int, Point>();
        public Game3() : base()
        { }

        //public void StepHistory(int newvalue)
        //{
        //    StepCount++;
        //    Steps[StepCount] = GetLocation(newvalue);
        //}


        //public void StepBack(int newvalue)
        //{
        //    int i = StepCount;

        //    this.Shift(this.[Steps[i].x, Steps[i].y], this);

        //    i--;

        //}


        //public void StepForvard(int newvalue)
        //{
        //    int i = StepCount;

        //    this.Shift(this.[Steps[i].x, Steps[i].y], this);
        //    i++;

        //}


    }
}
