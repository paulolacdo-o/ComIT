using System;

namespace exercise17
{
    class Program
    {
        static void Main(string[] args)
        {
        	decimal cad, usd;
        	const decimal EX_RATE = 0.77m;
            Console.WriteLine($"Current CAD to USD exchange rate: 1 CAD = {EX_RATE:C2} USD");
            Console.Write("Enter an amount of CAD to convert: ");
            while(!Decimal.TryParse(Console.ReadLine(),out cad))
            {
            	Console.Write("Invalid value. Try again.");
            }
            usd = cad * EX_RATE;
            Console.WriteLine($"CAD {cad:C2} has been converted to USD {usd:C2}.");

            WaitForEnterKey();
        }

        static void WaitForEnterKey()
        {
        	Console.WriteLine("Press [Enter] key to exit program.");
        	Console.ReadLine();
        }
    }
}
