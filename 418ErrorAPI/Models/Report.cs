namespace _418ErrorAPI.Models;

public class Report
{
    //PK
    public string ReportId { get; set; }
    //FK
    public string BusinessId { get; set; }
    //FK
    public string EmployeeId { get; set; }

    public string Data { get; set; }
    public DateTime CreationDate { get; set; }
    public ReportType Type { get; set; }
    public string Name { get; set; }
}
