namespace DivideTwoIntegers.Tests;

[TestClass]
public class UnitTest1
{
    private readonly Class1 _test;

    public UnitTest1()
    {
        _test = new Class1();
    }

    [TestMethod]
    public void TestMethod1()
    {
        int dividend = 10;
        int divisor = 3;
        int result = _test.Divide(dividend, divisor);
        Assert.AreEqual(3, result);
    }

    [TestMethod]
    public void TestMethod2()
    {
        int dividend = 7;
        int divisor = -3;
        int result = _test.Divide(dividend, divisor);
        Assert.AreEqual(-2, result);
    }
}