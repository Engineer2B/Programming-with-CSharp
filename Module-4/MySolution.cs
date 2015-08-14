namespace Module_4
{
    using System;

    public static class MySolution
    {
        public static void Main()
        {
            var students = new Student[5];
            students[0].BirthDay = "January 3";
            students[0].FirstName = "Oerry";
            students[0].LastName = "G' Brien";
            Console.WriteLine("First name: {0}", students[0].FirstName);
            Console.WriteLine("Last name: {0}", students[0].LastName);
            Console.WriteLine("Birth day: {0}", students[0].BirthDay);
            Console.ReadLine();
        }
    }

    public struct Student
    {
        public string FirstName;

        public string LastName;

        public string BirthDay;
    }

    public struct Teacher
    {
        public string FirstName;

        public string LastName;

        public string BirthDay;
    }

    public struct SchoolProgram
    {
        public string Name;

        public string Code;

        public string Grade;
    }

    public struct Course
    {
        public string Name;

        public string Code;

        public string Grade;
    }
}