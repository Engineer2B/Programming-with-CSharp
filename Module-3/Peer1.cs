using System;

namespace Module_3
{
    public static class Peer1
    {
        public static void Main()
        {
            //student info
            string fName;
            string lName;
            DateTime birthDate;
            string addressLine1;
            string addressLine2;
            string city;
            string state;
            int zipCode;
            string country;

            //Teacher info
            string tFName, tLName, tAddressLine1, tAddressLine2, tCity, tState, tCountry;
            int tZipCode;
            DateTime tBirthDate;

            //course info
            string courseName, teacherName; //"teacher" later in the couse will be of type Teacher
            int credits, durationInWeeks;

            //UProgram info
            string progName, depHead;
            int degrees;

            //degree info
            string degreeName;
            int creditsRequired;

            GetStudentInformation(out fName, out lName, out birthDate);
            GetTeacherInformation(out tFName, out tLName, out tBirthDate);
            GetCourseInfo(out courseName, out teacherName, out credits, out durationInWeeks);
            GetUProgInfo(out progName, out depHead, out degrees);
            GetDegreeInfo(out degreeName, out creditsRequired);

            PrintStudentDetails(fName, lName, birthDate);
            Console.WriteLine();
            Console.WriteLine();
            PrintTaecherDetails(tFName, tLName, tBirthDate);
            Console.WriteLine();
            Console.WriteLine();
            PrintCourseDetails(courseName, teacherName, credits, durationInWeeks);
            Console.WriteLine();
            Console.WriteLine();
            PrintUProgramDetails(progName, depHead, degrees);
            Console.WriteLine();
            Console.WriteLine();
            PrintDegreeInfo(degreeName, creditsRequired);

            //birthday Validation
            try
            {
                validateStudentBirthday(birthDate);
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine("exception thrown, the excpetion msg is:");
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }

        //Throwing NotImplementedException on purpose
        private static void validateStudentBirthday(DateTime birthDate)
        {
            var ourExcepttion = new NotImplementedException();
            throw ourExcepttion;
        }

        private static void GetDegreeInfo(out string degreeName, out int creditsRequired)
        {
            Console.WriteLine("enter degree name please ");
            degreeName = Console.ReadLine();

            Console.WriteLine("enter credits Required please");
            string strInput = Console.ReadLine();
            while (!Int32.TryParse(strInput, out creditsRequired))
            {
                Console.WriteLine("input an int value please");
                strInput = Console.ReadLine();
            }
        }

        private static void GetUProgInfo(out string progName, out string depHead, out int degrees)
        {
            Console.WriteLine("enter program name please");
            progName = Console.ReadLine();

            Console.WriteLine("enter department head name please");
            depHead = Console.ReadLine();

            Console.WriteLine("enter degrees please");
            string strInput = Console.ReadLine();
            while (!Int32.TryParse(strInput, out degrees))
            {
                Console.WriteLine("input an int value please");
                strInput = Console.ReadLine();
            }
        }

        private static void GetCourseInfo(out string courseName, out string teacherName, out int credits, out int durationInWeeks)
        {
            Console.WriteLine("Input the course name plz");
            courseName = Console.ReadLine();

            Console.WriteLine("Input the teacher's name plz");
            teacherName = Console.ReadLine();

            Console.WriteLine("Input credits no plz");
            string inputStrForCredits = Console.ReadLine();

            while (!Int32.TryParse(inputStrForCredits, out credits))
            {
                Console.WriteLine("input an interger number please");
                inputStrForCredits = Console.ReadLine();
            }

            Console.WriteLine("Input no of weeks plz");
            string inputStrForWeekNo = Console.ReadLine();
            while (!Int32.TryParse(inputStrForWeekNo, out durationInWeeks))
            {
                Console.WriteLine("input an interger number please");
                inputStrForWeekNo = Console.ReadLine();
            }
        }

        private static void GetTeacherInformation(out string tFName, out string tLName, out DateTime tBirthDate)
        {
            Console.WriteLine("Input teacher's first name please");
            tFName = Console.ReadLine();
            Console.WriteLine("Input teacher's last name please");
            tLName = Console.ReadLine();
            Console.WriteLine("Input teacher's date of birth please");
            string enteredDate = Console.ReadLine();

            while (!DateTime.TryParse(s: enteredDate, result: out tBirthDate))
            {
                Console.WriteLine("Please enter a valid date value");
                enteredDate = Console.ReadLine();
            }
        }

        private static void GetStudentInformation(out string fName, out string lName, out DateTime birthDate)
        {
            Console.WriteLine("Input student's first name please");
            fName = Console.ReadLine();
            Console.WriteLine("Input student's last name please");
            lName = Console.ReadLine();
            Console.WriteLine("Input student's date of birth please");
            string enteredDate = Console.ReadLine();

            while (!DateTime.TryParse(s: enteredDate, result: out birthDate))
            {
                Console.WriteLine("Please enter a valid date value");
                enteredDate = Console.ReadLine();
            }

        }

        //Printing Details
        private static void PrintStudentDetails(string fName, string lName, DateTime birthDate)
        {
            Console.WriteLine("Student: {0} {1} born on {2}", fName, lName, birthDate);
        }

        private static void PrintTaecherDetails(string tfName, string tlName, DateTime tbirthDate)
        {
            Console.WriteLine("Teacher: {0} {1} born on {2}", tfName, tlName, tbirthDate);
        }

        private static void PrintDegreeInfo(string degreeName, int creditsRequired)
        {
            Console.WriteLine("Degree name is {0} and number of credits required is {1}", degreeName, creditsRequired);
        }

        private static void PrintUProgramDetails(string progName, string depHead, int degrees)
        {
            Console.WriteLine("UProgram Name is {0}, department head is {1}, and the degrees are: {2}", progName, depHead, degrees);
        }

        private static void PrintCourseDetails(string courseName, string teacherName, int credits, int durationInWeeks)
        {
            Console.WriteLine("Course name is {0} and teacher's name is {1} for {2} credits, for {3} weeks long", courseName, teacherName, credits, durationInWeeks);
        }

    }
}