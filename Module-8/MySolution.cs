using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_8
{
    using System.Collections;
    using System.Threading;

    public class MySolution
    {
        public static void Main()
        {
            var studentA = new Student("Oerry", "G' Brien", "January 23") { Grades = new Stack<double>() };
            studentA.Grades.Push(6.5);
            studentA.Grades.Push(8.1);
            studentA.Grades.Push(6.5);
            studentA.Grades.Push(7.6);
            studentA.Grades.Push(7);
            var studentB = new Student("Berry", "G' Orien", "January 3") { Grades = new Stack<double>() };
            studentB.Grades.Push(6.5);
            studentB.Grades.Push(8.1);
            studentB.Grades.Push(6.5);
            studentB.Grades.Push(4.6);
            studentB.Grades.Push(8);
            var studentC = new Student("Berry", "O' Grien", "January 13") { Grades = new Stack<double>() };
            studentC.Grades.Push(6.5);
            studentC.Grades.Push(8.1);
            studentC.Grades.Push(6.5);
            studentC.Grades.Push(4.6);
            studentC.Grades.Push(8);


            var course = new Course("Programming with C#", "DEV204x");
            course.Students = new List<Student> { studentA, studentB, studentC };

            course.ListStudents();

            var teacher = new Teacher("Gerry", "B' Orien", "January 31");

            course.Teachers = new Teacher[]
            {
                teacher
            };

            var degree = new Degree("Bachelor", "101011")
            {
                Courses = new Course[]
                {
                    course
                }
            };


            var uProgram = new UProgram("Information Technology", "10")
            {
                Degrees = new Degree[]
                {
                    degree
                }
            };

            /*
                The name of the program and the degree it contains
                The name of the course in the degree
                The count of the number of students in the course.
            */
            Console.WriteLine("The {0} program contains the {1} degree\n",
                uProgram.Name,
                uProgram.Degrees[0].Name);
            Console.WriteLine("The {0} degree contains the course {1}\n",
                uProgram.Degrees[0].Name,
                uProgram.Degrees[0].Courses[0].Name);
            Console.WriteLine("The {0} course contains {1} student(s)",
                uProgram.Degrees[0].Courses[0].Name,
                Student.StudentCount);
            Console.ReadLine();
        }
    }

    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string BirthDay { get; set; }
    }

    public class Student : Person
    {
        public static int StudentCount;

        public Stack<double> Grades { get; set; }

        public Student(
            string firstName,
            string lastName,
            string birthDay)
        {
            base.FirstName = firstName;
            base.LastName = lastName;
            base.BirthDay = birthDay;
            Student.StudentCount++;
        }

        public Test TakeTest(string[] questions, string codeTest, string nameTest)
        {
            var studentTest = new Test();
            studentTest.Answers = new string[questions.Length];
            studentTest.Code = codeTest;
            studentTest.Name = nameTest;
            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(string.Format("Q{0}) {1}: ", i.ToString(), questions[i]));
                studentTest.Answers[i] = Console.ReadLine();
                Console.WriteLine();
            }
            return studentTest;
        }

        public void ChangeGrade(double newGrade)
        {
            this.Grades.Pop();
            this.Grades.Push(newGrade);
        }
    }

    public class Test
    {
        public string Name { get; set; }

        public string Code { get; set; }

        public string[] Answers { get; set; }
    }

    public class Teacher : Person
    {
        public Teacher(
            string firstName,
            string lastName,
            string birthDay)
        {
            base.FirstName = firstName;
            base.LastName = lastName;
            base.BirthDay = birthDay;
        }

        public int GradeTest(Test test)
        {
            return this.parseAnswers(test.Answers);
        }

        public int parseAnswers(string[] answers)
        {
            throw new NotImplementedException("This method is not yet implemented!");
        }
    }

    public class UProgram
    {
        public string Name { get; set; }

        public string Code { get; set; }

        public Degree[] Degrees { get; set; }

        public UProgram(
            string name,
            string code)
        {
            this.Name = name;
            this.Code = code;
        }
    }

    public class Degree
    {
        public string Name { get; set; }

        public string Code { get; set; }

        public Course[] Courses { get; set; }

        public Degree(
            string name,
            string code)
        {
            this.Name = name;
            this.Code = code;
        }
    }

    public class Course
    {
        public string Name { get; set; }

        public string Code { get; set; }

        public List<Student> Students { get; set; }

        public Teacher[] Teachers { get; set; }

        public Course(
            string name,
            string code)
        {
            this.Name = name;
            this.Code = code;
        }

        public void ListStudents()
        {
            Console.WriteLine("Enlisted are the following students:");
            foreach (var student in this.Students)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
            Console.WriteLine("Enlisted, the preceding students are.\n");
        }
    }
}