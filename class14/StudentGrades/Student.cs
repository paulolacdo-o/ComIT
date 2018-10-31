using System;

namespace StudentGrades
{
    class Student
    {
        public string Name { get; private set; }
        public int Grade { get; private set; }

        public Student()
        {
        }

        public Student(string name, int grade)
        {
            Name = name;
            Grade = grade;
        }

        public override string ToString()
        {
            return $"{Name} - {Grade}";
        }
    }
}
