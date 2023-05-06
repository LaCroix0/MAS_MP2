namespace MAS_MP2;

public class Employee
{
    private int id { get; set; }
    public string name { get; set; }
    private List<HireHistory> history = new();
    private static List<Employee> _employees = new();
    public Dictionary<int, JobApplication> _applications = new();

    public static Employee createEmployee(Company company, int id, string name)
    {
        Employee employee = new Employee(id, name);
        if (_employees.Contains(employee))
        {
            throw new Exception("This employee already exists in this extent.");
        }
        company._employees.Add(employee);
        _employees.Add(employee);
        return employee;
    }

    private Employee(int id, string name)
    {
        this.id = id;
        this.name = name;
    }
}