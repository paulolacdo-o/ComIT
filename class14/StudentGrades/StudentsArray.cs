using System;

namespace StudentGrades
{
    class StudentsArray
    {
        private Student[] _students;
        private int _numOfStudents, _maxStudents;

        public StudentsArray(int maxStudents)
        {
            _students = new Student[maxStudents];
            _maxStudents = maxStudents;
            _numOfStudents = 0;
            Initialize();
        }

        private void Initialize()
        {
            for (int i = 0; i < _students.Length; i++)
                _students[i] = new Student();
        }

        public void InsertAndSort(Student student)
        {
            for (int i = 0; i <= _numOfStudents; i++)
            {
                if(student.Grade >= _students[i].Grade)
                {
                    Student temp = new Student();
                    temp = _students[i];
                    _students[i] = student;
                    student = temp;
                }
            }

            _numOfStudents++;
        }

        public int MaxStudents
        {
            get { return _maxStudents; }
        }

        public void PrintInformation()
        {
            for(int i = 0; i < _students.Length; i++)
            {
                Console.WriteLine(_students[i].ToString());
            }
        }

    }
}
