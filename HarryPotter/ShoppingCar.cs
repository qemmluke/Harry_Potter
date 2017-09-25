using System;
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

            return result;
        }
    }

}
