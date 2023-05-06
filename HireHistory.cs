namespace MAS_MP2;

public class HireHistory
{
    private Employee _employee;
    private Company _company;
    private DateOnly startDate;
    private DateOnly? endDate;
    public static List<HireHistory> _histories = new();

    public HireHistory(Employee employee, Company company, DateOnly startDate, DateOnly? endDate)
    {
        _employee = employee;
        _company = company;
        this.startDate = startDate;
        this.endDate = endDate;
        _histories.Add(this);
    }

    public HireHistory(Employee employee, Company company, DateOnly startDate)
    {
        _employee = employee;
        _company = company;
        this.startDate = startDate;
        _histories.Add(this);
    }
}