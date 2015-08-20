using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_8
{
    class Peer2
    {
        public static void Main()
        {
            Student Student1 = new Student("Roman", "Sergienko", "14.11.1987", "Ulm", "Germany");
            Student Student2 = new Student("Maxim", "Sidorov", "06.11.1988", "Ulm", "Germany");
            Student Student3 = new Student("Oleg", "Akhtiamov", "07.02.1993", "Krasnoyarsk", "Russia");
            for (int i = 0; i < 5; i++)//Adding test scores
            {
                Student1.Grades.Push(4.3 + 0.1 * i);
                Student2.Grades.Push(4.0 + 0.1 * i);
                Student3.Grades.Push(3.8 + 0.1 * i);
            }
            Course Programming = new Course("Programming in C#", 100, 4);
            Programming.ListOfStudents1.Add(Student1);
            Programming.ListOfStudents1.Add(Student2);
            Programming.ListOfStudents1.Add(Student3);
            Teacher lector = new Teacher("Wolfgang", "Minker", "11.02.1967", "Ulm", "Germany");
            Programming.Teachers[0] = lector;
            degree Bachelor = new degree("Bachelor", 1000, Programming);
            UProgramm IT = new UProgramm("Information Technology", "Martin Bossert", Bachelor);
            Console.WriteLine("The {0} program contains the {1} degree", IT.Name, IT.Degree.Name);
            Console.WriteLine("The {0} degree contains the {1} course", IT.Degree.Name, IT.Degree.Course.Name);
            Console.WriteLine("The {0} course contains {1} students", IT.Degree.Course.Name, Student.CountStudents1);
            Programming.ListStudents();
            Console.ReadKey();
        }
        public abstract class Person
        {
            private string _firstName;
            private string _lastName;
            private string birthday;
            private string addressLine1;
            private string addressLine2;
            private string city;
            private string state;
            private int zip;
            private string country;
            public string FirstName
            {
                get
                {
                    return _firstName;
                }

                set
                {
                    _firstName = value;
                }
            }

            public string LastName
            {
                get
                {
                    return _lastName;
                }

                set
                {
                    _lastName = value;
                }
            }

            public string Birthday
            {
                get
                {
                    return birthday;
                }

                set
                {
                    birthday = value;
                }
            }

            public string AddressLine1
            {
                get
                {
                    return addressLine1;
                }

                set
                {
                    addressLine1 = value;
                }
            }

            public string AddressLine2
            {
                get
                {
                    return addressLine2;
                }

                set
                {
                    addressLine2 = value;
                }
            }

            public string City
            {
                get
                {
                    return city;
                }

                set
                {
                    city = value;
                }
            }

            public string State
            {
                get
                {
                    return state;
                }

                set
                {
                    state = value;
                }
            }

            public int Zip
            {
                get
                {
                    return zip;
                }

                set
                {
                    zip = value;
                }
            }

            public string Country
            {
                get
                {
                    return country;
                }

                set
                {
                    country = value;
                }
            }
        }
        public class Student : Person
        {
            private int semester;//The current semester of the student
            private static int CountStudents = 0;
            private Stack<double> grades;
            public int Semester
            {
                get
                {
                    return semester;
                }

                set
                {
                    semester = value;
                }
            }

            public Stack<double> Grades
            {
                get
                {
                    return grades;
                }

                set
                {
                    grades = value;
                }
            }

            public static int CountStudents1
            {
                get
                {
                    return CountStudents;
                }

                set
                {
                    CountStudents = value;
                }
            }

            //Constructor
            public Student(string name1, string name2, string date1, string city1, string country1)
            {
                this.FirstName = name1;
                this.LastName = name2;
                this.Birthday = date1;
                this.City = city1;
                this.Country = country1;
                this.Grades = new Stack<double>();
                CountStudents1++;
            }
        }
        public class Teacher : Person
        {
            private int experience;//The experience of the teacher in years
                                   //Constructor
            public Teacher(string name1, string name2, string date1, string city1, string country1)
            {
                this.FirstName = name1;
                this.LastName = name2;
                this.Birthday = date1;
                this.City = city1;
                this.Country = country1;
            }

            public int Experience
            {
                get
                {
                    return experience;
                }

                set
                {
                    experience = value;
                }
            }
        }
        public class UProgramm
        {
            private string name;
            private string departmentHead;
            private degree _degree;
            public string Name
            {
                get
                {
                    return name;
                }

                set
                {
                    name = value;
                }
            }

            public string DepartmentHead
            {
                get
                {
                    return departmentHead;
                }

                set
                {
                    departmentHead = value;
                }
            }

            internal degree Degree
            {
                get
                {
                    return _degree;
                }

                set
                {
                    _degree = value;
                }
            }
            //Constructor
            public UProgramm(string name1, string head, degree degree1)
            {
                this.Name = name1;
                this.DepartmentHead = head;
                this.Degree = degree1;
            }
        }
        public class degree
        {
            private string name;
            private int credits;
            private Course course;

            public string Name
            {
                get
                {
                    return name;
                }

                set
                {
                    name = value;
                }
            }

            public int Credits
            {
                get
                {
                    return credits;
                }

                set
                {
                    credits = value;
                }
            }

            internal Course Course
            {
                get
                {
                    return course;
                }

                set
                {
                    course = value;
                }
            }
            //Constructor
            public degree(string name1, int credits1, Course course1)
            {
                this.Name = name1;
                this.Credits = credits1;
                this.Course = course1;
            }
        }
        public class Course
        {
            private string name;
            private int credits;
            private int duration;
            private List<Student> ListOfStudents;
            private Teacher[] teachers;
            public string Name
            {
                get
                {
                    return name;
                }

                set
                {
                    name = value;
                }
            }

            public int Credits1
            {
                get
                {
                    return credits;
                }

                set
                {
                    credits = value;
                }
            }

            public int Duration
            {
                get
                {
                    return duration;
                }

                set
                {
                    duration = value;
                }
            }

            internal Teacher[] Teachers
            {
                get
                {
                    return teachers;
                }

                set
                {
                    teachers = value;
                }
            }

            public List<Student> ListOfStudents1
            {
                get
                {
                    return ListOfStudents;
                }

                set
                {
                    ListOfStudents = value;
                }
            }

            //Constructor
            public Course(string name1, int credits1, int duration1)
            {
                this.Name = name1;
                this.Credits1 = credits1;
                this.Duration = duration1;
                this.ListOfStudents1 = new List<Student>();
                this.Teachers = new Teacher[3];
            }
            public void ListStudents()
            {
                Console.WriteLine("The list of the students of the course {0}", this.Name);
                foreach (Student Student1 in ListOfStudents1)
                    Console.WriteLine(Student1.FirstName + " " + Student1.LastName);
            }
        }
    }
}