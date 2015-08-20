using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Module_9
{
    // MySolution
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Student> Students { get; }

        private int CurrentStudentIndex { get; set; }

        public MainWindow()
        {
            this.InitializeComponent();
            this.Students = new List<Student>();
        }

        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            var theStudent = new Student(
                this.txtFirstName.Text,
                this.txtLastName.Text,
                this.txtCity.Text);
            this.txtFirstName.Clear();
            this.txtLastName.Clear();
            this.txtCity.Clear();
            this.Students.Add(theStudent);
            MessageBox.Show("Student created.");
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (this.Students.Count > 0)
            {
                this.CurrentStudentIndex = (this.Students.Count + this.CurrentStudentIndex + 1) % this.Students.Count;
                this.SetStudent();
            }
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            if (this.Students.Count > 0)
            {
                this.CurrentStudentIndex = (this.Students.Count + this.CurrentStudentIndex - 1) % this.Students.Count;
                this.SetStudent();
            }
        }

        private void SetStudent()
        {
            var theStudent = this.Students[this.CurrentStudentIndex];
            this.txtFirstName.Text = theStudent.FirstName;
            this.txtLastName.Text = theStudent.LastName;
            this.txtCity.Text = theStudent.City;
        }
    }

    // Peer 1
    ///// <summary>
    ///// Interaction logic for MainWindowPeer2.xaml
    ///// </summary>
    //public partial class MainWindow : Window
    //{
    //    private List<Student> students = new List<Student>();
    //    private int _index;

    //    public int Index
    //    {
    //        get { return _index; }
    //        set
    //        {
    //            if (value > students.Count - 1)
    //            {
    //                _index = 0;
    //            }
    //            else if (value < 0)
    //            {
    //                _index = students.Count - 1;
    //            }
    //            else
    //            {
    //                _index = value;
    //            }
    //        }
    //    }

    //    public Student this[int index]
    //    {
    //        get { return students[index]; }
    //    }

    //    public MainWindow()
    //    {
    //        InitializeComponent();
    //    }

    //    private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
    //    {
    //        students.Add(new Student(txtFirstName.Text, txtLastName.Text, txtCity.Text));
    //        txtFirstName.Clear();
    //        txtLastName.Clear();
    //        txtCity.Clear();
    //    }

    //    private void btnNext_Click(object sender, RoutedEventArgs e)
    //    {
    //        Student student = students[Index];
    //        txtFirstName.Text = student.FirstName;
    //        txtLastName.Text = student.LastName;
    //        txtCity.Text = student.City;
    //        Index++;
    //    }

    //    private void btnPrevious_Click(object sender, RoutedEventArgs e)
    //    {
    //        Student student = students[Index];
    //        txtFirstName.Text = student.FirstName;
    //        txtLastName.Text = student.LastName;
    //        txtCity.Text = student.City;
    //        Index--;
    //    }
    //}

    // Peer2
    ///// <summary>
    ///// Interaction logic for MainWindow.xaml
    ///// </summary>
    //public partial class MainWindow : Window
    //{
    //    List<Student> studentList = new List<Student>();
    //    static int incrementCounter = 0;
    //    static int decrementCounter = 0;
    //    public MainWindow()
    //    {
    //        InitializeComponent();
    //    }

    //    private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
    //    {
    //        if (txtFirstName.Text != "" && txtLastName.Text != "" && txtCity.Text != "")
    //        {
    //            btnNext.IsEnabled = true;
    //            btnPrevious.IsEnabled = true;
    //            Student studentInfo = new Student(txtFirstName.Text, txtLastName.Text,txtCity.Text);
    //            studentInfo.FirstName = txtFirstName.Text;
    //            studentInfo.LastName = txtLastName.Text;
    //            studentInfo.City = txtCity.Text;
    //            studentList.Add(studentInfo);
    //            incrementCounter++;
    //            txtFirstName.Clear();
    //            txtLastName.Clear();
    //            txtCity.Clear();
    //            MessageBox.Show("Student created!");
    //        }
    //        else
    //        {
    //            MessageBox.Show("Please input valid data!");
    //        }
    //    }

    //    private void btnPrevious_Click(object sender, RoutedEventArgs e)
    //    {
    //        btnCreateStudent.IsEnabled = false;
    //        if (incrementCounter == 0)
    //            incrementCounter = studentList.Count;
    //        for (int i = incrementCounter - 1; i >= 0; i--)
    //        {
    //            txtFirstName.Text = studentList[i].FirstName;
    //            txtLastName.Text = studentList[i].LastName;
    //            txtCity.Text = studentList[i].City;
    //            incrementCounter--;
    //            break;
    //        }
    //    }

    //    private void btnNext_Click(object sender, RoutedEventArgs e)
    //    {
    //        btnCreateStudent.IsEnabled = false;
    //        if (decrementCounter == studentList.Count)
    //            decrementCounter = 0;
    //        for (int i = decrementCounter; i < studentList.Count; i++)
    //        {
    //            txtFirstName.Text = studentList[i].FirstName;
    //            txtLastName.Text = studentList[i].LastName;
    //            txtCity.Text = studentList[i].City;
    //            decrementCounter++;
    //            break;
    //        }
    //    }

    //    private void Window_Loaded(object sender, RoutedEventArgs e)
    //    {
    //        btnNext.IsEnabled = false;
    //        btnPrevious.IsEnabled = false;
    //    }
    //}

    // Peer3
    ///// <summary>
    ///// Interaction logic for MainWindow.xaml
    ///// </summary>
    //public partial class MainWindow : Window
    //{
    //    List<Student> Students = new List<Student>();
    //    int currentStudent = -1;

    //    public MainWindow()
    //    {
    //        InitializeComponent();
    //    }

    //    private void CreateStudent(object sender, RoutedEventArgs e)
    //    {
    //        Student sNew = new Student(txtFirstName.Text, txtLastName.Text, txtCity.Text);
    //        Students.Add(sNew);

    //        txtFirstName.Clear();
    //        txtLastName.Clear();
    //        txtCity.Clear();
    //        currentStudent = -1;

    //    }

    //    private void PreviousStudent(object sender, RoutedEventArgs e)
    //    {
    //        if (currentStudent != -1)
    //        {
    //            currentStudent--;
    //        }

    //        if ((currentStudent > -1) && (currentStudent < Students.Count()))
    //        {
    //            txtFirstName.Text = Students[currentStudent].FirstName;
    //            txtLastName.Text = Students[currentStudent].LastName;
    //            txtCity.Text = Students[currentStudent].City;
    //        }
    //        else
    //        {
    //            MessageBox.Show("Sorry there are no previous students to display... try adding a few more!");
    //            txtFirstName.Clear();
    //            txtLastName.Clear();
    //            txtCity.Clear();
    //            currentStudent = -1;
    //        }

    //    }

    //    private void NextStudent(object sender, RoutedEventArgs e)
    //    {
    //        if (currentStudent == -1)
    //        {
    //            //start with first student
    //            currentStudent = 0;
    //        }
    //        else
    //        {
    //            currentStudent++;
    //        }

    //        if (currentStudent < Students.Count())
    //        {
    //            txtFirstName.Text = Students[currentStudent].FirstName;
    //            txtLastName.Text = Students[currentStudent].LastName;
    //            txtCity.Text = Students[currentStudent].City;
    //        }
    //        else
    //        {
    //            MessageBox.Show("Sorry, there are no more students to display... try adding a few more!");
    //            currentStudent--;
    //        }

    //    }
    //}
}