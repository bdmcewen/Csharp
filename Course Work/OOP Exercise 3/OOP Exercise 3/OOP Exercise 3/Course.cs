using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_3
{
    class Course
    {
        //List<decimal> Roster = new List<decimal>() 

        public Course(string name, int courseID, List<Student> roster)
        {
            this.Name = name;
            this.CourseID = courseID;
            this.Roster = roster;      
        }

        public string Name { get; set; }
        public int CourseID { get; set; }
        public List<Student> Roster { get; set; }

        /*
       GetAverageGrade
       GetMinGrade
       GetMaxGrade
       GetPercentGrades
       */ 
        public decimal GetAverageGrade()
        {
            decimal avg = 0.0M;
            decimal sum = 0.0M;
            //calculate average grade
            avg = sum / Roster.Count;
            return avg;
        }

        public decimal GetMinGrade()
        {
            decimal min = 100.1M;
            //determines grade with smallest value
            for (int i = 0; i < Roster.Count; i++)
            {
                if (min > Roster[i].Grade)
                {
                    min = Roster[i].Grade;
                    //minStudent = firstName[i] + " " + lastName[i];               
                }
            }
            return min;
        }

        public decimal GetMaxGrade()
        {
            decimal max = -100.1M;
            ////Determines grade with largest value
            
            for (int i = 0; i < Roster.Count; i++)
                if (max < Roster[i].Grade)
                {
                    max = Roster[i].Grade;
                    //maxStudent = firstName[i] + " " + lastName[i];     
                }
            return max;
        }

        public void GetPercentGrades()
        {
            decimal avg = 0.0M;
            decimal min = 100.1M;
            decimal max = -100.1M;
            decimal aCount = 0;
            decimal bCount = 0;
            decimal cCount = 0;
            decimal dCount = 0;
            decimal fCount = 0;
            decimal decagrades = Roster.Count();
            int gradesLength = Roster.Count();

            //sorts by Letter grade

            for (int i = 0; i < Roster.Count; i++)
            {
                if (Roster[i].Grade >= 90)
                {
                    aCount += 1;
                }
                if (Roster[i].Grade < 90 && Roster[i].Grade >= 80)
                {
                    bCount += 1;
                }
                if (Roster[i].Grade < 80 && Roster[i].Grade >= 70)
                {
                    cCount += 1;
                }
                if (Roster[i].Grade < 70 && Roster[i].Grade >= 60)
                {
                    dCount += 1;
                }
                if (Roster[i].Grade < 60)
                {
                    fCount += 1;
                }
                
            }

            /*
            Console.WriteLine("The Class Average is: " + avg);
            Console.WriteLine("The Class Min is: " + min);
            Console.WriteLine("The Class Max is: " + max);
            // Console.WriteLine("The Class Median is: " + median);

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
            
            //ReturnToMain
            */

        }

    }
        
}
