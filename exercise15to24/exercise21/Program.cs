using System;

namespace exercise21
{
    class Program
    {
        static void Main(string[] args)
        {
        	int numberOfEmployees, highestSalaryEmployee = 0;
        	decimal salary, highestSalary = 0;

            Console.Write("Please enter the number of employees: ");
            numberOfEmployees = ReadNumber();

            for(int i = 0; i < numberOfEmployees; i++)
            {
            	Console.Write($"Please enter the annual salary of employee #{i+1}: ");
            	salary = ReadSalary();
            	if (salary > highestSalary)
            	{
            		highestSalary = salary;
            		highestSalaryEmployee = i + 1;
            	}            	
            }

            Console.WriteLine($"Employee #{highestSalaryEmployee} has the highest salary of ${highestSalary}.");

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
