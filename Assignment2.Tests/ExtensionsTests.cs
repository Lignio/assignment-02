

using Xunit;
using FluentAssertions;

namespace Assignment2.Tests;

public class ExtensionsTests
{
    [Fact]
    public void urlUseHTTPS()
    {
        //Assign
        var url = new Uri("https://da.wikipedia.org/wiki/HTTPS");

        //Act
        var check = url.IsSecure();

        //Assert
        check.Should().Be(true);
        
    }


    [Fact]
    public void countWordsOnlyWithLetters()
    {
        //Assign
        var input = "this is a sentence with some amount of unknown words in";

        //Act
        var check = input.WordCount();

        //Assert
        check.Should().Be(11);
        
    }

    [Fact]
    public void countWordsAlsoWithNumbers()
    {
        //Assign
        var input = "this 2 a sentence 5 some amount 57815 of unknown words in ss67a";

        //Act
        var check = input.WordCount();

        //Assert
        check.Should().Be(9);
        
    }
}
