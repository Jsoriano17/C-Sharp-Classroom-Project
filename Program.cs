using System;
using System.Threading;

namespace ClassroomClassPractice
{

    class Program
    {

        static void CreateClassroom()
        {
            Console.WriteLine("would you like to set up a classroom? (yes/no)");
            string input = Console.ReadLine();
            string lowerInput = input.ToLower();
            switch (lowerInput)
            {
                case "yes":
                    Console.WriteLine("Great!");
                    Thread.Sleep(1000);
                    ClassroomInformation();
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
        static void CreateTeacher()
        {

        }
        static void ClassroomInformation()
        {
            Console.WriteLine("lets get started with your classroom information");
            Thread.Sleep(2000);
            Console.WriteLine("what is your subject?");
            string subject = Console.ReadLine();
            Console.WriteLine("what grade do you teach?");
            string grade = Console.ReadLine();
            Console.WriteLine("how many students are in your class?");
            string studentAmount = Console.ReadLine();
            Console.WriteLine("processing...");
            Thread.Sleep(1000);
            Console.WriteLine("here is your class information");
            Thread.Sleep(1000);
            Console.WriteLine("******* classroom information *******");
            Console.WriteLine($"Subject you're teaching: {subject}");
            Console.WriteLine($"Grade you teach: {grade}");
            Console.WriteLine($"Amount of students in class: {studentAmount}");

        }
        static void Main(string[] args)
        {
            CreateClassroom();
        }
    }
}
