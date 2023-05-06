using MAS_MP2;

// asocjacja
Company c1 = new Company("Januszex", 100.0);

Employee e1 = Employee.createEmployee(c1, 1, "Piotrek");
Employee e2 = Employee.createEmployee(c1, 2, "Marta");
Employee e3 = Employee.createEmployee(c1, 3, "Zenek");

// asocjacja z atrybutem
HireHistory h1 = new HireHistory(e1, c1, DateOnly.Parse("2001/01/01"));
HireHistory h2 = new HireHistory(e2, c1, DateOnly.Parse("2002/02/02"));
HireHistory h3 = new HireHistory(e3, c1, DateOnly.Parse("2003/03/03"));

// asocjacja kwalifikowana
e1._applications = new()
{
    {1, new JobApplication(1, c1, false)},
    {2, new JobApplication(2, c1, true)},
    {3, new JobApplication(3, c1, false)}
    
};

// kompozycja
Company c2 = new Company("Tomaszex", 200.0);

Employee e4 = Employee.createEmployee(c2, 4, "Jakub");
Employee e5 = Employee.createEmployee(c2, 5, "Damian");
Employee e6 = Employee.createEmployee(c2, 6, "Grzesiek");

Company.removeCompany(c2);