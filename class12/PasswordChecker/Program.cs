using System;

namespace PasswordChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int length, numOfPasswords;

            Console.Write("Please enter the number of characters to use for each password: ");
            length = GetNumber();
            Console.Write("Please enter the number of passwords to create: ");
            numOfPasswords = GetNumber();
            Console.WriteLine();

            Password[] passwords = new Password[numOfPasswords];

            Console.WriteLine("The passwords that were created are:\n");
            for(int i = 0; i < numOfPasswords; i++)
            {
                passwords[i] = new Password(length);
                Console.Write($"Password {i + 1}: ");
                PrintPasswordInformation(passwords[i]);
            }

            Console.ReadKey();
        }

        static void PrintPasswordInformation(Password password)
        {
            Console.Write($"\"{password.GetValue()}\" - " + (password.IsStrong()?"Strong":"Weak"));
            Console.WriteLine();
        }

        static int GetNumber()
        {
            int number;

            while(!Int32.TryParse(Console.ReadLine(),out number) || number < 1)
            {
                Console.Write("ERROR: Invalid value. Please try again: ");
            }

            return number;
        }
    }
}
