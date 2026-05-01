namespace Ex_03_16;

static class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("値１を入力してください->");
        int num1 = int.Parse(Console.ReadLine());
        System.Console.Write("値2を入力してください->");
        int num2 = int.Parse(Console.ReadLine());

        try
        {
            var calculator = new Calculator(num1, num2);
            int result = calculator.Div();
            System.Console.WriteLine($"{num1} / {num2} = {result}");
        }
        catch
        {
            System.Console.WriteLine("例外:Attempted to divide by zero.");
        }
    }
}
