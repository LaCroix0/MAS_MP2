namespace MAS_MP2;

public class Company
{
    public string name;
    public double netWorth;
    
    public List<Employee> _employees = new();
    
    private List<HireHistory> history = new();
    
    private static List<Company> _companies = new();
    public Company(string name, double netWorth)
    {
        this.name = name;
        this.netWorth = netWorth;
        _companies.Add(this);
    }
    
    public static void removeCompany(Company company)
    {
        foreach (Employee employee in company._employees)
        {
            company._employees.Remove(employee);
        }
        _companies.Remove(company);
    }
}