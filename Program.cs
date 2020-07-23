using System;
using System.Threading;
using System.Security.Cryptography;

namespace ClassroomClassPractice
{

    class Program
    {

        static void CreateClassroom()

        // push into object or array variable to store information and return that information
        {
            Console.WriteLine("would you like to set up a classroom? (yes/no)");
            string input = Console.ReadLine();
            string lowerInput = input.ToLower();
            string[] classroom = new string[4];
            string[] teacher = new string[3];
            Student[] students = new Student[30];
            switch (lowerInput)
            {
                case "yes":
                    Console.WriteLine("Great!");
                    Thread.Sleep(1000);
                    classroom = ClassroomInformation();
                    Thread.Sleep(2000);
                    Console.WriteLine("now we should assign a teacher to your classroom.");
                    teacher = CreateTeacher();
                    Console.WriteLine("Ok now its time to add some students into your class");
                    students = CreateStudents(classroom[3], classroom[2]);
                    Console.WriteLine("Great! now we have your classroom setup!");
                    Console.WriteLine("Lets go through all the classroom information");
                    ClassroomFinal(classroom, teacher, students);
                    break;
                case "no":
                    Console.WriteLine("Okay have a nice day! ");
                    break;
                default:
                    Console.WriteLine("not a valid option please try again");
                    CreateClassroom();
                    break;
            }
        }
        static string[] CreateTeacher()
        {
            string[] teacher = new string[3];
            Console.WriteLine($"what is the teachers first name");
            string first = Console.ReadLine();
            teacher[0] = first;
            Console.WriteLine($"what is the teachers last name");
            string last = Console.ReadLine();
            teacher[1] = last;
            Console.WriteLine($"would you like to input a teacher id or randomize one? (input/random)");
            string id;
            string answer = Console.ReadLine();
            string lowerAnswer = answer.ToLower();
            if (lowerAnswer == "input")
            {
                Console.WriteLine("please input an 8-digit number");
                id = Console.ReadLine();
                teacher[2] = id;
            }
            else if (lowerAnswer == "random")
            {
                id = Get8Digits();
                teacher[2] = id;
            }
            else
            {
                Console.WriteLine("invalid answer please try again");
                CreateTeacher();
            }
            Console.WriteLine("processing...");
            Thread.Sleep(1000);
            Console.WriteLine("here is your teacher information");
            Thread.Sleep(1000);
            Console.WriteLine("******* teacher information *******");
            Console.WriteLine($"Mr.{teacher[1]}");
            Console.WriteLine($"First Name: {teacher[0]}");
            Console.WriteLine($"Last Name: {teacher[1]}");
            Console.WriteLine($"Teacher Id: {teacher[2]}");

            return teacher;
        }
        static Student[] CreateStudents(string numberOfStudents, string classroomGrade)
        {
            int studentNumber = 0;
            Int32.TryParse(numberOfStudents, out studentNumber);
            Student[] students = new Student[studentNumber];
            for (int i = 0; i < studentNumber; i++)
            {
                Student kid = new Student();
                Console.WriteLine("Please put the first name of the student");
                kid.First = Console.ReadLine();
                Console.WriteLine("Please put the last name of the student");
                kid.Last = Console.ReadLine();
                Console.WriteLine("Please put the age of the student");
                kid.Age = Console.ReadLine();
                Console.WriteLine("generating student id...");
                Thread.Sleep(2000);
                kid.Grade = classroomGrade;
                kid.StudentId = Get8Digits();
                Console.WriteLine("******* Student information *******");
                Console.WriteLine($"name: {kid.First} {kid.Last}");
                Console.WriteLine($"student age: {kid.Age}");
                Console.WriteLine($"student grade: {kid.Grade}");
                Console.WriteLine($"student id: {kid.StudentId}");
                Console.WriteLine("**********************************");
                students[i] = kid;
            }
            return students;
        }
        static string[] ClassroomInformation()
        {
            String[] classroom = new string[4];
            Console.WriteLine("lets get started with your classroom information");
            Thread.Sleep(2000);
            Console.WriteLine("what is your subject?");
            string subject = Console.ReadLine();
            classroom[0] = subject;
            Console.WriteLine("what is your classroom number?");
            string number = Console.ReadLine();
            classroom[1] = number;
            Console.WriteLine("what grade do you teach?");
            string grade = Console.ReadLine();
            classroom[2] = grade;
            Console.WriteLine("how many students are in your class?");
            string studentAmount = Console.ReadLine();
            classroom[3] = studentAmount;
            Console.WriteLine("processing...");
            Thread.Sleep(1000);
            Console.WriteLine("here is your class information");
            Thread.Sleep(1000);
            Console.WriteLine("******* classroom information *******");
            Console.WriteLine($"Classroom number: {classroom[1]}");
            Console.WriteLine($"Subject you're teaching: {classroom[0]}");
            Console.WriteLine($"Grade you teach: {classroom[2]}");
            Console.WriteLine($"Amount of students in class: {classroom[3]}");
            return classroom;

        }

        static void ClassroomFinal(string[] classroom, string[] teacher, Student[] students)
        {
            Thread.Sleep(1000);
            Console.WriteLine("******* classroom information *******");
            Console.WriteLine($"Classroom number: {classroom[1]}");
            Console.WriteLine($"Subject you're teaching: {classroom[0]}");
            Console.WriteLine($"Grade you teach: {classroom[2]}");
            Console.WriteLine($"Amount of students in class: {classroom[3]}");
            Thread.Sleep(1000);
            Console.WriteLine("******* teacher information *******");
            Console.WriteLine($"Mr.{teacher[1]}");
            Console.WriteLine($"First Name: {teacher[0]}");
            Console.WriteLine($"Last Name: {teacher[1]}");
            Console.WriteLine($"Teacher Id: {teacher[2]}");
            Thread.Sleep(1000);
            Console.WriteLine("******* list of students *******");
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("**********************************");
                Console.WriteLine($"name: {students[i].First} {students[i].Last}");
                Console.WriteLine($"student age: {students[i].Age}");
                Console.WriteLine($"student grade: {students[i].Grade}");
                Console.WriteLine($"student id: {students[i].StudentId}");
                Console.WriteLine("**********************************");
            }

        }
        static string Get8Digits()
        {
            var bytes = new byte[4];
            var rng = RandomNumberGenerator.Create();
            rng.GetBytes(bytes);
            uint random = BitConverter.ToUInt32(bytes, 0) % 100000000;
            return String.Format("{0:D8}", random);
        }
        static void Main(string[] args)
        {
            CreateClassroom();
        }
    }
}
