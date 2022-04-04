using System;
namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap name:");
            // user can input name or not
            string name = Console.ReadLine() ?? "";
            name = name.Trim();
            Console.WriteLine($"Day la name: {name}");
        }
    }
}