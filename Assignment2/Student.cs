namespace Assignment2;

public class Student {

    public int Id {get; init; }
    public string GivenName {get; set; } = string.Empty;

    public string SurName {get; set;} = string.Empty;

    public enum Status{New, Active, Dropout, Graduated}

    public Status status {get => AssignStatus(StartDate, EndDate, GraduationDate); }

    public DateTime StartDate {get; set;}
    public DateTime EndDate {get; set;}
    public DateTime GraduationDate {get; set;}


    public string toString(){
        throw new NotImplementedException();
    }


    public Status AssignStatus(DateTime Startdate, DateTime Enddate, DateTime GraduationDate){
        if(StartDate == DateTime.Today){
            return Status.New;
        }
        else if(DateTime.Today < EndDate){
            return Status.Active;
        }
        else if (DateTime.Today > EndDate&&DateTime.Today<GraduationDate){
            return Status.Dropout;
        }
        else if (DateTime.Today > GraduationDate){
            return Status.Graduated;
        }
        return Status.Active;
    }



}