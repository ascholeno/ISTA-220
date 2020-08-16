using System;

namespace Vehicles
{
    class Boat : Vehicle
    {
        public void Sail()
        {
            Console.WriteLine("Sailing");
        }
        public void Floats()
        {
            Console.WriteLine("Floating");
        }
        public override void Drive()
        {
            Console.WriteLine("Boating");
        }
    }
}
