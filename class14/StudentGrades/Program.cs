using System;

namespace StudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_STUDENTS = 10;
            StudentsArray students = new StudentsArray(MAX_STUDENTS);
            
            for (int i = 0; i < students.MaxStudents; i++)
            {
                Console.Write($"Enter the name for student {i + 1}: ");
                string name = Console.ReadLine();

                Console.Write($"Enter the grade for student {i + 1}: ");
                int grade = ReadGrade();

                students.InsertAndSort(new Student(name, grade));

                Console.WriteLine();
            }

            students.PrintInformation();
            Console.ReadKey();
        }

        static int ReadGrade()
        {
            int grade;
            while(!int.TryParse(Console.ReadLine(), out grade) || grade < 0 || grade > 100)
            {
                Console.Write("ERROR: Invalid Value! Please try again: ");
            }
            return grade;
        }
    }
}
