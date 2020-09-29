using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            PassFailCourse PFCourseB = new PassFailCourse("CS100", true);
            PassFailCourse PFCourseA = new PassFailCourse("CS200", false);
            GradedCourse GCourseA = new GradedCourse("CIS100", 86.51M);
            GradedCourse GCourseB = new GradedCourse("CIS200", 69.35M);

            Degree SE = new Degree(PFCourseA, PFCourseB, GCourseA, GCourseB);

            if (SE.Passed() == true)
            {
                Console.WriteLine("Congratulations!");
                Console.Read();
            }
            else
            {
                Console.WriteLine("Would you like fries with that?");
                Console.Read();
            }


        }
    }
}

   