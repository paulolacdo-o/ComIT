using System;

namespace exercise24
{
    class Program
    {
        static void Main(string[] args)
        {
        	const int ATTEMPTS = 3;
        	const int PIN = 6372;
        	int input, pinAttempt = 0;
        	bool isPinCorrect = false;

        	while((pinAttempt++ < ATTEMPTS) && !isPinCorrect)
        	{
        		Console.Write("Enter 4-digit pin: ");
        		input = ReadNumber();
        		if(input == PIN)
        		{
        			isPinCorrect = true;
        			Console.WriteLine("\nCorrect!");
        			Console.WriteLine("ACCESS GRANTED.");
        		}
        		else
        		{
        			Console.WriteLine("\nWrong password.");
        			Console.WriteLine("ACCESS DENIED.");
        		}
        	}

            WaitForEnterKey();
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
