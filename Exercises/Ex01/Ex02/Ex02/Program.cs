using System;

namespace ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPart 1 , sum 10 numbers.");
            int sum = SumTenInts(0, 0);
            char letterGrade = 'X';
            Console.WriteLine ($"The sum of ten integers is {sum}");

            Console.WriteLine ("\nPart 2 , average 10 numbers.");
            double avg = AvgTenInts(0, 0);
            letterGrade = ConvertNumericToLetterGrade(avg);
            Console.WriteLine ($"The average of ten integers is {avg} and the letter grade is {letterGrade}");

            Console.WriteLine ("\nPart 3, average user predetermined number of scores.");
            Console.Write("How many scores do you wishs to enter?");
            string noScores = Console.ReadLine();
            int numScores = int.Parse(noScores);
            double avg1 = AvgUnkInts(0, 0, numScores);
            letterGrade = ConvertNumericToLetterGrade(avg1);
            Console.WriteLine($"The average of {numScores} integers is {avg1} and the letter grade is {letterGrade}");

            Console.WriteLine("\nPart 4 , average non−predetermined number of scores. Type stop when finished.");
            double avg2 = AvgAnyInts(0, 0);
            letterGrade = ConvertNumericToLetterGrade(avg2);
            Console.WriteLine($"The average of ten integers is {avg2} and the letter grade is {letterGrade}");
        }

        private static char ConvertNumericToLetterGrade(double grade)
        {
            char letterGrade = 'X';
            if (grade >= 90)
                letterGrade = 'A';
            else if (grade < 90 && grade >= 80)
                letterGrade = 'B';
            else if (grade < 80 && grade >= 70)
                letterGrade = 'C';
            else if (grade < 70 && grade >= 60)
                letterGrade = 'D';
            else if (grade < 60)
                letterGrade = 'F';
            return letterGrade;
        }
        private static double AvgAnyInts(int sum, int count)
        {

            Console.Write("Enter a score:");
            string input = Console.ReadLine();
            input = input.ToLower();
            if (input == "stop")
                return sum / count;
            else
                sum += int.Parse(input);
                count++;
            return AvgAnyInts(sum, count);
        }

            private static double AvgUnkInts(int sum, int count, int numScores)
        {
            Console.Write("Enter a score:");
            string input = Console.ReadLine();
            sum += int.Parse(input);
            count++;
            if (count < numScores)
                return AvgUnkInts(sum, count, numScores);
            else
                return sum / numScores;
     } 
            private static double AvgTenInts(int sum, int count)
        {
            Console.Write("Enter a score:");
            string input = Console.ReadLine();
            sum += int.Parse(input);
            count++;
            if (count < 10)
                return AvgTenInts(sum, count);
            else
                return sum / 10;
        }

        private static int SumTenInts(int sum, int count)
        {
            Console.Write("Enter a score:");
            string input = Console.ReadLine();
            sum += int.Parse(input);
            count++;
            if (count < 10)
                return SumTenInts(sum, count);
            else
                return sum;
        }
    }
}
