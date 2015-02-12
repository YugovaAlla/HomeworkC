using System;
using TeamInterfaceApplication;

namespace Calcul
{
    class Program
    {
        static void Main(string[] args)
        {
            var ex1 = new Task("23", "28");
            ex1.ISub();
            var ex2 = new Task("23,5", "28,2");
            ex2.DSub();
            var ex3 = new Task("23,5", "29,2");
            ex3.DDiv();
            var ex4 = new Task("23,5", "0");
            ex4.DDiv();

            var t = new Calc();
            Console.WriteLine(t.Summ(3, 5));
            Console.WriteLine(t.Summ(3.4, 5.3));
            Console.WriteLine(t.Multiply(3, 5));
            Console.WriteLine(t.Multiply(3.7, 5.34));
        }
    }
}
