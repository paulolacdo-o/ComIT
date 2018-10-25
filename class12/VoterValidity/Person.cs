using System;
using System.Collections.Generic;
using System.Text;

namespace VoterValidity
{
    class Person
    {
        private string Name;
        private int Age, Id, Weight, Height;

        public Person()
        {
            Name = "";
            Age = Weight = Height = 0;
            GenerateID();
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            GenerateID();
        }

        public Person(string name, int age, int weight, int height)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Height = height;
            GenerateID();
        }

        public bool IsAllowedToVote()
        {
            if (Age < 18)
                return false;

            return true;
        }

        public bool ValidateName()
        {
            for(int i = 0; i < Name.Length; i++)
            {
                if (!Char.IsLetter(Name[i]) && Name[i] != ' ')
                    return false;
            }
            return true;
        }

        override public string ToString()
        {
            return $"{Name}, ID {Id}, age is {Age}, weight is {Weight}, height is {Height} cm.";
        }

        public void GenerateID()
        {
            Id = new Random().Next(10000000, 99999999);
        }

        //mutators
        public void SetName(string name)
        {
            Name = name;
        }
        public void SetAge(int age)
        {
            Age = age;
        }
        public void SetWeight(int weight)
        {
            Weight = weight;
        }
        public void SetHeight(int height)
        {
            Height = height;
        }

        //accessors
        public string GetName()
        {
            return Name;
        }
        public int GetAge()
        {
            return Age;
        }
        public int GetId()
        {
            return Id;
        }
        public int GetWeight()
        {
            return Weight;
        }
        public int GetHeight()
        {
            return Height;
        }
    }
}
