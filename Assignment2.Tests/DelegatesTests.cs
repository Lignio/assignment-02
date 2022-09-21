namespace Assignment2.Tests;

public class DelegatesTests
{
    [Fact]
    public void Test1()
    {

        Func<double, double, double> product = (number1, number2) => number1*number2;
        
        var check = product(5, 3);

        check.Should().Be(15);
       
        Func<string, string> reverse = str => new string(str.Reverse().ToArray());

        var check1 = reverse("a string");

        check1.Should().Be("gnirts a");


        Func<string, int, bool> isEqual = (str, number) => int.Parse(str) == number;

        var check2 = isEqual("0042", 42);

        check2.Should().Be(true);
    }

}
