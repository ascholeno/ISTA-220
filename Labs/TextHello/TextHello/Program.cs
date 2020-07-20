using System;

namespace TextHello
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string name;
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}");
        }
    }
}
