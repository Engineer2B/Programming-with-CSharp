using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_5.Peer3
{
    class Peer3
    {
    }

    class Student
    {
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        private string birthDay;

        public string BirthDay
        {
            get { return birthDay; }
            set { birthDay = value; }
        }
        private string addressLine1;

        public string AddressLine1
        {
            get { return addressLine1; }
            set { addressLine1 = value; }
        }
        private string addressLine2;

        public string AddressLine2
        {
            get { return addressLine2; }
            set { addressLine2 = value; }
        }
        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }
        private string state;

        public string State
        {
            get { return state; }
            set { state = value; }
        }
        private string zipCode;

        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }
        private string country;

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        private static int studentCount = 0;
        public Student()
        {
            studentCount++;
        }

        public static int StudentCount()
        {
            return studentCount;
        }
    }

    class Teacher
    {
        private string teachName;
        public string TeachName
        {
            get { return teachName; }
            set { teachName = value; }
        }

        private string teachAddress;
        public string TeachAddress
        {
            get { return teachAddress; }
            set { teachAddress = value; }
        }

        private string teachID;
        public string TeachID
        {
            get { return teachID; }
            set { teachID = value; }
        }

        private string teachPhone;
        public string TeachPhone
        {
            get { return teachPhone; }
            set { teachPhone = value; }
        }
    }

    class UProgram
    {

        private string programName;
        public string ProgramName
        {
            get { return programName; }
            set { programName = value; }
        }
        public UProgram(string name)
        {
            this.ProgramName = name;
            Degree degree = new Degree("Bachelor");
        }
    }

    class Degree
    {
        private string degName;
        public string DegName
        {
            get { return degName; }
            set { degName = value; }
        }

        private string degCredits;
        public string DegCredits
        {
            get { return degCredits; }
            set { degCredits = value; }
        }

        private string degInfo;
        public string DegInfo
        {
            get { return degInfo; }
            set { degInfo = value; }
        }
        public Degree(string name)
        {

            this.degName = name;

            Degree degree = new Degree("Bachelor");

        }
    }

    class Course
    {

        private Teacher[] teacherArr = new Teacher[3];
        private Student[] studentArr = new Student[3];
        private int counter = 0;

        private string courseName;
        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }

        private string courseID;
        public string CourseID
        {
            get { return courseID; }
            set { courseID = value; }
        }

        private string courseDes;
        public string CourseDes
        {
            get { return courseDes; }
            set { courseDes = value; }
        }

        private string courseDur;
        public string CourseDur
        {
            get { return courseDur; }
            set { courseDur = value; }
        }

        public Course(string name)
        {
            this.courseName = name;
            Course newcourse = new Course("Programming with C#");
        }

        public void addStudent(Student newStudent, int no)
        {
            if (studentArr != null)
            {
                studentArr[no] = newStudent;

            }

        }
        public void addTeachers()
        {
            for (int i = 0; i < 3; i++)
            {
                teacherArr[i] = new Teacher();
                numTeachersInThisCourse();
            }
        }
        public int numTeachersInThisCourse()
        {
            return counter++;
        }

    }
}