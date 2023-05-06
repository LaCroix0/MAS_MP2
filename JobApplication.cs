namespace MAS_MP2;

public class JobApplication
{
    private int id;
    private Company _company;
    private bool wasSuccessfull;
    
    public JobApplication(int id, Company company, bool wasSuccessfull)
    {
        this.id = id;
        _company = company;
        this.wasSuccessfull = wasSuccessfull;
    }
}