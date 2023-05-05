using System.Runtime.InteropServices.JavaScript;

namespace MAS_MP2;

public class UmowaNajmu
{
    private Deweloper deweloper { get; set; }
    private Najemca najemca { get; set; }
    private DateOnly _poczatekNajmu { get; set; }
    private DateOnly _koniecNajmu { get; set; }
}