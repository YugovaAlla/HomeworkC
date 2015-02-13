using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calcul
{
    
    public interface ICalc
    {
        #region Methods
        double Summ(int a, int b);
        double Summ(double a, double b);
        double Multiply(int a, int b);
        double Multiply(double a, double b);
        #endregion
    }

}
