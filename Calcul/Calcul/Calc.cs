namespace TeamInterfaceApplication
{
    public class Calc : ICalc
    {
        #region Methods
        public double Summ(int a, int b)
        {
            return a+b;
        }

        public double Summ(double a, double b)
        {
            return a+b;
        }

        public double Multiply(int a, int b)
        {
            return a*b;
        }

        public double Multiply(double a, double b)
        {
            return a*b;
        }
        #endregion
    }
}
