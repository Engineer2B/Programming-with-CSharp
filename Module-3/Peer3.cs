using System;

namespace Module_3
{
    public static class Peer3
    {
        public static void Main()
        {
            #region VARIABLE DECLARATION

            string sFirstName; //Student First Name
            string sLastName; //Student Last Name
            string sBirthday; //Student Birthday. As the "PrintStudentDetails" function accepted a string, string format was used
            string tFirstName; //Teacher First Name
            string tLastName; //Teacher Last Name
            string tBirthday; //Teacher Birthday
            string cTitle; //Title of the Course
            string cStartDate; //Course Start Date
            string cEndDate; //Course End Date
            string pTitle; //Title of the Program
            string c1Title; //First course in the program
            string c2Title; //Second course in the program
            string degName; //Name of the degree
            string degField; //Field of the degree
            string degDate; //Date for the degree

            #endregion

            //Input Section.
            GetStudentInformation(out sFirstName, out sLastName, out sBirthday);
            GetTeacherInformation(out tFirstName, out tLastName, out tBirthday);
            GetCourseInformation(out cTitle, out cStartDate, out cEndDate);
            GetProgramInformation(out pTitle, out c1Title, out c2Title);
            GetDegreeInformation(out degName, out degField, out degDate);

            //Output Section
            PrintStudentDetails(sFirstName, sLastName, sBirthday);
            PrintTeacherDetails(tFirstName, tLastName, tBirthday);
            PrintCourseInformation(cTitle, cStartDate, cEndDate);
            PrintProgramInformation(pTitle, c1Title, c2Title);
            PrintDegreeInformation(degName, degField, degDate);

            VerifyStudentBirthday(); //This throws the specified exception

            Console.WriteLine("PRESS ENTER TO CONTINUE...");
            Console.ReadLine();
        }
        static void GetStudentInformation(out string sFirstName, out string sLastName, out string sBirthday)
        {
            Console.WriteLine("Enter the student's first name: ");
            sFirstName = Console.ReadLine();

            Console.WriteLine("Enter the student's last name:");
            sLastName = Console.ReadLine();

            Console.WriteLine("Enter the student's birthday (Format MM/DD/YYYY):");
            sBirthday = Console.ReadLine();
        }

        static void GetTeacherInformation(out string tFirstName, out string tLastName, out string tBirthday)
        {
            Console.WriteLine("Enter the teacher's first name: ");
            tFirstName = Console.ReadLine();

            Console.WriteLine("Enter the teacher's last name:");
            tLastName = Console.ReadLine();

            Console.WriteLine("Enter the teacher's birthday (Format MM/DD/YYYY):");
            tBirthday = Console.ReadLine();
        }

        static void GetCourseInformation(out string cTitle, out string cStartDate, out string cEndDate)
        {
            Console.WriteLine("Enter Course Title:");
            cTitle = Console.ReadLine();

            Console.WriteLine("Enter Course Start Date (Format MM/DD/YYYY):");
            cStartDate = Console.ReadLine();

            Console.WriteLine("Enter Course End Date (Format MM/DD/YYYY):");
            cEndDate = Console.ReadLine();
        }

        static void GetProgramInformation(out string pTitle, out string c1Title, out string c2Title)
        {
            Console.WriteLine("Enter Program Title:");
            pTitle = Console.ReadLine();

            Console.WriteLine("Enter Title of First Course:");
            c1Title = Console.ReadLine();

            Console.WriteLine("Enter Title of Second Course:");
            c2Title = Console.ReadLine();
        }

        static void GetDegreeInformation(out string degName, out string degField, out string degDate)
        {
            Console.WriteLine("Enter Degree Name:");
            degName = Console.ReadLine();

            Console.WriteLine("Enter Degree Field:");
            degField = Console.ReadLine();

            Console.WriteLine("Enter Date Degree Achieved: (Format MM/DD/YYYY)");
            degDate = Console.ReadLine();
        }

        static void PrintStudentDetails(string first, string last, string birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);
        }

        static void PrintTeacherDetails(string first, string last, string birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);
        }

        static void PrintCourseInformation(string title, string startDate, string endDate)
        {
            Console.WriteLine("Course {0} begins on {1} and ends on {2}.", title, startDate, endDate);
        }

        static void PrintProgramInformation(string title, string c1Title, string c2Title)
        {
            Console.WriteLine("Program Name: {0}. Contains courses \"{1}\" and \"{2}\"", title, c1Title, c2Title);
        }

        static void PrintDegreeInformation(string name, string field, string date)
        {
            Console.WriteLine("Degree {0} in {1} was recieved on {2}", name, field, date);
        }

        static void VerifyStudentBirthday()
        {
            var ex = new NotImplementedException();
            throw ex;
        }
    }
}