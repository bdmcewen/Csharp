﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Grades_Manager_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //defines and populates list with generic data 
            List<string> firstName = new List<string>() { "Mistie", "Mee", "Camelia", "Shanel", "Danny", "Ha", "Dion", "Sergio", "Ivory", "Erminia" };
            List<string> lastName = new List<string>() { "Hinton", "Galvan", "Hebert", "Jacobs", "Wang", "Yates", "Mendoza", "Francis", "Maddox", "Livingston" };
            List<decimal> studentGrade = new List<decimal>() { 98.67M, 94.23M, 85.43M, 79.43M, 75.43M, 73.43M, 76.93M, 64.43M, 68.61M, 55.83M };


            DisplayMenu();

            void DisplayMenu()
            {
                Console.WriteLine();
                Console.WriteLine("Student Grades Manager");
                Console.WriteLine("----------------------");
                Console.WriteLine();

                Console.WriteLine("1. Add New Student");
                //Console.WriteLine("2. Edit Student's Grade");
               // Console.WriteLine("3. Remove a Student");
                Console.WriteLine("4. View Course Analytics");
                Console.WriteLine("5. Exit ");
                Console.WriteLine("6. View Class Roster");
                Console.WriteLine();
                Console.WriteLine("Please, enter a selection");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": AddStudents(); break;
                    //case "2": EditStudents(); break;
                    //case "3": RemoveStudents(); break;
                    case "4": DisplayAnalytics(); break;
                    case "5": ExitApplication(); break;
                    case "6": DisplayStudents(); ReturnToMain(); break;
                }
            }

            void AddStudents()
            {
                Console.Clear();
                Console.WriteLine("Creating a new Student Profile");
                Console.WriteLine("------------------------------");

                /*
                Console.WriteLine("Enter students ID:");
                int Id = Convert.ToInt16(Console.ReadLine());//TODO Create for loop to prvent duplicate ID#s
                studentId.Add(Id);
                */
            

                Console.WriteLine("Enter students first name:");
                string fName = Console.ReadLine();
                firstName.Add(fName);

                Console.WriteLine("Enter students last name:");
                string lName = Console.ReadLine();
                lastName.Add(lName);

                Console.WriteLine("Enter students grade:");
                decimal newGrade = Convert.ToDecimal(Console.ReadLine());
                studentGrade.Add(newGrade);

                Console.WriteLine();
                Console.Write(fName + " " + lName + " has been added to the roster");
                Console.WriteLine();

                ReturnToMain();

            }

            void DisplayAnalytics()
            {
                string minStudent = "";
                string maxStudent = "";

                decimal avg = 0.0M;
                decimal sum = 0.0M;
                decimal min = 100.1M;
                decimal max = -100.1M;
                decimal median = 0.0M;
                decimal aCount = 0;
                decimal bCount = 0;
                decimal cCount = 0;
                decimal dCount = 0;
                decimal fCount = 0;
                decimal decagrades = studentGrade.Count();
                int gradesLength = studentGrade.Count();

                for (int i = 0; i < studentGrade.Count; i++)
                {
                    sum += studentGrade[i];

                    ////determines grade with largest value
                    if (max < studentGrade[i])
                    {
                        max = studentGrade[i];
                        maxStudent = firstName[i] + " " + lastName[i];
                    }


                    //determines grade with smallest value
                    if (min > studentGrade[i])
                    {
                        min = studentGrade[i];
                        minStudent = firstName[i] + " " + lastName[i];
                    }

                }

                // sorts list
                studentGrade.Sort();

                //calculate average grade
                avg = sum / studentGrade.Count;

                //calculates median
                if (gradesLength % 2 == 0)
                {
                    median = ((studentGrade[(gradesLength / 2)] + studentGrade[(gradesLength / 2) - 1]) / 2);
                }

                else
                {
                    median = (studentGrade[(gradesLength - 1) / 2]);
                }

                //sorts by Letter grade
                for (int i = 0; i < studentGrade.Count(); i++)
                {
                    if (studentGrade[i] >= 90)
                    {
                        aCount += 1;
                    }
                    if (studentGrade[i] < 90 && studentGrade[i] >= 80)
                    {
                        bCount += 1;
                    }
                    if (studentGrade[i] < 80 && studentGrade[i] >= 70)
                    {
                        cCount += 1;
                    }
                    if (studentGrade[i] < 70 && studentGrade[i] >= 60)
                    {
                        dCount += 1;
                    }
                    if (studentGrade[i] < 60)
                    {
                        fCount += 1;
                    }
                }
                //Console.WriteLine("The Class Average is: " + avg);
                Console.WriteLine("The Class Average is: " + Math.Round(avg, 2));

                /*
                Console.WriteLine("The Class Min is: " + min + " the students name is " + minStudent);
                Console.WriteLine("The Class Max is: " + max + " the students name is " + maxStudent);
                Console.WriteLine("The Class Median is: " + median);

                //below print lines for testing purposes
                
                Console.WriteLine("The # of As is: " + aCount);
                Console.WriteLine("The # of Bs is: " + bCount);
                Console.WriteLine("The # of Cs is: " + cCount);
                Console.WriteLine("The # of Ds is: " + dCount);
                Console.WriteLine("The # of Fs is: " + fCount);

                Console.WriteLine("There are " + studentGrade.Count() + " grades"); 
                

                Console.WriteLine("The percentage of As is: " + (aCount / decagrades) * 100 + "%");
                Console.WriteLine("The percentage of Bs is: " + (bCount / decagrades) * 100 + "%");
                Console.WriteLine("The percentage of Cs is: " + (cCount / decagrades) * 100 + "%");
                Console.WriteLine("The percentage of Ds is: " + (dCount / decagrades) * 100 + "%");
                Console.WriteLine("The percentage of Fs is: " + (fCount / decagrades) * 100 + "%");
                */

                ReturnToMain();
            }

            void ExitApplication()
            {
                Environment.Exit(0);
            }

            void DisplayStudents()
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Class Roster");
                Console.WriteLine("------------");

                Console.WriteLine("There are currently " + studentGrade.Count + " Students in your roster");
                for (int i = 0; i < (studentGrade.Count); i++)
                {

                    
                    Console.WriteLine(firstName[i] + " " + lastName[i] + " " + studentGrade[i]);

                }

            }

            void ReturnToMain()
            {
                Console.WriteLine();
                Console.WriteLine("Press any key to return to main menu");
                Console.ReadLine();
                Console.Clear();
                DisplayMenu();
            }
        }
    }
}
