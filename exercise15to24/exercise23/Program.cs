using System;

namespace exercise23
{
    class Program
    {
        static void Main(string[] args)
        {
        	int num1, num2, sum;
            Console.Write("Enter a number: ");
            num1 = ReadNumber();
            Console.Write("Enter another number: ");
            num2 = ReadNumber();

            sum = Add(num1, num2);

            Console.WriteLine($"The sum of {num1} and {num2} is {sum}.");

            WaitForEnterKey();
        }

        static int Add(int num1, int num2)
        {
        	int sum = num1 + num2;

        	return sum;
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

        static void WaitForEnterKey()
        {
        	Console.WriteLine("Press [Enter] key to exit program.");
        	Console.ReadLine();
        }
    }
}
