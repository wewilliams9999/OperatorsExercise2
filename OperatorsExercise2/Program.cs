using System;

namespace OperatorsExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the radius of your circle?");

            var radius = double.Parse(Console.ReadLine());

            var result = AreaOfCircle(radius);

            Console.WriteLine($"The area of a circle with radius of {radius} is {result}");
        }

        public static double AreaOfCircle(double radius)
        {
            var area = Math.PI * radius *radius;
            return area;
        
        }
    }

}
