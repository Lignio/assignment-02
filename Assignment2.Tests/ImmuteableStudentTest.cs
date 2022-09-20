using Xunit;
using FluentAssertions;

namespace Assignment2.Tests;

public class ImmuteableStudentTests
{
    [Fact]
    public void TestCreateStudent()
    {
        //Assign
        var student = new ImmutableStudent("Alan", "Hansen", Status.Active);


        //Act  
        var check = student.ToString(); 

        //Assert
        check.Should().Be("ImmutableStudent { GivenName = Alan, SurName = Hansen, status = Active }");

    }

    [Fact]
    public void compareStudents(){
        //Assign
        var student = new ImmutableStudent("Alan", "Hansen", Status.Active);

        //Act
        var check = new ImmutableStudent("Alan", "Hansen", Status.Active);

        //Assert
        check.Should().BeEquivalentTo(student);
    }

}