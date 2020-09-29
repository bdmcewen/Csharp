using System;
using System.Collections.Generic;

namespace OOP_Exercise_11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Course> courseList = new List<Course>();

            DisplayMainMenu();
          
            void DisplayMainMenu()
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Course Manager");
                Console.WriteLine("----------------------");
                Console.WriteLine();

                Console.WriteLine("1. Add New Course");
                Console.WriteLine("2. Edit a Course");
                Console.WriteLine("3. Remove a Course");              
                Console.WriteLine("4. View Course List ");
                Console.WriteLine("5. Exit Program");
                Console.WriteLine();
                Console.WriteLine("Please, enter a selection");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": AddCourse(); break;
                    case "2": EditCourse(); break;
                    case "3": RemoveCourse(); break;
                    case "4": DisplayCourses(); ReturnToMain(); break;
                    case "5": ExitManager(); break;
                }
            }

            void AddCourse()
            {
                int newId;

                Console.Clear();
                Console.WriteLine("Creating a new Course");
                Console.WriteLine("------------------------------");

                //DisplayStudents();

                Console.WriteLine();
                Console.WriteLine("Enter new Course ID:");
                try
                {
                    newId = Convert.ToInt32(Console.ReadLine());

                    foreach (Course c in courseList)
                        if (c.GetCourseId() == newId)
                        {
                            Console.WriteLine();
                            Console.WriteLine(" Id already in use. Press any key to try again");
                            Console.ReadLine();
                            AddCourse();
                        }

                }
                catch
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid entry, please enter Course ID in integer form");
                    Console.ReadLine();
                    AddCourse();
                }

                Console.WriteLine();
                Console.WriteLine("Enter new Course Title:");
                String newTitle = Console.ReadLine();             

                AddToCourseList(newId, newTitle);
             
            }

            void AddToCourseList(int courseid, String coursetitle)
            {
                Course c = new Course();
                c.SetCourseId(courseid);
                c.SetCourseTitle(coursetitle);

                courseList.Add(c);

                Console.WriteLine();
                Console.WriteLine(c.GetCourseTitle() + " " + " has been added to the course list under ID # " + c.GetCourseId());
                Console.WriteLine();

                ReturnToMain();

            }

            void EditCourse()
            {
                DisplayCourses();

                Console.WriteLine("Enter the ID for the course you wish to edit.");
                int Id = Convert.ToInt32(Console.ReadLine());

                foreach (Course c in courseList)
                    if (c.GetCourseId() == Id)
                    {
                        c.DisplayMenu();
                    }
                    else
                    {
                        Console.WriteLine("ID not Found: please try again.");
                        EditCourse();
                    }

                ReturnToMain();
            }

            void RemoveCourse()
            {
                Console.Clear();
                Console.WriteLine("Course Removal Menu");
                Console.WriteLine("------------------");
                Console.WriteLine();
                Console.WriteLine("There are currently " + courseList.Count + " courses");
                DisplayCourses();

                Console.WriteLine("Choose an ID# to remove: ");
                int id = Convert.ToInt32(Console.ReadLine());

                foreach (Course c in courseList)
                {
                    if (c.GetCourseId() == id)
                    {
                        Console.WriteLine("Preparing to remove: " + c.GetCourseId() + " " + c.GetCourseTitle());
                        Console.WriteLine("WARNING!!! removing a course will result in removal of ALL students from the course.");
                        Console.WriteLine("Are you sure you want to remove this course [Y/N]: ");
                        String response = Console.ReadLine().ToUpper();
                        String affirmative = "Y";
                        String negatory = "N";

                        if (response == affirmative)
                        {
                            courseList.Remove(c);
                            Console.WriteLine();
                            Console.WriteLine("The course associated with ID# " + id + " has been removed.");
                            Console.WriteLine();
                            ReturnToMain();
                        }

                        if (response == negatory)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Operation has been Cancelled");
                            
                            ReturnToMain();                          
                        }
                        else
                        {
                            Console.WriteLine("Response was invalid, please try again.");
                            RemoveCourse();
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Id not Found");
                        Console.WriteLine("Press enter to try again");
                        Console.ReadLine();
                        RemoveCourse();
                    }
                }

                ReturnToMain();

            }

            void DisplayCourses()
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Class Roster");
                Console.WriteLine("------------");

                Console.WriteLine("There are currently " + courseList.Count + " Courses");
                foreach (Course c in courseList)
                {
                    Console.WriteLine(c.toString());
                }

            }

            void ReturnToMain()
            {
                Console.WriteLine();
                Console.WriteLine("Press any key to return to main menu");
                Console.ReadLine();
                DisplayMainMenu();
            }

            void ExitManager()
            {
                Environment.Exit(0);
            }
        }
    }
}
