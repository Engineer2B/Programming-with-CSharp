//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Module_5
//{
//    using System.Threading;

//    public class Peer2
//    {
//    }

//    public class Student : Person
//    {
//        ////////////////////////
//        // Grading Criteria 2 //
//        ////////////////////////
//        Stack<decimal> grades;
//        public Stack<decimal> Grades
//        {
//            get { return grades; }
//            set { grades = value; }
//        }

//        static int numberOfStudentsEnrolled = 0;
//        public static int NumberOfStudentsEnrolled
//        {
//            get { return Student.numberOfStudentsEnrolled; }
//        }

//        Decimal accountBalance;
//        public Decimal AccountBalance
//        {
//            get { return accountBalance; }
//            set { accountBalance = value; }
//        }

//        float overallGPA;
//        public float OverallGPA
//        {
//            get { return overallGPA; }
//            set { overallGPA = value; }
//        }

//        bool isEnrolled;
//        public bool IsEnrolled
//        {
//            get { return isEnrolled; }
//            set { isEnrolled = value; }
//        }

//        public Student(string firstName, string lastName) : base(firstName, lastName)
//        {
//            grades = new Stack<decimal>();
//            Interlocked.Increment(ref numberOfStudentsEnrolled);
//        }

//        ~Student()
//        {
//            /* THIS IS NOT GOOD ENOUGH!!! Even though we have locked the thread
//            * for both our constructor's increment and our destuctor's
//            * decrement, we still don't know when the object will actually be
//            * dealt with by the garbage collector. We would need to keep a
//            * list of weak references to all the objects and when we check to
//            * see how many there are, remove all the non-active weak
//            * references to our Students created list. */

//            Interlocked.Decrement(ref numberOfStudentsEnrolled);
//        }

//        public void TakeTest()
//        {
//            Console.WriteLine("{0} {1} just took a test!", firstName, lastName);
//        }
//    }

//    public class Teacher : Person
//    {
//        public Teacher(string firstName, string lastName) : base(firstName, lastName)
//        { }

//        public void GradeTest()
//        {
//            Console.WriteLine("{0} {1} just graded a test!", firstName, lastName);
//        }
//    }

//    public class UProgram
//    {
//        string name;
//        public string Name
//        {
//            get { return name; }
//            set { name = value; }
//        }

//        List<Degree> degreesOffered;
//        public List<Degree> DegreesOffered
//        {
//            get { return degreesOffered; }
//        }

//        string departmentHeadFullName;
//        public string DepartmentHeadFullName
//        {
//            get { return departmentHeadFullName; }
//            set { departmentHeadFullName = value; }
//        }

//        public UProgram(string name, List<Degree> degreesOffered,
//        string departmentHeadFullName)
//        {
//            this.name = name;
//            this.degreesOffered = degreesOffered;
//            this.departmentHeadFullName = departmentHeadFullName;
//        }

//        public UProgram(string name) : this(name, new List<Degree>(), "")
//        { }

//        public void AddDegree(Degree degree)
//        {
//            degreesOffered.Add(degree);
//        }
//    }

//    public class Degree
//    {
//        string name;
//        public string Name
//        {
//            get { return name; }
//            set { name = value; }
//        }

//        int totalCreditsRequired;
//        public int TotalCreditsRequired
//        {
//            get { return totalCreditsRequired; }
//            set { totalCreditsRequired = value; }
//        }

//        int upperLevelCreditsRequired;
//        public int UpperLevelCreditsRequired
//        {
//            get { return upperLevelCreditsRequired; }
//            set { upperLevelCreditsRequired = value; }
//        }

//        List<Course> requiredCourses;
//        public List<Course> RequiredCourses
//        {
//            get { return requiredCourses; }
//        }

//        public Degree(string name) : this(name, 0, 0)
//        { }

//        public Degree(string name, int totalCreditsRequired,
//        int upperLevelCreditsRequired)
//        {
//            this.name = name;
//            this.totalCreditsRequired = totalCreditsRequired;
//            this.upperLevelCreditsRequired = upperLevelCreditsRequired;

//            this.requiredCourses = new List<Course>();
//        }

//        public void AddCourse(Course courseToAdd)
//        {
//            requiredCourses.Add(courseToAdd);
//        }
//    }

//    class Course
//    {
//        string name;
//        public string Name
//        {
//            get { return name; }
//            set { name = value; }
//        }

//        string referenceNumber;
//        public string ReferenceNumber
//        {
//            get { return referenceNumber; }
//            set { referenceNumber = value; }
//        }

//        int creditHours;
//        public int CreditHours
//        {
//            get { return creditHours; }
//            set { creditHours = value; }
//        }

//        ////////////////////////
//        // Grading Criteria 1 //
//        ////////////////////////
//        List<Student> studentsEnrolled;
//        public List<Student> StudentsEnrolled
//        {
//            get { return studentsEnrolled; }
//        }

//        Teacher[] teachersAndAssistants;
//        public Teacher[] TeachersAndAssistants
//        {
//            get { return teachersAndAssistants; }
//        }

//        public Course() : this("", "", 0)
//        { }

//        public Course(string name, string referenceNumber, int creditHours)
//        {
//            this.name = name;
//            this.referenceNumber = referenceNumber;
//            this.creditHours = creditHours;

//            studentsEnrolled = new List<Student>();
//            teachersAndAssistants = new Teacher[3];
//        }

//        public Course(string name) : this(name, "", 0)
//        { }

//        public void AddStudent(Student student)
//        {
//            ////////////////////////
//            // Grading Criteria 3 //
//            ////////////////////////
//            studentsEnrolled.Add(student);
//        }

//        public void AddStudent(Student[] studentsToAdd)
//        {
//            foreach (Student student in studentsToAdd)
//            {
//                AddStudent(student);
//            }
//        }

//        public void AddStudent(List<Student> studentsToAdd)
//        {
//            AddStudent(studentsToAdd.ToArray());
//        }

//        public void AddTeacher(Teacher teacher)
//        {
//            int teacherCount = teachersAndAssistants.Count(s => s != null);
//            teachersAndAssistants[teacherCount] = teacher;
//        }

//        public void ListStudents()
//        {
//            ////////////////////////
//            // Grading Criteria 4 //
//            ////////////////////////
//            foreach (Student student in studentsEnrolled)
//            {
//                Console.WriteLine(student.LastName + ", " + student.FirstName);
//            }
//        }
//    }
//}