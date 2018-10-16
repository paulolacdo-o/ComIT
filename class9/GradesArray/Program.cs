using System;

namespace GradesArray
{
    class Program
    {
        static void Main(string[] args)
        {
        	int[] grades = new int[] {98, 55, 78, 82, 81};
        	int totalGrades = 0;
        	
        	for (int i = 0; i < grades.Length; i++)
        	{
        		totalGrades += grades[i];
        	}

        	float avgGrade = (float)totalGrades / grades.Length;

            Console.WriteLine($"Average grade is {avgGrade}");

            Console.Write("\nPress the [Enter] key to exit the program. ");
            Console.ReadLine();
        }
    }
}
