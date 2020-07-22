using System;

namespace ClassroomClassPractice
{
    public class Teacher
    {
        //fields
        public string First
        { get; set; }
        public string Last
        { get; set; }

        public int TeacherId
        { get; set; }

        //properties

        //constructor
        public Teacher (string teacherFirst, string teacherLast, int id)
        {
            First = teacherFirst;
            Last = teacherLast;
            TeacherId = id;
        }

        //methods
    }
}