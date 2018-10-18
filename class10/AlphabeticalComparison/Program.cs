using System;

namespace AlphabeticalComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, secondName;

            Console.Write("Please enter the first name: ");
            firstName = Console.ReadLine();

            Console.Write("Please enter the second name: ");
            secondName = Console.ReadLine();

            switch (CompareNames(firstName, secondName))
            {
                case 1: Console.WriteLine($"The name {firstName} is first.");
                    break;
                case -1: Console.WriteLine($"The name {secondName} is first.");
                    break;
                case 0: Console.WriteLine($"The names are the same.");
                    break;
                default: Console.WriteLine("Armageddon!");
                    break;
            }


            Console.Write("\nPress the [Enter] key to exit the program.");
            Console.ReadLine();
        }

        static int CompareNames(string firstName, string secondName)
        {
            int result = 0;
            int i = 0;

            while (result == 0 && (i < firstName.Length && i < secondName.Length))
            {
                if((int)firstName[i] > (int)secondName[i])
                {
                    result = -1;
                }
                else if((int)firstName[i] < (int)secondName[i])
                {
                    result = 1;
                }
                i++;
            }

            if(result == 0)
            {
                if (firstName.Length < secondName.Length)
                    result = 1;
                else if (firstName.Length > secondName.Length)
                    result = -1;
            }

            return result;
        }
    }
}
