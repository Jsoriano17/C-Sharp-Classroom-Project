using System;
using System.Security.Cryptography;


namespace ClassroomClassPractice
{
    public class Student
    {
        public string First
        { get; set; }
        public string Last
        { get; set; }
        private string age;
        public string Age
        {
            get { return age; }
            set
            {
                //turn into string
                int intValue = Int32.Parse(value);
                if (intValue < 6 || intValue > 18)
                {
                    throw new ArgumentOutOfRangeException($"{value} is an invalid age");
                }
                else
                {
                    age = value;
                }
            }
        }
        public string grade;
        public string Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public string StudentId
        {
            get; set;
        }

        // public Student(string firstName, string lastName, int studentAge, int studentGrade, int studentId)
        // {
        //     First = firstName;
        //     Last = lastName;
        //     Age = studentAge;
        //     Grade = studentGrade;
        //     StudentId = studentId;
        // }

        public void SayHi()
        {
            Console.WriteLine($"Hi my name is {this.First} {this.Last}");
        }
        static string Get8Digits()
        {
            var bytes = new byte[4];
            var rng = RandomNumberGenerator.Create();
            rng.GetBytes(bytes);
            uint random = BitConverter.ToUInt32(bytes, 0) % 100000000;
            return String.Format("{0:D8}", random);
        }
    }
}