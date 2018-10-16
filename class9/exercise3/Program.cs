using System;

namespace exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 0;
            string[,] phoneNumber = new string[5, 3];
            bool isCorrectIndex = false;

            phoneNumber[0, 0] = "204-000-0001";
            phoneNumber[0, 1] = "204-000-0010";
            phoneNumber[0, 2] = "204-000-0011";

            phoneNumber[1, 0] = "204-000-0100";
            phoneNumber[1, 1] = "204-000-0101";
            phoneNumber[1, 2] = "204-000-0110";

            phoneNumber[2, 0] = "204-000-0111";
            phoneNumber[2, 1] = "204-000-1000";
            phoneNumber[2, 2] = "204-000-1001";

            phoneNumber[3, 0] = "204-000-1010";
            phoneNumber[3, 1] = "204-000-1011";
            phoneNumber[3, 2] = "204-000-1100";

            phoneNumber[4, 0] = "204-000-1101";
            phoneNumber[4, 1] = "204-000-1110";
            phoneNumber[4, 2] = "204-000-1111";

            while(!isCorrectIndex)
            {
                Console.WriteLine("Please enter the index of the contact: ");
                index = ReadIndex();
                if(index < 1 || index > 5)
                {
                    Console.WriteLine("Invalid value.");
                }
                else
                {
                    isCorrectIndex = true;
                }
            }

            for(int i = 0; i <3; i++)
            {
                Console.WriteLine($"Contact {index}, phone number {i + 1}: {phoneNumber[index - 1, i]}");
            }

            Console.ReadLine();
        }

        static int ReadIndex()
        {
            int num;

            while(!(Int32.TryParse(Console.ReadLine(), out num)))
            {
                Console.Write("Invalid value. Try again. ");
            }

            return num;
        }
    }
}
