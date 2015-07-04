using System;

namespace Module_3
{
    public static class Peer2
    {
        public static void Main()
        {
            try
            {
                GetStudentInformation();
            }
            catch (FormatException e)
            {
                Console.WriteLine("You must enter a proper date. Exiting...");
                Environment.Exit(0);
            }
            GetTeacherInformation();
            GetCourseInformation();
            GetUProgramInformation();
            GetDegreeInformation();

            try
            {
                ValdiateBirthday();
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine("Exception Caught");
            }
        }

        static void GetStudentInformation()
        {
            Console.WriteLine("Enter the student's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the student's birthday: ");
            DateTime birthday = DateTime.Parse(Console.ReadLine());

            PrintStudentDetails(firstName, lastName, birthday);
        }

        static void GetTeacherInformation()
        {
            Console.WriteLine("Enter the teacher's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the course the teacher is teaching: ");
            string course = Console.ReadLine();

            PrintTeacherDetails(firstName, lastName, course);
        }

        static void GetCourseInformation()
        {
            Console.WriteLine("Enter the course name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the course ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of credit hours: ");
            float hours = float.Parse(Console.ReadLine());

            PrintCourseDetails(name, id, hours);
        }

        static void GetUProgramInformation()
        {
            Console.WriteLine("Enter the program name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the program id: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the program description: ");
            string description = Console.ReadLine();

            PrintUPorgramDetails(name, id, description);
        }

        static void GetDegreeInformation()
        {
            Console.WriteLine("Enter the degree name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the department name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter the dean's name: ");
            string deanName = Console.ReadLine();

            PrintDegreeDetails(name, deptName, deanName);
        }

        static void PrintStudentDetails(string first, string last, DateTime birthday)
        {
            Console.WriteLine("\n{0} {1} was born on: {2}\n", first, last, birthday.ToString());
        }

        static void PrintTeacherDetails(string first, string last, string course)
        {
            Console.WriteLine("\nTeacher {0} {1} teaches {2}\n", first, last, course);
        }

        static void PrintCourseDetails(string name, int courseID, float hours)
        {
            Console.WriteLine("\nCourse {0} (id: {1}) is {2} credit hours.\n", name, courseID, hours);
        }

        static void PrintUPorgramDetails(string name, int programID, string description)
        {
            Console.WriteLine("\nThe {0} program (id: {1}) is {2}\n", name, programID, description);
        }

        static void PrintDegreeDetails(string name, string department, string dean)
        {
            Console.WriteLine("\nDean {2} is your point of contact for questions regarding a degree in {0} in the school of {1}.\n", name, department, dean);
        }

        static void ValdiateBirthday()
        {
            throw new NotImplementedException("method not implemented");
        }
    }
}