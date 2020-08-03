using System;

namespace Classes
{
    class Point
    {
        //This creates instance fields x and y
        int x;
        int y;
        //Class fields will eventually go here
        private static int numOfPoints = 0;
        public Point()
        {
            x = -1;
            y = -1;
            numOfPoints++;
            Point peter = new Point(63, 180);
            Console.WriteLine("Default constructor called");
            Console.WriteLine($"Defaullt x is {x} Default y is {y}");
        }
        public Point(int xVar, int yVar)
        {
            x = xVar;
            y = yVar;
            numOfPoints++;
            Console.WriteLine($"x:{x}, y:{y}");
        }
        public double DistanceTo(Point other)
        {
            int xDiff = x - other.x;
            int yDiff = y - other.y;
            double distance = Math.Sqrt((xDiff * xDiff) + (yDiff * yDiff));
            return distance;
        }
        public static int ObjectCount()
        {
            return numOfPoints;
        }
    }
}