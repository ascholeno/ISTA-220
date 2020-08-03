using System;

namespace Parameters
{
    class Pass
    {
        public static void Reference(WrappedInt param)
        {
            Console.WriteLine($"  In Method Reference param is {param}");
            param.Number = 42;
            Console.WriteLine($"  In Method Reference param is now {param}");
        }
        public static void Value(int param)
        {
            Console.WriteLine($"  In Method Value param is {param}");
            param = 42;
            Console.WriteLine($"  In Method Value param is now {param}");
        }
        public static void Value1(ref int param)
        {
            Console.WriteLine($"  In Method Value param is {param}");
            param = 42;
            Console.WriteLine($"  In Method Value param is now {param}");

        }
    }
}
