using System;

namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] heightOfStudent = new float[10];
            float avgHeight, totalHeight = 0;
            int aboveAvg = 0, belowAvg = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter the height for student {i + 1}: ");
                heightOfStudent[i] = ReadHeight();
                totalHeight += heightOfStudent[i];
            }

            avgHeight = totalHeight / 10;

            Console.WriteLine($"The average height is: {avgHeight}");

            for (int i = 0; i < 10; i++)
            {
                if (heightOfStudent[i] > avgHeight)
                {
                    aboveAvg++;
                }
                else if (heightOfStudent[i] < avgHeight)
                {
                    belowAvg++;
                }
            }

            Console.WriteLine($"There are {aboveAvg} students above the average height.");
            Console.WriteLine($"There are {belowAvg} students below the average height.");


            WaitForEnterKey();
        }

        static float ReadHeight()
        {
            float num;
            while (!(float.TryParse(Console.ReadLine(), out num)))
            {
                Console.Write("Invalid value. Try again. ");
            }

            return num;
        }

        static void WaitForEnterKey()
        {
            Console.Write("Press [Enter] key to exit program. ");
            Console.ReadLine();
        }
    }
}
