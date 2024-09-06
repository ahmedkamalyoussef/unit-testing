namespace UnitTesting
{
    public class Calculator
    {
        public int AddInt(int a, int b)
        {
            return a + b;
        }
        public int SubInt(int a, int b)
        {
            return a - b;
        }
        public int DivInt(int a, int b)
        {
            return a / b;
        }
        public double DivDouble(double a, double b)
        {
            if (b == 0) throw new DivideByZeroException();
            return a / b;
        }
    }
}
