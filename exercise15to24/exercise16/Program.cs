using System;

namespace exercise16
{
    class Program
    {
        static void Main(string[] args)
        {
        	int numToStart;
            Console.Write("Please enter an integer: ");
            numToStart = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < 100; i++)
            {
            	Console.WriteLine(numToStart + i + 1);
            }

            WaitForEnterKey();
        }

        static void WaitForEnterKey()
        {
        	Console.WriteLine("Press [Enter] key to exit program.");
        	Console.ReadLine();
        }
    }
}
