using System;

namespace AverageGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] studentGrades = new int[5, 3];
            float classTotal = 0;
            float[] studentAverage = new float[5];
            float classAverage;

            for(int i = 0; i < studentGrades.GetLength(0); i++)
            {
                int studentTotal = 0;
                for(int j = 0; j < studentGrades.GetLength(1); j++)
                {
                    Console.Write($"Enter the grade of Student #{i + 1} for Quiz #{j + 1}: ");
                    studentTotal += studentGrades[i,j] = Convert.ToInt32(Console.ReadLine());
                }

                classTotal += studentAverage[i] = (float)studentTotal / studentGrades.GetLength(1);
                Console.WriteLine($"The average of Student #{i+1} is {studentAverage[i]}.\n");
            }

            classAverage = classTotal / studentGrades.GetLength(0);
            Console.WriteLine($"The average of the class is {classAverage}.\n");

            Console.WriteLine("Press [Enter] key to exit program.");
            Console.ReadLine();
        }
    }
}
