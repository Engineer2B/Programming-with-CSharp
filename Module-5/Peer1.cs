using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_5.Peer1
{
    public static class Peer1
    {
        public static void Main()
        {
        }
    }

    public class Student
    {
        private static int student_count = 0;

        public Student()
        {
            student_count = student_count + 1;
        }

        private string Fname;

        public string Fname1
        {
            get { return Fname; }
            set { Fname = value; }
        }
        private string Lname;

        public string Lname1
        {
            get { return Lname; }
            set { Lname = value; }
        }
        private string Birthdate;

        public string Birthdate1
        {
            get { return Birthdate; }
            set { Birthdate = value; }
        }
        private string Address1;

        public string Address11
        {
            get { return Address1; }
            set { Address1 = value; }
        }
        private string Address2;

        public string Address21
        {
            get { return Address2; }
            set { Address2 = value; }
        }
        private string City;

        public string City1
        {
            get { return City; }
            set { City = value; }
        }
        private string State;

        public string State1
        {
            get { return State; }
            set { State = value; }
        }
        private int zip;

        public int Zip
        {
            get { return zip; }
            set { zip = value; }
        }
        private string country;

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public int retcount()
        {
            return student_count;
        }
    }

    public class Teacher
    {
        private string Fname;

        public string Fname1
        {
            get { return Fname; }
            set { Fname = value; }
        }

        private string Lname;

        public string Lname1
        {
            get { return Lname; }
            set { Lname = value; }
        }

        private string Birthdate;

        public string Birthdate1
        {
            get { return Birthdate; }
            set { Birthdate = value; }
        }

        private string Address1;

        public string Address11
        {
            get { return Address1; }
            set { Address1 = value; }
        }

        private string Address2;

        public string Address21
        {
            get { return Address2; }
            set { Address2 = value; }
        }

        private string City;

        public string City1
        {
            get { return City; }
            set { City = value; }
        }

        private string State;

        public string State1
        {
            get { return State; }
            set { State = value; }
        }

        private int zip;

        public int Zip
        {
            get { return zip; }
            set { zip = value; }
        }

        private string country;

        public string Country
        {
            get { return country; }
            set { country = value; }
        }
    }

    public class UProgram
    {

        private string Name;

        public string Name1
        {
            get { return Name; }
            set { Name = value; }
        }
        private string Head;

        public string Head1
        {
            get { return Head; }
            set { Head = value; }
        }

        private string Degrees;

        public string Degrees1
        {
            get { return Degrees; }
            set { Degrees = value; }
        }

        public Degree[] sample_degree = new Degree[1];
    }

    public class Degree
    {
        private string degree_name;

        public string Degree_name
        {
            get { return degree_name; }
            set { degree_name = value; }
        }
        private int credits;

        public int Credits
        {
            get { return credits; }
            set { credits = value; }
        }

        public Course[] sample_course = new Course[1];
    }

    public class Course
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int credits;

        public int Credits
        {
            get { return credits; }
            set { credits = value; }
        }
        private int duration;

        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }
        private string teacher;

        public string Teacher
        {
            get { return teacher; }
            set { teacher = value; }
        }

        public Student[] st = new Student[3];
        public Teacher[] tch = new Teacher[3];

    }
}