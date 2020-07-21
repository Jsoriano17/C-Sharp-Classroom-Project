using System;


namespace ClassroomClassPractice
{
    public class Student
    {
        public string First
        { get; set; }
        public string Last
        { get; set; }
        public int age;
        public int Age
        {
            get { return age; }
            set
            {
                if ( value < 6 || value > 18) {
                     throw new ArgumentOutOfRangeException($"{value} is an invalid age");
                } else {
                    age = value;
                }
            }

        }
        public int grade;
        public int Grade
        {
            get { return grade; }
            set { grade = value; }
        }
        public int StudentId;
        public Student(string firstName, string lastName, int studentAge, int studentGrade, int studentId)
        {
            First = firstName;
            Last = lastName;
            Age = studentAge;
            Grade = studentGrade;
            StudentId = studentId;
        }

        public void SayHi() {
            Console.WriteLine($"Hi my name is {this.First}");
        }
    }
}