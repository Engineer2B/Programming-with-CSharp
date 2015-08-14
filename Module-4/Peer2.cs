namespace Module_4
{
    using System;

    public static class Peer2
    {
        public static void Main()
        {
            Students myStudent = new Students("Joe", "Dirt", "01/01/1933", "6969 Crazy Road", "", "Spankersville", "Ky", "76103", "China");
            Students[] entireClass = new Students[5];

            entireClass[3] = myStudent;

            entireClass[3].DisplayStudentInformation();

            Console.ReadLine();
        }

        public struct Member
        {

            public string FirstName;
            public string LastName;
            public string DOB;
            public string AddrLine1;
            public string AddrLine2;
            public string City;
            public string State;
            public string Zip;
            public string Country;
        }

        public static void DisplayMemberInformation(Member theIndividual)
        {
            Console.WriteLine(" Name : {0} {1}", theIndividual.FirstName, theIndividual.LastName);
            Console.WriteLine(" Date of Birth: {0}", theIndividual.DOB);
            Console.WriteLine(" Address : {0}", theIndividual.AddrLine1);
            Console.WriteLine(" : {0}", theIndividual.AddrLine2);
            Console.WriteLine(" City : {0}", theIndividual.City);
            Console.WriteLine(" State : {0}", theIndividual.State);
            Console.WriteLine(" Zip : {0}", theIndividual.Zip);
            Console.WriteLine(" Country : {0}", theIndividual.Country);
        }

        public struct Students
        {
            private Member studentInfo;

            public Students(string FirstName = "", string LastName = "", string DOB = "", string AddrLine1 = "", string AddrLine2 = "", string City = "", string State = "", string Zip = "", string Country = "")
            {
                studentInfo.FirstName = FirstName;
                studentInfo.LastName = LastName;
                studentInfo.DOB = DOB;
                studentInfo.AddrLine1 = AddrLine1;
                studentInfo.AddrLine2 = AddrLine2;
                studentInfo.City = City;
                studentInfo.State = State;
                studentInfo.Zip = Zip;
                studentInfo.Country = Country;
            }

            public void DisplayStudentInformation()
            {
                Console.WriteLine("Student Information");
                Peer2.DisplayMemberInformation(studentInfo);
            }

        }

        public struct Teachers
        {
            private Member teachersInfo;

            public Teachers(string FirstName = "", string LastName = "", string DOB = "", string AddrLine1 = "", string AddrLine2 = "", string City = "", string State = "", string Zip = "", string Country = "")
            {
                teachersInfo.FirstName = FirstName;
                teachersInfo.LastName = LastName;
                teachersInfo.DOB = DOB;
                teachersInfo.AddrLine1 = AddrLine1;
                teachersInfo.AddrLine2 = AddrLine2;
                teachersInfo.City = City;
                teachersInfo.State = State;
                teachersInfo.Zip = Zip;
                teachersInfo.Country = Country;
            }

            public void DisplayTeachersInformation()
            {
                Console.WriteLine("Teacher Information");
                Peer2.DisplayMemberInformation(teachersInfo);
            }

        }

        private struct SchoolProgram
        {
            private string name;
            private int requiredNumCredits;

            public SchoolProgram(string ProgramName = "", int RequireNumberOfCredits = 0)
            {
                name = ProgramName;
                requiredNumCredits = RequireNumberOfCredits;
            }

            public void DisplayProgramInformation()
            {
                Console.WriteLine("Program: {0} requires {1} credits", name, requiredNumCredits);
            }
        }

        private struct Course
        {
            private string courseName;
            private int credits;
            private int durationInWeeks;
            private string instructor;

            public Course(string courseTitle = "", int totalCredits = 0, int courseDurationInWeeks = 0, string Professor = "")
            {
                courseName = courseTitle;
                credits = totalCredits;
                durationInWeeks = courseDurationInWeeks;
                instructor = Professor;
            }

            public void DisplayCorseInformation()
            {
                Console.WriteLine("Course Information");
                Console.WriteLine(" Title: {0}", courseName);
                Console.WriteLine(" Number of Credits: {0}", credits);
                Console.WriteLine(" Duration : {0} weeks", durationInWeeks);
                Console.WriteLine(" Instructor : {0}", instructor);
            }
        }
    }
}