using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Classes
{
    public class MathWorker
    {

        public static double Squared(double value1, double value2) => Math.Pow(value1, value2);

        public static int Factorial(int value)
        {
            int res = 0;
            if (value == 1) return 1;

            else return value * Factorial(value - 1);

        }


    }
}
