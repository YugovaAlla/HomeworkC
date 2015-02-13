using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calcul
{
    class Program
    {
        static void Main(string[] args)
        {
            var ex = new Task();
            ex.Sub(20.5,28.02);
            ex.Sub(25,27);
            ex.Div(23.5, 2);
            ex.Div(5,0);

            var t = new Calc();
            Console.WriteLine(t.Summ(3, 5));
            Console.WriteLine(t.Summ(3.4, 5.3));
            Console.WriteLine(t.Multiply(3, 5));
            Console.WriteLine(t.Multiply(3.7, 5.34));
            Console.ReadLine();
        }
    }
}
