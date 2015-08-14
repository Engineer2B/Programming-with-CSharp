using System;

namespace Module_3
{
    public static class MySolution
    {
        public static void Main()
        {
            MySolution.GetStudentInformation();
            MySolution.GetTeacherInformation();
            MySolution.GetCourseInformation();
            MySolution.GetUProgramInformation();
            MySolution.GetDegreeInformation();
            Console.ReadLine();
            MySolution.validateBirthDay("July 4 2005");
        }

        private static void GetStudentInformation()
        {
            Console.WriteLine("Enter the student's first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the student's birth date:");
            string birthDay = Console.ReadLine();
            MySolution.PrintStudentDetails(firstName, lastName, birthDay);
        }

        private static void PrintStudentDetails(string first, string last, string birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);
        }

        private static void GetTeacherInformation()
        {
            Console.WriteLine("Enter the teacher's first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's birth date:");
            string birthDay = Console.ReadLine();
            MySolution.PrintTeacherDetails(firstName, lastName, birthDay);
        }

        private static void PrintTeacherDetails(string first, string last, string birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);
        }

        private static void GetCourseInformation()
        {
            Console.WriteLine("Enter the course's name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the course's unique code:");
            string code = Console.ReadLine();
            Console.WriteLine("Enter your grade for this course:");
            string grade = Console.ReadLine();
            MySolution.PrintCourseDetails(name, code, grade);
        }

        private static void PrintCourseDetails(string name, string code, string grade)
        {
            Console.WriteLine("For course {0}[{1}], your grade was: {2}", name, code, grade);
        }

        private static void GetUProgramInformation()
        {
            Console.WriteLine("Enter the program's name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the program's unique code:");
            string code = Console.ReadLine();
            Console.WriteLine("Enter your grade for this program:");
            string grade = Console.ReadLine();
            MySolution.PrintUProgramDetails(name, code, grade);
        }

        private static void PrintUProgramDetails(string name, string code, string grade)
        {
            Console.WriteLine("For program {0}[{1}], your grade was: {2}", name, code, grade);
        }

        private static void GetDegreeInformation()
        {
            Console.WriteLine("Enter the degree's name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the degree's unique code:");
            string code = Console.ReadLine();
            Console.WriteLine("Enter your grade for this degree:");
            string grade = Console.ReadLine();
            MySolution.PrintDegreeDetails(name, code, grade);
        }

        private static void PrintDegreeDetails(string name, string code, string grade)
        {
            Console.WriteLine("For degree {0}[{1}], your grade was: {2}", name, code, grade);
        }

        private static bool validateBirthDay(string birthDay)
        {
            throw new NotImplementedException("This method is not implemented by design.");
        }
    }
}
