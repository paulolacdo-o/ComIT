using System;

namespace Bicycle
{
    class Program
    {
        static void Main(string[] args)
        {
            Bike[] bikes = new Bike[10];
            InitializeBikeArray(bikes);
            Console.WriteLine("Bike information before acceleration:");
            PrintBikeInformation(bikes);
            Console.WriteLine();
            AccelerateOddBikes(bikes);
            Console.WriteLine("Bike information after acceleration:");
            PrintBikeInformation(bikes);

            Console.ReadKey();
        }

        static void InitializeBikeArray(Bike[] bikes)
        {
            Random rng = new Random();
            for(int i = 0; i < bikes.Length; i++)
            {
                bikes[i] = new Bike(rng.Next(1, 10));
            }
        }

        static void AccelerateOddBikes(Bike[] bikes)
        {
            for (int i = 0; i < bikes.Length; i++)
            {
                if(i%2 == 1)
                {
                    bikes[i].Acccelerate(10);
                }
            }
        }

        static void PrintBikeInformation(Bike[] bikes)
        {
            for (int i = 0; i < bikes.Length; i++)
            {
                Console.WriteLine($"Bike {i} has speed {bikes[i].GetSpeed()}");
            }
        }
    }
}
