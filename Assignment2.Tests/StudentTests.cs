using Xunit;
using FluentAssertions;

namespace Assignment2.Tests;

public class StudentTests
{
    [Fact]
    public void TestCreateStudent()
    {
        //Assign
        var student = new Student {
            Id=0, 
            GivenName="Ole", 
            SurName = "Olesen",
            StartDate = new DateTime(2022, 9, 1),
            EndDate = new DateTime(2024, 2, 1),
            GraduationDate = new DateTime(2024, 7, 1)
        };


        //Act  
        var check = student.ToString(); 

        //Assert
        check.Should().Be("Name: Ole, Surname: Olesen, Status: Active");

    }

}