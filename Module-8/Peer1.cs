using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_8.Peer1
{
    public class Peer1
    {
        public static void Main()
        {
            //create teacher
            // Teacher teacher = new Teacher("Pro", "Fessor", Convert.ToDateTime("1988-01-01"));

            ////set program name
            //UProgram prog = new UProgram();
            //prog._Name = "Information Technology";

            ////set Degree
            //Degree degree = new Degree("Bachelor");
            //prog.Degree = degree;

            //Course name
            Course course = new Course("Programming with C#");
            // degree.Course = course;
            // course.AddTeacher(teacher);

            //add students
            var student1 = new Student("John", "Doe", Convert.ToDateTime("1990-01-01"));
            var student2 = new Student("Peter", "Doe", Convert.ToDateTime("1995-02-02"));
            var student3 = new Student("Sarah", "Doe", Convert.ToDateTime("2000-03-03"));

            course.AddStudent(student1);
            course.AddStudent(student2);
            course.AddStudent(student3);

            //Add Grades
            // Assign 5 grades to each student.
            foreach (Student student in course._Students)
            {
                for (int i = 0; i < 5; i++)
                {
                    student.Grades.Push(85);
                }
            }

            //prog.WriteInfo();
            //degree.WriteInfo();
            course.ListStudents();

        }
    }
    public class Course
    {
        private string name;
        private List<Teacher> teacherlist = new List<Teacher>();
        private List<Student> students = new List<Student>();

        public Course(string coursename)
        {
            this.name = coursename;
        }

        public string _Name
        {
            get { return name; }
            set { name = value; }
        }
        internal List<Student> _Students
        {
            get { return students; }
            set { students = value; }
        }
        internal List<Teacher> _Teacherlist
        {
            get { return teacherlist; }
            set { teacherlist = value; }
        }

        public void AddStudent(Student s)
        {
            students.Add(s);
        }
        public void AddTeacher(Teacher t)
        {
            teacherlist.Add(t);
        }
        public void ListTeachers()
        {
            foreach (Teacher t in teacherlist)
            {
                Console.WriteLine("{0} {1}", t.FirstName, t.LastName);
            }
        }
        public void ListStudents()
        {
            foreach (Student s in students)
            {
                Console.WriteLine("{0} {1}", s.FirstName, s.LastName);
            }
        }
    }

    public class Student : Person
    {
        public static int StudentsInSchool = 0;
        public Stack<int> Grades { get; set; }

        // Constructor, calls base constructor for Person.
        public Student(string firstName, string lastName, DateTime birthdate)
        {
            Grades = new Stack<int>();
            StudentsInSchool++;
        }

        void TakeTest()
        {
            Console.WriteLine("Test taken.");
        }
    }
}
