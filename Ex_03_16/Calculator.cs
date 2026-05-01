using System.Security.Cryptography.X509Certificates;

namespace Ex_03_16;

public class Calculator
{
    public int x;
    public int y;

    public Calculator(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public int Div()
    {
        try
        {
            return x/y;        
        }
        catch (System.Exception)
        {
            throw;
        }
    }

}