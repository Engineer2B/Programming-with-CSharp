/*
Now that you have created some classes for your application, it's time to start thinking about your class hMySolution.MySolution.Main();ierarchies.
In a typical development cycle, you would design your class heirarchies first, create your base classes, and then your sub classes.
In a learning environment, you need to know how to create classes before you become inundated with inheritance heirarchies.

For this assignment:

Create a Person base class with common attributes for a person
Make your Student and Teacher classes inherit from the Person base class
Modify your Student and Teacher classes so that they inherit the common attributes from Person
Modify your Student and Teacher classes so they include characteristics specific to their type.
For example, a Teacher object might have a GradeTest() method where a student might have a TakeTest() method.
Run the same code in Program.cs from Module 5 to create instances of your classes so that you can setup a
single course that is part of a program and a degree path.   Be sure to include at least one Teacher and an array of Students.
Ensure the Console.WriteLine statements you included in Homework 5, still output the correct information.
Share your code for feedback and ideas with your fellow students such as:
What other objects could benefit from inheritance in this code?
Can you think of a different hierarchy for the Person, Teacher, and Student?  What is it?
Do NOT grade the answers to these two questions, they are merely for discussion and thought.
Only grade the ability to implement inheritance in the code.
Challenge ( Do NOT submit this to the peer review.  This is for you use only)

Create an instance of a Person object in code
Create an instance of a Student object in code
Assign the Student object to the Person object
Access the properties of the Person instance you created
What do you notice about the properties for the Person instance?
Can you explain the behavior of the properties?
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_6
{
    class Program
    {
        static void Main(string[] args)
        {
            MySolution.Main();
            Peer1.Main();
        }
    }
}
