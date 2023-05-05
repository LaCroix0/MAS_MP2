namespace MAS_MP2;

public class Sala
{
    private double powierzchnia;
    private int numerSali;
    
    private Sala(double powierzchnia, int numerSali)
    {
        this.powierzchnia = powierzchnia;
        this.numerSali = numerSali;
    }

    public static void createSale(Budynek budynek, double powierzchnia, int numerSali)
    {
        var sala = new Sala(powierzchnia, numerSali);
        if (!budynek.sale.Any(sala => sala.numerSali.Equals(numerSali)))
        {
            budynek.sale.Add(new Sala(powierzchnia, numerSali));
        }
    }
}