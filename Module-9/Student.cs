using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_9
{
    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string City { get; set; }
    }

    public class Student : Person
    {
        public static int StudentCount;

        public Stack<double> Grades { get; set; }

        public Student(
            string firstName,
            string lastName,
            string city)
        {
            base.FirstName = firstName;
            base.LastName = lastName;
            base.City = city;
            Student.StudentCount++;
        }

        public void ChangeGrade(double newGrade)
        {
            this.Grades.Pop();
            this.Grades.Push(newGrade);
        }
    }
}
