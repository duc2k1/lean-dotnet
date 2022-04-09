namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HELLO");
        }
        class Animanl
        {
            protected double Weight;
            protected double Height;
            protected static int Leg;
            public void Info()
            {
                System.Console.WriteLine($"Weight {Weight}");
            }
        }
    }
}