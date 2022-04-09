namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.Info();
        }
        class Cat : Animal
        {
            public Cat()
            {
                Weight = 100;
                Height = 2;
            }
        }
        class Animal
        {
            protected double Weight;
            protected double Height;
            protected static int Leg;
            public void Info()
            {
                System.Console.WriteLine($"Weight {Weight}");
                System.Console.WriteLine($"Heigth {Height}");
            }
        }

    }
}