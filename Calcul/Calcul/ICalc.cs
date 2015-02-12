namespace TeamInterfaceApplication
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
