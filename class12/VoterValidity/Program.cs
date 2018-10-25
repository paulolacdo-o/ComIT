using System;

namespace VoterValidity
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] voter = new Person[3];
            
            for (int i = 0; i < voter.Length; i++)
            {
                voter[i] = ReadVoter(i);
            }

            for (int i = 0; i < voter.Length; i++)
            {

                Console.WriteLine($"Voter #{i + 1} name is " + (voter[i].ValidateName() ? "valid" : "invalid") +
                    " and is " + (voter[i].IsAllowedToVote() ? "of legal age." : "not of legal age."));
            }

            Console.WriteLine();

            for (int i = 0; i < voter.Length; i++)
            {
                Console.WriteLine($"Voter #{i + 1} is " + voter[i].ToString());
            }

            Console.ReadKey();
        }

        static Person ReadVoter(int num)
        {
            Person person;
            string name;
            int age, height, weight;
            switch (num)
            {
                case 0:
                    Console.WriteLine("Please register the first voter: ");
                    person = new Person();
                    Console.Write("Please enter name: ");
                    person.SetName(Console.ReadLine());
                    Console.Write("Please enter age: ");
                    person.SetAge(Convert.ToInt32(Console.ReadLine()));
                    Console.Write("Please enter weight in kgs: ");
                    person.SetWeight(Convert.ToInt32(Console.ReadLine()));
                    Console.Write("Please enter height in cms: ");
                    person.SetHeight(Convert.ToInt32(Console.ReadLine()));
                    break;

                case 1:
                    Console.WriteLine("\nPlease register the second voter: ");
                    Console.Write("Please enter name: ");
                    name = Console.ReadLine();
                    Console.Write("Please enter age: ");
                    age = Convert.ToInt32(Console.ReadLine());
                    person = new Person(name, age);
                    Console.Write("Please enter weight in kgs: ");
                    person.SetWeight(Convert.ToInt32(Console.ReadLine()));
                    Console.Write("Please enter height in cms: ");
                    person.SetHeight(Convert.ToInt32(Console.ReadLine()));
                    break;

                case 2:
                    Console.WriteLine("\nPlease register the third voter: ");
                    Console.Write("Please enter name: ");
                    name = Console.ReadLine();
                    Console.Write("Please enter age: ");
                    age = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Please enter weight: ");
                    weight = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Please enter height: ");
                    height = Convert.ToInt32(Console.ReadLine());
                    person = new Person(name, age, weight, height);
                    break;

                default:
                    person = new Person();
                    break;
            }

            return person;
        }
    }
}
