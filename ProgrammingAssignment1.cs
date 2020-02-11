using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Assignment 1 - It's All Greek to Me!
/// Felipe S. Leite - 02/2020
/// </summary>

namespace ProgrammingAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! This program shows the ANGLE and DISTANCE between two points!");

            ///Values for the first point
            Console.Write("\nPlease, type the 1st X value: ");
            float pointX1 = float.Parse(Console.ReadLine());
            Console.Write("Please, type the 1st Y value: ");
            float pointY1 = float.Parse(Console.ReadLine());

            ///Values for the second point
            Console.Write("\nPlease, type the 2nd X value: ");
            float pointX2 = float.Parse(Console.ReadLine());
            Console.Write("Please, type the 2nd Y value: ");
            float pointY2 = float.Parse(Console.ReadLine());

            ///Calculating Delta
            float deltaX = pointX2 - pointX1;
            float deltaY = pointY2 - pointY1;

            ///Calculating Distance
            float distance = (float)Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));

            ///Calculating Angle & Converting to Degrees
            float angle = (float)Math.Atan2(deltaY, deltaX);
            angle = angle * (180/(float)Math.PI);

            ///Printing Messages
            Console.WriteLine("\nThe distance between the two points is: " + distance);
            Console.WriteLine("The angle between the two points is: " + angle + " Degrees");

            Console.WriteLine();
        }
    }
}
