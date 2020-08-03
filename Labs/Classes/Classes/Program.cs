using System;

namespace Classes
{
    class Program
    {
        static void doWork()
        {
            Console.WriteLine("Running Class program...");
            Point origin = new Point(); //intantiates point object origin
            Point bottomRight = new Point(1366, 768); //instantiate point object bottom right
            double distance = origin.DistanceTo(bottomRight);
            Console.WriteLine($"Distance is: {distance}");
            Console.WriteLine($"Number of Point objects: {Point.ObjectCount()}");
        }

        static void Main(string[] args)
        {
            //try
            //{
                doWork();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
        }
    }
}
