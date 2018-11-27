using System;

namespace ExceptionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = { 90, 95, 97 };
            //int[] grades = new int[0];
            //int[] grades = null;

            float average;
            string output;

            try
            {
                average = GetGradesAverage(grades);
                output = "The average is " + average;
            }
            catch (NullReferenceException ex)
            {
                output = "An exception has occurred: The object that has been passed is null";
            }
            catch (Exception ex)
            {
                output = "An exception has occurred: "+ ex.Message;
            }



            Console.WriteLine(output);

            Console.ReadKey();
        }

        static float GetGradesAverage(int[] grades)
        {
            int total = 0;
            if (grades.Length > 0)
            {
                for (int i = 0; i < grades.Length; i++)
                {
                    total += grades[i];
                }
            }
            else
            {
                throw new Exception("The array that has been passed is empty.");
            }

            float average = (float)total / grades.Length;
            return average;
        }
    }
}
