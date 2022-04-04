using System;
namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string sayHello = "Hello Hello World!";
            sayHello = sayHello.Replace("Hello", "Dude");
            Console.WriteLine(sayHello);
        }
    }
}