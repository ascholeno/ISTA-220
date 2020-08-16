using System;

namespace Vehicles
{
    class Program
    {
        static void doWork()
        {
            Console.WriteLine("This is lab Vehicles");
            Console.WriteLine("Journey by airplane:");
            Airplane myPlane = new Airplane();
            myPlane.StartEngine("Contact");
            myPlane.TakeOff();
            myPlane.Drive();
            myPlane.Land();
            myPlane.StopEngine("Whirr");
            Console.WriteLine();
            Console.WriteLine("Journey by car:");
            Car myCar = new Car();
            myCar.StartEngine("Brm brm");
            myCar.Accelerate();
            myCar.Drive();
            myCar.Brake();
            myCar.StopEngine("Phut phut");
            Console.WriteLine("Journey by Motorcycle");
            Console.WriteLine();
            Motorcycle myMotorcycle = new Motorcycle();
            myMotorcycle.StartEngine("Motorcycle noises");
            myMotorcycle.Accelerate();
            myMotorcycle.Drive();
            myMotorcycle.Brake();
            myMotorcycle.StopEngine("No Motorcycle noises");
            Console.WriteLine();
            Console.WriteLine("Journey by Boat");
            Boat Titanic = new Boat();
            Titanic.StartEngine("Glug Glug");
            Titanic.Sail();
            Titanic.Drive();
            Titanic.Floats();
            Titanic.StopEngine("Sinking Noises");

            Console.WriteLine("\nTesting polymorphism");
            Vehicle v = myCar;
            v.Drive();
            v = myPlane;
            v.Drive();
            v = myMotorcycle;
            v.Drive();
        }
        static void Main()
        {
                doWork();
        }
    }
}
