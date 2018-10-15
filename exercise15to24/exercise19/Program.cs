using System;

namespace exercise19
{
    class Program
    {
        static void Main(string[] args)
        {
        	decimal salary;
            Console.Write("Please enter your annual salary: ");
            salary = ReadSalary();

            if (salary < 30000)
            {
            	Console.WriteLine("You will receive a 15% increase.");
            	Console.WriteLine("Your new salary is $" + (salary * 1.15m));
            }
            else
            {
            	Console.WriteLine("You will receive a 10% increase.");
            	Console.WriteLine("Your new salary is $" + (salary * 1.10m));
            }


            WaitForEnterKey();
        }

        static decimal ReadSalary()
        {
        	decimal salary;

        	while(!(Decimal.TryParse(Console.ReadLine(), out salary)))
        	{
        		Console.Write("Invalid value. Try again. ");
        	}

        	return salary;
        }

        static void WaitForEnterKey()
        {
        	Console.WriteLine("Press [Enter] key to exit program.");
        	Console.ReadLine();
        }
    }
}
