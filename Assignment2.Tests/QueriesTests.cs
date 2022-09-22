namespace Assignment2.Tests;

public class QueriesTests
{
    [Fact]
    public void Test_Wizards_By_Rowling()
    {
        var exp = new string[] {"Albus Dumbledore", "Severus Snape", "Harry James Potter",
        "Hermione Jean Granger", "Ronald Bilius Weasley", "Sirius Black", "Minerva McGonagall"};
        var res = new Queries().Wizards_By_Rowling();
        var val = res.Intersect(exp);
        val.Count().Should().Be(exp.Count());
    }
    [Fact]
    public void Test_Wizards_By_Rowling_Linq()
    {
        var exp = new string[] {"Albus Dumbledore", "Severus Snape", "Harry James Potter",
        "Hermione Jean Granger", "Ronald Bilius Weasley", "Sirius Black", "Minerva McGonagall"};
        var res = new Queries().Wizards_By_Rowling_Linq();
        var val = res.Intersect(exp);
        val.Count().Should().Be(exp.Count());
    }

    [Fact]
    public void Test_The_First_Sith()
    {
        var res = new Queries().The_First_Sith();
        res.Should().Be(1977);
    }
    [Fact]
    public void Test_The_First_Sith_Linq()
    {
        var res = new Queries().The_First_Sith_Linq();
        res.Should().Be(1977);
    }

    [Fact]
    public void Test_Unique_HP_Wizards()
    {
        var exp = new (string Name, int? Year)[] {("Albus Dumbledore", 1998), ("Severus Snape", 1998), ("Harry James Potter", 1998),
        ("Hermione Jean Granger", 1998), ("Ronald Bilius Weasley", 1998), ("Sirius Black", 1998), ("Minerva McGonagall", 1998)};
        var res = new Queries().Unique_HP_Wizards();
        var val = res.Intersect(exp);
        val.Count().Should().Be(exp.Count());
    }
    [Fact]
    public void Test_Unique_HP_Wizards_Linq()
    {
        var exp = new (string Name, int? Year)[] {("Albus Dumbledore", 1998), ("Severus Snape", 1998), ("Harry James Potter", 1998),
        ("Hermione Jean Granger", 1998), ("Ronald Bilius Weasley", 1998), ("Sirius Black", 1998), ("Minerva McGonagall", 1998)};
        var res = new Queries().Unique_HP_Wizards_Linq();
        var val = res.Intersect(exp);
        val.Count().Should().Be(exp.Count());
    }

    [Fact]
    public void Test_Wizards_And_Creators()
    {
        var exp = new (string Creator, string Name)[] {
            ("J.R.R. Tolkien", "Sauron"),
            ("J.R.R. Tolkien", "Radagast"),
            ("J.R.R. Tolkien", "Gandalf"),
            ("J.K. Rowling", "Sirius Black"),
            ("J.K. Rowling", "Severus Snape"),
            ("J.K. Rowling", "Ronald Bilius Weasley"),
            ("J.K. Rowling", "Minerva McGonagall"),
            ("J.K. Rowling", "Hermione Jean Granger"),
            ("J.K. Rowling", "Harry James Potter"),
            ("J.K. Rowling", "Albus Dumbledore"),
            ("George Lucas", "Darth Vader"),
            ("George Lucas", "Darth Maul")
        };
        var res = new Queries().Wizards_And_Creators();
        int i = 0;
        foreach (var w in res)
        {
            w.Should().Be(exp[i]);
            i++;
        }
    }
    [Fact]
    public void Wizards_And_Creators_Linq()
    {
        var exp = new (string Creator, string Name)[] {
            ("J.R.R. Tolkien", "Sauron"),
            ("J.R.R. Tolkien", "Radagast"),
            ("J.R.R. Tolkien", "Gandalf"),
            ("J.K. Rowling", "Sirius Black"),
            ("J.K. Rowling", "Severus Snape"),
            ("J.K. Rowling", "Ronald Bilius Weasley"),
            ("J.K. Rowling", "Minerva McGonagall"),
            ("J.K. Rowling", "Hermione Jean Granger"),
            ("J.K. Rowling", "Harry James Potter"),
            ("J.K. Rowling", "Albus Dumbledore"),
            ("George Lucas", "Darth Vader"),
            ("George Lucas", "Darth Maul")
        };
        var res = new Queries().Wizards_And_Creators_Linq();
        int i = 0;
        foreach (var w in res)
        {
            w.Should().Be(exp[i]);
            i++;
        }
    }

}
