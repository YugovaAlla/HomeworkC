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
            

            Task ex1 = new Task("23", "28");
            ex1.iSub();
            Task ex2 = new Task("23,5", "28,2");
            ex2.dSub();
            Task ex3 = new Task("23,5", "29,2");
             ex3.dDiv();
             Task ex4 = new Task("23,5", "0");
             ex4.dDiv();
       
        }
    }
}
