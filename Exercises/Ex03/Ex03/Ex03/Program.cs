using System;

namespace Ex_03
{
    class Program
    {
        static void Main(string[] args)
        {
            calcCirc();
            calcVol();
            calcTri();
            calcQuad();
        }

        private static void calcCirc()
        {
            int num;
            Console.WriteLine("\nPart 1, circumference and are of a circle.");
            Console.Write("Enter an integer for the readius ");
            string strradius = Console.ReadLine();
            try
            {
                num = int.Parse(strradius);
                if (num <= 0)
                    throw new Exception("Your number must be a positive number");
                double circumference = 2 * Math.PI * num;
                if (double.IsInfinity(circumference))
                    throw new DivideByZeroException();
                Console.WriteLine($"Circumference is {circumference}");
                double area = Math.PI * num * num;
                Console.WriteLine($"The area is {area}");
            }
            catch (FormatException fex)
            {
                Console.WriteLine(fex.Message);
                calcCirc();
            }
            catch (InvalidOperationException ioEx)
            {
                Console.WriteLine(ioEx.Message);
                calcCirc();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                calcCirc();
            }
            finally
            {
                Console.WriteLine("Your numbers are okay");
            }
        }
        private static void calcVol()
        {
            int length;
            Console.WriteLine("\n Part 2, volume of a hemisphere.");
            Console.WriteLine("Enter the length of the hemisphere. ");
            string loh = Console.ReadLine();
            try
            {
                length = int.Parse(loh);
                if (length < 0)
                    throw new Exception("Your number must be a positive number");
                double volume = (4.0 / 3.0) * Math.PI * length * length * length;
                if (double.IsInfinity(length))
                    throw new DivideByZeroException();
                Console.WriteLine($"The Volume is {volume}");
            }
            catch (FormatException fex)
            {
                Console.WriteLine(fex.Message);
                calcVol();
            }
            catch (InvalidOperationException ioEx)
            {
                Console.WriteLine(ioEx.Message);
                calcVol();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                calcVol();
            }
            finally
            {
                Console.WriteLine("Your numbers are okay");
            }
        }
        private static void calcTri()
        {
            int intLineA;
            int intLineB;
            int intLineC;
            Console.WriteLine("Please enter side 1 lenth: ");
            string strLineA = Console.ReadLine();
            Console.WriteLine("Please enter side 2 lenth: ");
            string strLineB = Console.ReadLine();
            Console.WriteLine("Please enter side 3 lenth: ");
            string strLineC = Console.ReadLine();
            try
            {
                intLineA = int.Parse(strLineA);
                intLineB = int.Parse(strLineB);
                intLineC = int.Parse(strLineC);
                if (intLineA < 0)
                    throw new Exception("Your number must be a positive number");
                if (intLineB < 0)
                    throw new Exception("Your number must be a positive number");
                if (intLineC < 0)
                    throw new Exception("Your number must be a positive number");
                int halfCir = (intLineA + intLineB + intLineC) / 2;
                double areaRoot = halfCir * (halfCir - intLineA) * (halfCir - intLineB) * (halfCir - intLineC);
                double areaTriangle = Math.Sqrt(areaRoot);
                Console.WriteLine($"The area is {areaTriangle}");
                if (double.IsInfinity(intLineA))
                    throw new DivideByZeroException();
                Console.WriteLine($"The Volume is {areaTriangle}");
            }
            catch (FormatException fex)
            {
                Console.WriteLine(fex.Message);
                calcTri();
            }
            catch (InvalidOperationException ioEx)
            {
                Console.WriteLine(ioEx.Message);
                calcTri();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                calcTri();
            }
            finally
            {
                Console.WriteLine("Your numbers are okay");
            }
        }
        private static void calcQuad()
        {
            int intA;
            int intB;
            int intC;
            Console.WriteLine("Please enter side 1 lenth: ");
            string strLineA = Console.ReadLine();
            Console.WriteLine("Please enter side 2 lenth: ");
            string strLineB = Console.ReadLine();
            Console.WriteLine("Please enter side 3 lenth: ");
            string strLineC = Console.ReadLine();
            try
            {
                intA = int.Parse(strLineA);
                intB = int.Parse(strLineA);
                intC = int.Parse(strLineA);
                if (intA < 0)
                    throw new Exception("Your number must be a positive number");
                if (intB < 0)
                    throw new Exception("Your number must be a positive number");
                if (intC < 0)
                    throw new Exception("Your number must be a positive number");
                double preRoot = (intB * intB) - (4 * intA * intC);
                double postRoot = Math.Sqrt(preRoot);
                double topNumNeg = -intB - postRoot;
                double topNumPos = -intB + postRoot;
                double posansw = topNumPos / (2 * intA);
                double negansw = topNumNeg / (2 * intA);
                Console.WriteLine($"Answer A is {topNumPos}");
                Console.WriteLine($"Answer B is {topNumNeg}");
                if (double.IsInfinity(intA))
                    throw new DivideByZeroException();
              
            }
            catch (FormatException fex)
            {
                Console.WriteLine(fex.Message);
                calcTri();
            }
            catch (InvalidOperationException ioEx)
            {
                Console.WriteLine(ioEx.Message);
                calcTri();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                calcTri();
            }
            finally
            {
                Console.WriteLine("Your numbers are okay");
            }
        }
    }
}

