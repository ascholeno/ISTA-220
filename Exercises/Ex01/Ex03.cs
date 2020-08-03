using System;

namespace Quiz_03
{
    class Program
    {
        static void Main(string[] args)
        {
            calcRecip();
        }

        private static void calcRecip()
        {
            int num;
            Console.Write("To calculate the reciprocal of an integer, enter a positive integer: ");
            string strnum = Console.ReadLine();
            try
            {
                num = int.Parse(strnum);
                if (num < 0)
                    throw new Exception("Your number must be a positive number");
                double recip = (double)1.0 / num;
                if (double.IsInfinity(recip))
                    throw new DivideByZeroException();
                Console.WriteLine($"The reciprocal is {recip}");
            }
            catch (FormatException fex)
            {
                Console.WriteLine(fex.Message);
                calcRecip();
            }
            catch (InvalidOperationException ioEx)
            {
                Console.WriteLine(ioEx.Message);
                calcRecip();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                calcRecip();
            }
        }
    }
}
