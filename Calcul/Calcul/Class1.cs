using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calcul
{
    public class Task : INF
    {

        public void Sub(int a, int b)
        {
            int d = a - b;
            Console.WriteLine("{0}-{1}={2}", a, b, d);
        }

        public void Div(double a, double b)
        {

            if (Math.Abs(b) < 0.00001)
                Console.WriteLine("На ноль делить нельзя");
            else
            {
                double ff = a / b;
                Console.WriteLine("{0}/{1}={2}", a, b, ff);
            }

        }

        public void Sub(double a, double b)
        {
            double dd = a - b;
            Console.WriteLine("{0}-{1}={2}", a, b, dd);
        }
    }

}