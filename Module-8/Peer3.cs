using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_8.Peer3
{
    public class Peer3
    {
        private const int SIZE = 3;

        public static void Main()
        {
            List<Student> students = new List<Student>(SIZE);
            students.Add(new Student("Mich", "Dm"));
            students.Add(new Student("Scott", "Liv"));
            students.Add(new Student("Max", "Bill"));

            List<Teacher> teachers = new List<Teacher>();
            //teachers.Add(new Teacher("Oleg", "Basilica"));

            //Degree degree = new Degree("Bachelor");
            //UProgram uProgram = new UProgram("Information Technology");

            Course course = new Course("Programming with C#");
            course.AddStudents(students);
            // course.AddTeacher(teachers[0]);
            //degree.Course = course;
            //uProgram.Degree = degree;

            course.ListStudent();

            //Console.WriteLine(uProgram.ToString());
            //Console.WriteLine(degree.ToString());
            Console.WriteLine(course.ToString());
            Console.ReadLine();
        }
    }

    public class Student : Person
    {
        private Stack<int> gradesStack = new Stack<int>();

        public Student(string firstName, string lastName)
        {
        }

        public void TakeTest()
        {
            gradesStack.Push(100);
            gradesStack.Push(96);
            gradesStack.Push(89);
            gradesStack.Push(77);
            gradesStack.Push(94);
        }

        public override string ToString()
        {
            return String.Format("Student {0} , {1}", FirstName, LastName);
        }
    }

    public class Course
    {
        public string Name { get; set; }
        private List<Student> _students = new List<Student>();
        private List<Teacher> _teachers = new List<Teacher>();
        private String allStudents = "\n\t";

        public Course(string name)
        {
            Name = name;
        }

        public void AddStudent(Student student)
        {
            _students.Add(student);
        }

        public void AddStudents(List<Student> students)
        {
            foreach (Student student in students)
            {
                _students.Add(student);
            }
        }

        public void AddTeacher(Teacher teacher)
        {
            _teachers.Add(teacher);
        }

        public void AddTeachers(Teacher[] teachers)
        {
            _teachers.AddRange(teachers);
        }

        public override string ToString()
        {
            _students.ForEach(Print);
            return String.Format("The {0} course contain {1} student<s>: {2}", Name, _students.Count, allStudents);
        }

        private void Print(Student student)
        {
            allStudents += (student + "; ");
        }

        public void ListStudent()
        {
            foreach (Student student in _students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
