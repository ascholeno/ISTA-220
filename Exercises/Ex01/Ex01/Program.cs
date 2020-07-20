using System;
using System.Xml.Serialization;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("\nPart 1, circumference and are of a circle.");
            Console.Write("Enter an integer for the readius ");
            string strradius = Console.ReadLine();
            int intradius = int.Parse(strradius);
            double circumference = 2 * Math.PI * intradius;
            Console.WriteLine($"The circumference is {circumference}");
            double area = Math.PI * intradius * intradius; 
            Console.WriteLine($"The area is {area}");

            Console.WriteLine("\nPart 2, volume of a hemisphere.");
            Console.WriteLine("Enter the length of the hemisphere. ");
            string loh = Console.ReadLine();
            int length = int.Parse(loh);
            double volume = (4.0 / 3.0) * Math.PI * length * length * length;
            Console.WriteLine($"The volume is {volume}");

            Console.WriteLine("\nPart 3, area of a triangle (Heron's formula).");
            Console.WriteLine("Please enter side 1 lenth: ");
            string strLineA = Console.ReadLine();
            Console.WriteLine("Please enter side 2 lenth: ");
            string strLineB = Console.ReadLine();
            Console.WriteLine("Please enter side 3 lenth: ");
            string strLineC = Console.ReadLine();
            int intLineA = int.Parse(strLineA);
            int intLineB = int.Parse(strLineB);
            int intLineC = int.Parse(strLineC);
            string side3 = Console.ReadLine();
            int halfCir = (intLineA + intLineB + intLineC) / 2;
            double areaRoot = halfCir * (halfCir - intLineA) * (halfCir - intLineB) * (halfCir - intLineC);
            double areaTriangle = Math.Sqrt(areaRoot);
            Console.WriteLine($"The area is {areaTriangle}");
           
            Console.WriteLine("\nPart 4, solving a quadratic equation.");
            Console.WriteLine("Please enter A: ");
            string stra = Console.ReadLine();
            Console.WriteLine("Please enter B: ");
            string strb = Console.ReadLine();
            Console.WriteLine("Please enter C: ");
            string strc = Console.ReadLine();
            int inta = int.Parse(stra);
            int intb = int.Parse(strb);
            int intc = int.Parse(strc);
            double preRoot = (intb * intb) - (4 * inta * intc);
            double postRoot = Math.Sqrt(preRoot);
            double topNumNeg = -intb - postRoot;
            double topNumPos = -intb + postRoot;
            double posansw = topNumPos / (2 * inta);
            double negansw = topNumNeg / (2 * inta);
            Console.WriteLine($"Answer A is {topNumPos}");
            Console.WriteLine($"Answer B is {topNumNeg}");
        }
    }
}
