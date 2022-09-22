namespace Assignment2.Tests;

public class DelegatesTests
{
    [Fact]
    public void Test1()
    {

        Func<double, double, double> product = (number1, number2) => number1*number2;
        
        var check = product(5, 3);

        check.Should().Be(15);
       
        Action<string> reverse = str => Console.WriteLine(new string(str.Reverse().ToArray()));


        Func<string, int, bool> isEqual = (str, number) => int.Parse(str) == number;

        var check2 = isEqual("0042", 42);

        check2.Should().Be(true);
    }

}
