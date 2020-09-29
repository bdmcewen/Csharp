using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exercise_11
{
    class Course
    {
        //Fields
        private List<Student> roster;
        private String minStudent;
        private String maxStudent;


        //properties
        private int CourseID { get; set; }
        private string CourseTitle { get; set; }

    
        //constructors
        public Course(int courseid, string coursetitle)
        {
            roster = new List<Student>();

            CourseID = courseid;
            CourseTitle = coursetitle;
        }

        public Course()
        {
            roster = new List<Student>();
            CourseID = 20001;
            CourseTitle = "";
        }


        //accessor methods
        public int GetCourseId()
        {
            return this.CourseID;
        }
        public string GetCourseTitle()
        {
            return this.CourseTitle;
        }

        public void SetCourseId(int courseid)
        {
            this.CourseID = courseid;
        }

        public void SetCourseTitle(string coursetitle)
        {
            this.CourseTitle = coursetitle;
        }

        public void DisplayMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Student Grades Manager");
            Console.WriteLine("----------------------");
            Console.WriteLine();

            Console.WriteLine("1. Add New Student");
            Console.WriteLine("2. Edit Student's Grade");
            Console.WriteLine("3. Remove a Student");
            Console.WriteLine("4. View Course Analytics");
            Console.WriteLine("5. View Class Roster");
            Console.WriteLine("6. Exit Program ");
            Console.WriteLine();
            Console.WriteLine("Please, enter a selection");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1": AddStudent(); break;
                case "2": EditGrade(); break;
                case "3": RemoveStudent(); break;
                case "4": DisplayAnalytics(); break;
                case "5": DisplayStudents(); ReturnToMenu(); break;
                case "6": ExitManager(); break;
            }
        }


        //Methods for editing array
        void AddStudent()
        {
            Console.Clear();
            Console.WriteLine("Creating a new Student Profile");
            Console.WriteLine("------------------------------");
   
            //DisplayStudents();

            Console.WriteLine();
            Console.WriteLine("Enter new students ID:");
            int newId = Convert.ToInt32(Console.ReadLine());
            foreach (Student s in roster)
                if (s.GetStudentId() == newId)
                {
                    Console.WriteLine();
                    Console.WriteLine(" Id already in use. Press any key to try again");
                    Console.ReadLine();
                    AddStudent();
                }

            Console.WriteLine();
            Console.WriteLine("Enter new students first name:");
            String fName = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Enter students last name:");
            String lName = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Enter students grade:");
            String grade = Console.ReadLine();
            decimal newGrade = Convert.ToDecimal(grade);

            AddToRoster(newId, lName, fName, newGrade);


        }

        private void AddToRoster(int studentid, String lastname, String firstname, decimal grade)
        {
            Student s = new Student();
            s.SetStudentId(studentid);
            s.SetLastName(lastname);
            s.SetFirstName(firstname);
            s.SetGrade(grade);
            roster.Add(s);

            Console.WriteLine();
            Console.WriteLine(firstname + " " + lastname + " has been added to the roster under ID # " + studentid);
            Console.WriteLine();

            ReturnToMenu();
        }

        void EditGrade()  
        {
            Console.Clear();
            Console.WriteLine("Grade Editing Menu");
            Console.WriteLine("------------------");
            Console.WriteLine();
            Console.WriteLine("There are currently " + roster.Count + " Students in your roster");
            DisplayStudents();

            Console.WriteLine("Choose and ID# to edit: ");
            try
            {
                int id = Convert.ToInt32(Console.ReadLine());
                foreach (Student s in roster)
                {
                    if (id == s.GetStudentId())
                    {
                        Console.WriteLine("Editing: " + s.GetStudentId() + " " + s.GetFirstName() + " " + s.GetLastName());
                        Console.WriteLine("Enter the students current grade: ");
                        decimal newGrade = Convert.ToDecimal(Console.ReadLine());

                        s.SetGrade(newGrade);

                        Console.WriteLine();
                        Console.WriteLine("The grade for student ID# " + id + " has been updated to " + newGrade);
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.Write("The grade for student ID# " + id + " has been updated.");
                    Console.WriteLine();

                    ReturnToMenu();
                }
            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine("Entry was invalid, press enter to try again.");
                Console.ReadLine();
                EditGrade();
            }

        }

        void RemoveStudent()
        {
            Console.Clear();
            Console.WriteLine("Student Removal Menu");
            Console.WriteLine("------------------");
            Console.WriteLine();
            Console.WriteLine("There are currently " + roster.Count + " Students in your roster");
            DisplayStudents();

            Console.WriteLine("Choose and ID# to remove: ");
            int id = Convert.ToInt32(Console.ReadLine());

            foreach (Student s in roster)
            {
                if (s.GetStudentId() == id)
                {
                    Console.WriteLine("Editing: " + s.GetStudentId() + " " + s.GetFirstName() + " " + s.GetLastName());

                    Console.WriteLine("Are you sure you want to remove this student from the roster [Y/N]: ");                 
                    String response = Console.ReadLine();
                    String affirmative = "Y";
                    String negatory = "N";

                    if (response == affirmative)
                    {
                        this.roster.Remove(s);
                        Console.WriteLine();
                        Console.WriteLine("The student profile associated with ID# " + id + " has been removed from the roster.");
                        Console.WriteLine();

                        ReturnToMenu();
                    }

                    if (response == negatory)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Operation has been Cancelled");
                        Console.WriteLine("Press enter to return to Student Roster");
                        Console.ReadLine();

                        RemoveStudent();                       
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Id not Found");
                    Console.WriteLine("Press enter to try again");
                    Console.ReadLine();
                    RemoveStudent();
                }
            }
        }

        void DisplayStudents()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Class Roster");
            Console.WriteLine("------------");

            Console.WriteLine("There are currently " + roster.Count + " Students in your roster");
            foreach (Student s in roster)
            {
                Console.WriteLine(s.toString());
            }

            
        }

        public string toString()
        {
            string s = "";
            s += this.CourseID + " " + this.CourseTitle;
            return s;
        }

        

        //methods for analytics
        private double CalcAverageGrade()
        {
            double avg = 0.0;
            double sum = 0.0;

            foreach (Student s in roster)
            {
                sum += (double)s.GetGrade();
            }
                //calculate average grade
                avg = sum / roster.Count;
            return avg;
        }

        private double CalcMinGrade()
        {
            double min = 100.1;
            //determines grade with smallest value
            foreach (Student s in roster)
            {
                if (min > (double)s.GetGrade())
                {
                    min = (double)s.GetGrade();
                    minStudent = s.GetFirstName() + " " + s.GetLastName();
                }
            }
            return min;
        }

        private double CalcMaxGrade()
        {
            double max = -100.1;
            ////Determines grade with largest value

            foreach (Student s in roster)
                if (max < (double)s.GetGrade())
                {
                    max = (Double)s.GetGrade();
                    maxStudent = s.GetFirstName() + " " + s.GetLastName();
                }
            return max;
        }
   
        private decimal CalcMedianGrade()
        {
            List<Decimal> grades = new List<decimal>();
            decimal median;

            foreach(Student s in roster)
            {
                grades.Add(s.GetGrade());
            }
          
            int gradesLength = grades.Count;

            //calculates median
            if (gradesLength % 2 == 0)
            {
                median = ((grades[(gradesLength / 2)] + grades[(gradesLength / 2) - 1]) / 2);
            }
            else
            {
                median = (grades[(gradesLength - 1) / 2]);
            }

            return median;
        }
        
        private void CalcPercentGrades()
        {
           
            double aCount = 0;
            double bCount = 0;
            double cCount = 0;
            double dCount = 0;
            double fCount = 0;           
            double decagrades = roster.Count;



            //sorts by Letter grade
            
            foreach (Student s in roster)
            {
                if (s.GetGrade() >= 90)
                {
                    aCount += 1;
                }

                if (s.GetGrade() < 90 && s.GetGrade() >= 80)
                {
                    bCount += 1;
                }

                if (s.GetGrade() < 80 && s.GetGrade() >= 70)
                {
                    cCount += 1;
                }

                if (s.GetGrade() < 70 && s.GetGrade() >= 60)
                {
                    dCount += 1;
                }

                if (s.GetGrade() < 60)
                {
                    fCount += 1;
                }
            }

            Console.WriteLine("The # of As is: " + aCount);
            Console.WriteLine("The # of Bs is: " + bCount);
            Console.WriteLine("The # of Cs is: " + cCount);
            Console.WriteLine("The # of Ds is: " + dCount);
            Console.WriteLine("The # of Fs is: " + fCount);

            Console.WriteLine("There are " + roster.Count + " grades");


            Console.WriteLine("The percentage of As is: " + (aCount / decagrades) * 100 + "%");
            Console.WriteLine("The percentage of Bs is: " + (bCount / decagrades) * 100 + "%");
            Console.WriteLine("The percentage of Cs is: " + (cCount / decagrades) * 100 + "%");
            Console.WriteLine("The percentage of Ds is: " + (dCount / decagrades) * 100 + "%");
            Console.WriteLine("The percentage of Fs is: " + (fCount / decagrades) * 100 + "%");

            ReturnToMenu();
        }

        public void DisplayAnalytics()
        {           
            Console.WriteLine("The Class Average is: " + CalcAverageGrade());
            Console.WriteLine("The Class Min is: " + CalcMinGrade() + "minStudent");
            Console.WriteLine("The Class Max is: " + CalcMaxGrade() +"maxStudent");
            Console.WriteLine("The Class Median is: " + CalcMedianGrade());
            CalcPercentGrades();
                      
        }


        //Methods for menu navigation
        public void ReturnToMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to return to main menu");
            Console.ReadLine();

            DisplayMenu();
        }

        public void ExitManager()
        {
            Environment.Exit(0);
        }

    }


}
