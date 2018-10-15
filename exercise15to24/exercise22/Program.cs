using System;

namespace exercise22
{
    class Program
    {
    	const string MY_NAME = "Paulo";
    	
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("My name is:");
            CallForPrintName();

            WaitForEnterKey();
        }

        static void CallForPrintName()
        {
        	PrintName();
        }

        static void PrintName()
        {
        	Console.Write(MY_NAME);
        }

        static void WaitForEnterKey()
        {
        	Console.WriteLine("Press [Enter] key to exit program.");
        	Console.ReadLine();
        }
    }
}
