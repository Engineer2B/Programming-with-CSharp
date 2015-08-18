using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_7.Peer2
{
    using System.Collections;

    class Peer2
    {
        public static void Main()
        {
            Student Student1 = new Student("Bob");
            Student Student2 = new Student("Stuart");
            Student Student3 = new Student("Kevin");
            Course Course1 = new Course("Programming with C#");
            Course1.Students.Add(Student1);
            Course1.Students.Add(Student2);
            Course1.Students.Add(Student3);
            Student1.Grades.Push(1);
            Student1.Grades.Push(2);
            Student1.Grades.Push(5);
            Student1.Grades.Push(3);
            Student1.Grades.Push(4);
            Student2.Grades.Push(9);
            Student2.Grades.Push(10);
            Student2.Grades.Push(9.5);
            Student2.Grades.Push(8);
            Student2.Grades.Push(10);
            Student3.Grades.Push(6);
            Student3.Grades.Push(7);
            Student3.Grades.Push(6.5);
            Student3.Grades.Push(8);
            Student3.Grades.Push(7.5);
            Course1.ListStudents();
            Console.ReadKey();
        }
    }
    class Student
    {
        private string _sname;
        public string SName
        {
            get
            {
                return _sname;
            }
            set
            {
                if (value != null)
                    _sname = value;
            }
        }
        public Student(string _sname)
        {
            this.SName = _sname;
        }
        public Stack Grades = new Stack();
    }

    class Course
    {
        private string _cname;
        public string CName
        {
            get
            {
                return _cname;
            }
            set
            {
                if (value != null)
                    _cname = value;
            }
        }
        public Course() { }

        public Course(string _cname)
        {
            this.CName = _cname;
        }
        public ArrayList Students = new ArrayList();
        public void ListStudents()
        {
            foreach (Student newstudent in Students)
            {

                Console.WriteLine(newstudent.SName);
            }
        }
    }
}
