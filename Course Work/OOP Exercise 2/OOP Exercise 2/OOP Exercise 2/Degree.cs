using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_2
{
    class Degree
    {
        public Degree(PassFailCourse pfcoursea, PassFailCourse pfcourseb, GradedCourse gradedcoursea, GradedCourse gradedcourseb)
        {
            this.PFCourseA = pfcoursea;
            this.PFCourseB = pfcourseb;
            this.GradedCourseA = gradedcoursea;
            this.GradedCourseB = gradedcourseb;

        }
        public PassFailCourse PFCourseA { get; set; }
        public PassFailCourse PFCourseB { get; set; }
        public GradedCourse GradedCourseA { get; set; }
        public GradedCourse GradedCourseB { get; set; }


        public bool Passed()
        {
            int count = 0;

            if (PFCourseA.Passed() == true)
            {
                count++;
            }
            if (PFCourseB.Passed() == true)
            {
                count++;
            }
            if (GradedCourseA.Passed() == true)
            {
                count++;
            }
            if (GradedCourseB.Passed() == true)
            {
                count++;
            }


            if (count >= 3)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
