﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    public class ShoppingCar
    {
        public double GetResult(int diffentBookCount)
        {
            var result = 0d;

            if (diffentBookCount == 2)
            {
                result = 100.0 * (double)diffentBookCount * 0.95;
            }

            if (diffentBookCount == 3)
            {
                result = 100.0 * (double)diffentBookCount * 0.9;
            }

            if (diffentBookCount == 4)
            {
                result = 100.0 * (double)diffentBookCount * 0.8;
            }

            if (diffentBookCount == 5)
            {
                result = 100.0 * (double)diffentBookCount * 0.75;
            }

            return result;
        }

        public double GetResult(int diffentBookCount,int sameBookCount)
        {
            var result = 0d;

            result = this.GetResult(diffentBookCount) + 100 * sameBookCount;

            return result;
        }
    }

}
