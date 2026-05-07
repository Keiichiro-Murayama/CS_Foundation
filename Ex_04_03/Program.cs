namespace Ex_04_03;
using System.Collections.Generic;
using Ex_04_03.Modules;

static class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();
        while (true)
        {
            Console.WriteLine("社員番号を入力してください->");
            string id = Console.ReadLine();
            if (id == "End")
            {
                break;
            }
            Console.WriteLine("社員名を入力してください->");
            string name = Console.ReadLine();
            Console.WriteLine("住所を入力してください->");
            string address = Console.ReadLine();
            
            Employee employee = new(int.Parse(id), name, address);

            employees.Add(employee);
        }
        foreach (var employee in employees)
        {
            System.Console.WriteLine(employee.ToString());
        }



    }
}
