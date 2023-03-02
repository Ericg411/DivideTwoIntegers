namespace DivideTwoIntegers;
public class Class1
{
    public int Divide(int dividend, int divisor)
    {
        Decimal divideNumber = Decimal.Divide(dividend, divisor);
        if (divideNumber > Int32.MaxValue)
        {
            return Int32.MaxValue;
        }
        if (divideNumber < Int32.MinValue)
        {
            return Int32.MinValue;
        }
        int placeholder = (int)divideNumber;
        return placeholder;
    }
}
