using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_2
{
    class GradedCourse
    {
        public GradedCourse(String courseName, decimal grade)
        {
            this.CourseName = courseName;
            this.Grade = grade;
        }

        public  string CourseName { get; set; }
        public  decimal Grade { get; set; }
        

        public bool Passed()
        {
            if (Grade >= 70)
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
