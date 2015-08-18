namespace Module_5
{
    using System;
    using System.Reflection.Emit;

    public static class MySolution
    {
        public static void Main()
        {
            var students = new Student[]
            {
                new Student("Oerry","G' Brien","January 23"),
                new Student("Berry","G' Orien","January 3"),
                new Student("Berry","O' Grien","January 13")
            };
            var course = new Course("Programming with C#","DEV204x");

            course.Students = students;

            var teacher = new Teacher("Gerry", "B' Orien", "January 31");

            course.Teachers = new Teacher[]
            {
                teacher
            };

            var degree = new Degree("Bachelor", "101011");
            
            degree.Courses = new Course[]
            {
                course
            };

            var uProgram = new UProgram("Information Technology", "10");

            uProgram.Degrees = new Degree[]
            {
                degree
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

    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string BirthDay { get; set; }

        public static int StudentCount;

        public Student(
            string firstName,
            string lastName,
            string birthDay)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDay = birthDay;
            Student.StudentCount++;
        }
    }

    public class Teacher
    {
        public string FirstName{ get; set; }

        public string LastName{ get; set; }

        public string BirthDay { get; set; }

        public Teacher(
            string firstName,
            string lastName,
            string birthDay)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDay = birthDay;
        }
    }

    public class UProgram
    {
        public string Name{ get; set; }

        public string Code{ get; set; }

        public Degree[] Degrees{ get; set; }

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
        public string Name{ get; set; }

        public string Code{ get; set; }

        public Course[] Courses{ get; set; }

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
        public string Name{ get; set; }

        public string Code{ get; set; }

        public Student[] Students{ get; set; }

        public Teacher[] Teachers{ get; set; }

        public Course(
            string name,
            string code)
        {
            this.Name = name;
            this.Code = code;
        }
    }
}