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
            switch (lowerInput)
            {
                case "yes":
                    Console.WriteLine("Great!");
                    Thread.Sleep(1000);
                    classroom = ClassroomInformation();
                    break;
                case "no":
                    Console.WriteLine("Okay have a nice day! ");
                    break;
                default:
                    Console.WriteLine("not a valid option please try again");
                    CreateClassroom();
                    break;
            }
            Thread.Sleep(2000);
            Console.WriteLine("now we should assign a teacher to your classroom.");
            teacher = CreateTeacher();
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
            Console.WriteLine($"Grade you teach: {classroom[1]}");
            Console.WriteLine($"Amount of students in class: {classroom[2]}");
            return classroom;

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
