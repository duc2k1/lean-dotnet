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
        abstract class Animal
        {
            public abstract void Speaking();
        }

    }
}