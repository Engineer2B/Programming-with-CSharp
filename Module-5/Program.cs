/*
In this assignment, you need to convert your objects for the application into class files.
Create a class file for:

A Student
A Teacher
A UProgram (C# uses Program as the name of the class that contains Main()
so we must use a different class name here)
A Degree
A Course
Transfer the variables you created in Module 1 into these class files.
Ensure that you encapsulate your member variables in the class files using properties.

The Course object should contain an array of Student objects so ensure that you create
an array inside the Course object to hold Students as well as an array to contain
Teacher objects as each course may have more than one teacher or TAs.
For this assignment, create arrays of size 3 for students and the same for teachers. 
The UProgram object should be able to contain degrees and the degrees should be able
to contain courses as well but for the purposes of this assignment, just ensure you
have a single variable in UProgram to hold a Degree and single variable in Degree to hold a Course.  

Use this diagram as an example of how the objects relate to each other.

Class diagram showing the Program, Degree, Course, Student, and Teacher classes in
a hiearchy where a Program is at the top, and contains Degrees which in turn
contain Courses, which include students and teachers.

Add a static class variable to the Student class to track the number of students
currently enrolled in a school.

Increment a student object count every time a Student is created.

In the Main() method of Program.cs:

Instantiate three Student objects.
Instantiate a Course object called Programming with C#.
Add your three students to this Course object.
Instantiate at least one Teacher object.
Add that Teacher object to your Course object
Instantiate a Degree object, such as Bachelor.
Add your Course object to the Degree object.
Instantiate a UProgram object called Information Technology.
Add the Degree object to the UProgram object.

Using Console.WriteLine statements, output the following information to the console window:
The name of the program and the degree it contains
The name of the course in the degree
The count of the number of students in the course.

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_5
{
    class Program
    {
        static void Main(string[] args)
        {
            MySolution.Main();
            Peer1.Peer1.Main();
        }
    }
}
