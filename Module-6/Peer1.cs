using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_6
{
    class Peer1
    {
        public static void Main()
        {
            Person p = new Person();
            Student s = new Student();
            Teacher t = new Teacher();
        }
        class Person
        {
            public string name, city, address;
            public int age;
            public void displayInfo()
            {
                throw new NotImplementedException();
            }
        }
        class Student : Person
        {
            public int studID, year;
            public double cgpa;
            public void TakeTest()
            {
                throw new NotImplementedException();
            }
        }
        class Teacher : Person
        {
            public string department;
            public int teachID;
            public void GradeTest()
            {
                throw new NotImplementedException();
            }
        }
    }
}
