using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_6
{
    class Peer2
    {
        public class Person
        {
            // Declare encapsulated member variables (private):
            private string firstName, lastName, birthdate, address1, address2, city, state, country;
            private int zipCode;

            // Declare public properties to access the member variables:
            public string FirstName
            {
                get { return firstName; }
                set { firstName = value; }
            }
            public string LastName
            {
                get { return lastName; }
                set { lastName = value; }
            }
            public string Birthdate
            {
                get { return birthdate; }
                set { birthdate = value; }
            }
            public string Address1
            {
                get { return address1; }
                set { address1 = value; }
            }
            public string Address2
            {
                get { return address2; }
                set { address2 = value; }
            }
            public string City
            {
                get { return city; }
                set { city = value; }
            }
            public string State
            {
                get { return state; }
                set { state = value; }
            }
            public string Country
            {
                get { return country; }
                set { country = value; }
            }
            public int ZipCode
            {
                get { return zipCode; }
                set { zipCode = value; }
            }
        }
        public class Student : Person
        {
            // TakeTest method specific to the Student class:
            public void TakeTest()
            {
                Console.WriteLine("Hooray! A test! Finally!\n");
            }

            // Create static field to count the number of Student objects created (private):
            private static int numberOfStudents = 0;

            // Method that returns the number of Student objects created (public):
            public static int GetNumberOfStudents()
            {
                return numberOfStudents;
            }

            // Default constructor
            public Student()
            {
                numberOfStudents++; // Increase counter every time a Student object is created via default constructor
            }

            // Overloaded (custom) constructor
            public Student(string first, string last, string birth, string add1, string add2, string cit, string sta, int postc, string cntry)
            {
                // Assign the incoming values to the properties of the Student class
                this.FirstName = first;
                this.LastName = last;
                this.Birthdate = birth;
                this.Address1 = add1;
                this.Address2 = add2;
                this.City = cit;
                this.State = sta;
                this.ZipCode = postc;
                this.Country = cntry;

                numberOfStudents++; // Increase counter every time a Student object is created via custom constructor
            }
        }
        public class Teacher : Person
        {
            // ProvideTest method specific to the Teacher class:
            public void ProvideTest()
            {
                Console.WriteLine("Students, lets have a test! :)\n");
            }

            // Default constructor
            public Teacher()
            {
                // no content needed for now
            }

            // Overloaded (custom) constructor
            public Teacher(string first, string last, string birth, string add1, string add2, string cit, string sta, int postc, string cntry)
            {
                // Assign the incoming values to the properties of the Teacher class
                this.FirstName = first;
                this.LastName = last;
                this.Birthdate = birth;
                this.Address1 = add1;
                this.Address2 = add2;
                this.City = cit;
                this.State = sta;
                this.ZipCode = postc;
                this.Country = cntry;
            }
        }
    }
}
