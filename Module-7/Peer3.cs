using System.IO;
using System;
using System.Collections;

namespace Module_7.Peer3
{
    public class Peer3
    {
        public static void Main()
        {
            // creating three students
            Student s1 = new Student("Semir", "Gerkhan");
            Student s2 = new Student("Tom", "Kranich");
            Student s3 = new Student("Ben", "Jäger");

            // adding five grades - in CZE we use numbers as grades FYI :)
            for (int i = 1; i <= 5; i++)
            {
                s1.AddGrade(i);
                s2.AddGrade(i);
                s3.AddGrade(i);
            }

            Course course = new Course("Alarm für Cobra 11");
            course.AddStudent(s1);
            course.AddStudent(s2);
            course.AddStudent(s3);
            course.ListStudents();
            Console.ReadLine();
        }
    }
    public class Student
    {
        public Student(string first, string last)
        {
            this.FirstName = first;
            this.LastName = last;
            Student.NumberOfStudents++;
            this.Grades = new Stack();
        }

        public void AddGrade(int grade)
        {
            Grades.Push(grade);
        }


        public static int NumberOfStudents = 0;
        public Stack Grades;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birth { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string Country { get; set; }
    }

    public class Course
    {
        public Course(string name)
        {
            this.courseName = name;
            this.students = new ArrayList();
            //this.teachers = new Teacher[3];
        }

        public ArrayList students;
        //public Teacher[] teachers;

        public string courseName { get; set; }
        public int courseCredits { get; set; }
        public int courseDuration { get; set; }
        public string courseTeacher { get; set; }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void ListStudents()
        {
            foreach (Student student in students)
            {
                Console.WriteLine("Student {0} {1} is here", student.FirstName, student.LastName);
            }
        }
    }
}