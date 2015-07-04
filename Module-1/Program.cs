using System;

/*
NOTE: In this course you will create variables for classes in the application. 
For now, the class definitions are not included. 
In later modules, you will move this code into separate class files to aid in code reuse.
This assignment just lets you focus on data types, statements, etc. in C# to ease you into the language.

We'll use a common application theme throughout the course for your assignments.
The assignments will provide hands-on coding tasks to create application components
that could form a complete application when the course is finished.

For this module, you have learned about the data types, operators, and statements in C#.

Using this knowledge you will start to form some of the foundation for your application.
This assignment is designed to allow you to focus on the data types that are appropriate for
attributes of real-world objects. Later in the course, you will start to combine these attributes
with behaviors (methods) and then transition them into object-oriented classes.

Also, this assignment offers suggestions for attributes for each object but does
not give explicit instructions on every field required. You will be required to think through
the attributes of these "objects" as you create the necessary data to support them in an application.
Your list may be different in an application that you would create on your own.

1.  Create a C# Console application.

2.  Within the Main() method in this application, create variables of the correct data type
for the information related to a student only.  The other information will be used in later modules
when you create class files for the other objects listed:

Student Information

First Name	Last Name	Birthdate	Address Line 1	Address Line 2	City	State/Province	Zip/Postal	Country
Teacher Information

First Name	Last Name	Birthdate	Address Line 1	Address Line 2	City	State/Province	Zip/Postal	Country
UProgram Information

Program Name	Department Head	Degrees
Degree Information

Degree Name	Credits Required
Course Information

Course Name	Credits	Duration in Weeks	Teacher
3.  Once you have the variables created, use assignment statements to assign values
to one set of student variables and use the Console.WriteLine() method to output the values to the console window.

Again, this assignment is merely intended to check your understanding of how to create variables,
assign values to them, and output the information to a console window. 
You will build on these concepts and begin to create more functionality in later modules.

4.  Post your code in the peer review area for feedback from other students.

Challenge (Not graded)

Investigate the .NET Framework documenation around Console.ReadLine() and modify your
code to use this method for accepting input from a user of your application.
Using Console.ReadLine(), prompt a user for information about a student.
One prompt for each student variable you created earlier.
Use the appropriate code to assign the values from the user to the variables for the student.
*/
namespace Programming_with_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            DateTime birthDate;
            string addressLine1;
            string addressLine2;
            string city;
            string stateProvince;
            string zipPostal;
            string country;

            firstName = "Biff";
            lastName = "the Understudy";
            birthDate = DateTime.ParseExact(
                "1995-01-01 00:00:00,000",
                "yyyy-MM-dd HH:mm:ss,fff",
                System.Globalization.CultureInfo.InvariantCulture);
            addressLine1 = "Infinity loop 1";
            addressLine2 = "Infinity loop 3";
            city = "Cubertino";
            stateProvince = "California";
            zipPostal = "CA 95014";
            country = "United States";

            Console.WriteLine("First name: " + firstName);
            Console.WriteLine("Last name: " + lastName);
            Console.WriteLine("Birth date: " + birthDate.ToString());
            Console.WriteLine("Address line 1: " + addressLine1);
            Console.WriteLine("Address line 2: " + addressLine2);
            Console.WriteLine("City: " + city);
            Console.WriteLine("State/province: " + stateProvince);
            Console.WriteLine("Zip/postal code: " + zipPostal);
            Console.WriteLine("Country: " + country);
            Console.ReadLine();
        }
    }
}
