using System;

namespace exercise18
{
    class Program
    {
        static void Main(string[] args)
        {
        	int num1, num2;
            Console.Write("Please enter a number: ");
            num1 = ReadNumber();

            Console.Write("Please enter a second number: ");
            num2 = ReadNumber();

            if(num1 > num2)
            {
            	Console.WriteLine($"{num1} is greater than {num2}");
            }
            else if (num2 > num1)
            {
            	Console.WriteLine($"{num2} is greater than {num1}");
            }
            else
            {
            	Console.WriteLine("They are equal.");
            }

            WaitForEnterKey();
        }

        static void WaitForEnterKey()
        {
        	Console.WriteLine("Press [Enter] key to exit program.");
        	Console.ReadLine();
        }

        static int ReadNumber()
        {
        	int num;
        	while(!Int32.TryParse(Console.ReadLine(), out num))
        	{
        		Console.Write("Invalid value. Try again. ");
        	}

        	return num;
        }
    }
}
