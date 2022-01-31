using System;

namespace Console_GPA_check
{
    class Program
    {
        static void Main(string[] args)
        {
            double gpa;
            Console.WriteLine("Enter your gpa:");
            gpa = Convert.ToDouble(Console.ReadLine());
            if (gpa >= 2.0)
            {
                if (gpa >= 3.9)
                {
                    Console.WriteLine("Deans Honour List.");
                }
            }
            else
            {
                Console.WriteLine("The GPA is below the graduation requirement");
                Console.WriteLine("See your academic advisor");
            }
        }
    }
}
