namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog();
            dog.Speaking();

        }
        class Dog : Animal
        {
            public override void Speaking()
            {
                System.Console.WriteLine("Dog speaking");
            }
        }
        class Animal
        {
            public virtual void Speaking()
            {
                System.Console.WriteLine("Animal speaking");
            }
        }

    }
}