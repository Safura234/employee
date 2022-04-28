using System;

namespace Employee_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Manager manager = new Manager();
            manager.name = "Sebastien";
            Console.WriteLine(manager.HireEmployee());
        }
    }
}
