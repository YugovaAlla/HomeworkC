using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Проект
{
    public class Task : INF
    {

        private char oper;
        private int iNum1;
        private int iNum2;
        private double dNum1;
        private double dNum2;
        public Task(string st1, string st2)
        {
            iNum1 = Convert.ToInt32(st1);
            iNum2 = Convert.ToInt32(st2);
            
        }

        public Task(string st1, string st2, char op)
        {

            dNum1 = Convert.ToDouble(st1);
            dNum2 = Convert.ToDouble(st2);
            
            oper = op;

        }

        public void Sub()
        {

            int d = (iNum1 - iNum2);
            Console.WriteLine("{0}-{1}={2}", iNum1, iNum2, d);
        }
         public  void SubD()
        {
            switch (oper)
            {
                case '+':
                    double dd = dNum1 - dNum2;
                    Console.WriteLine("{0}-{1}={2}", dNum1, dNum2, dd);
                    break;
                case '/':

                    if (dNum2 == 0)
                        Console.WriteLine("На ноль делить нельзя");
                    else
                    {
                        double ff = dNum1 / dNum2;
                        Console.WriteLine("{0}/{1}={2}", dNum1, dNum2, ff);
                    }
                    break;

            }

        }

    }
}


    



