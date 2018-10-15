using System;

namespace exercise15
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 30; i++)
            {
            	int num = i + 1;
            	Console.WriteLine(num*num);
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
