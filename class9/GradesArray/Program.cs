using System;

namespace GradesArray
{
    class Program
    {
        static void Main(string[] args)
        {
        	int[] grades = new int[] {98, 55, 78, 82, 81};
        	int totalGrades = grades[0] + grades[1] + grades[2] + grades[3] + grades[4];
        	float avgGrade = (float)totalGrades / 5;

            Console.WriteLine($"Total grade is {totalGrades}");
            Console.WriteLine($"Average grade is {avgGrade}");

            Console.Write("\nPress the [Enter] key to exit the program. ");
            Console.ReadLine();
        }
    }
}
