using System;

namespace Parameters
{
    class WrappedInt
    {
        public int Number;
        public static void Reference(WrappedInt param)
        {
            Console.WriteLine($"  In Method Reference param is {param}");
            param.Number = 42;
            Console.WriteLine($"  In Method Reference param is now {param}");
        }
    }
}
