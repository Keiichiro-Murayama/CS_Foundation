using System.Security.Cryptography.X509Certificates;

namespace Ex_03_15;

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
        return x/y;
    }

}