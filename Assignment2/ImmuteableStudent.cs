namespace Assignment2;



public record ImmutableStudent(string GivenName, string SurName, Status status);

public enum Status{New, Active, Dropout, Graduated}