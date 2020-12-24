using System;

namespace AverageAndDisplayOverloaded
{
    class Program
    {
        static void Main(string[] args)
        {
            AverageAndDisplay("my GPA", 3.5, "your GPA", 4.0);
            Console.WriteLine();

            AverageAndDisplay(3.5, 4.0);

            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }

        public static void AverageAndDisplay(string s1, double d1,
                                             string s2, double d2)
        {
            double average = (d1 + d2) / 2;
            Console.WriteLine("The average of " + s1
                            + " whose value is " + d1);
            Console.WriteLine("and " + s2
                            + " whose value is " + d2
                            + " is " + average);
        }

        public static void AverageAndDisplay(double d1, double d2)
        {
            double average = (d1 + d2) / 2;
            Console.WriteLine("The average of " + d1
                            + " and " + d2
                            + " is " + average);
        }
    }
}
