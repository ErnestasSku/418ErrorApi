namespace _418ErrorAPI.Models;

public class TimeTable
{
    //PK
    public string TimeTableId { get; set; }
    //FK
    public string BusinessId { get; set; }
    //Fk
    public string UserId { get; set; }
    public string Name { get; set; }
    public string Conditions { get; set; }
}
