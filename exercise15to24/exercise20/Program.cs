using System;

namespace exercise20
{
    class Program
    {
        static void Main(string[] args)
        {
        	decimal totalSalary = 0;
        	decimal salary;

        	for (int i = 0; i < 5; i++)
        	{
            Console.Write($"Please enter the annual salary of Worker #{(i+1)}: ");
            salary = ReadSalary();

       		    if (salary < 30000)
        	    {
       		     	totalSalary += salary * 1.15m;
            	}
        	   	else
        	    {
 		           	totalSalary += salary * 1.10m;
            	}
        	}
        	Console.WriteLine("The total of their salaries is $" + totalSalary);

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
