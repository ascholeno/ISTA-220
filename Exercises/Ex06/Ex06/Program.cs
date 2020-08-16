using System;

namespace Ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            doWork();
        }
        static void doWork()
        {
            Console.WriteLine("This is Ex06");
            Console.WriteLine("Lets build a Unit");
            Admin sara = new Admin();
            sara.Name("Sara");
            sara.Job("admin");
            sara.Tis("2");
            sara.catchPhrase("You need to sign this");
            Console.WriteLine();
            Comm anthony = new Comm();
            anthony.Name("Anthony");
            anthony.Job("Comm");
            anthony.Tis("8");
            anthony.catchPhrase("It must be Solar Flairs");
            Console.WriteLine();
            Infantry adam = new Infantry();
            adam.Name("Adam");
            adam.Job("Infantry");
            adam.Tis("3");
            adam.catchPhrase("My back hurts");
        }
    }
    class Unit
    {
        public virtual void Name(string name)
        {
            Console.Write($"This is {name} ");
        }
        public virtual void Job(string job)
        {
            Console.Write($"and their job is {job}. ");
        }
        public virtual void Tis(string tis)
        {
            Console.Write($"They have been in for {tis} years. ");
        }
        public virtual void catchPhrase(string phrase)
        {
            Console.Write($"Their common phrase is {phrase}");
        }
    }
    class Admin : Unit
    {
        public override void Name(string name)
        {
            Console.WriteLine($"This is {name}");
        }
        public override void Job(string job)
        {
            Console.WriteLine($"and their job is {job}");
        }
        public override void Tis(string tis)
        {
            Console.WriteLine($"They have been in for {tis} years");
        }
        public override void catchPhrase(string phrase)
        {
            Console.WriteLine($"Their common phrase is {phrase}");
        }
    }
    class Comm : Unit
    {
        public override void Name(string name)
        {
            Console.WriteLine($"This is {name}");
        }
        public override void Job(string job)
        {
            Console.WriteLine($"and their job is {job}");
        }
        public override void Tis(string tis)
        {
            Console.WriteLine($"They have been in for {tis} years");
        }
        public override void catchPhrase(string phrase)
        {
            Console.WriteLine($"Their common phrase is {phrase}");
        }
    }
    class Infantry : Unit
    {
        public override void Name(string name)
        {
            Console.WriteLine($"This is {name}");
        }
        public override void Job(string job)
        {
            Console.WriteLine($"and their job is {job}");
        }
        public override void Tis(string tis)
        {
            Console.WriteLine($"They have been in for {tis} years");
        }
        public override void catchPhrase(string phrase)
        {
            Console.WriteLine($"Their common phrase is {phrase}");
        }
    }
}