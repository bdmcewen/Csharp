using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_2
{
    class PassFailCourse
    {
        public PassFailCourse(String courseName, bool grade)
        {
            this.CourseName = courseName;
            this.Grade = grade;
        }

        public string CourseName { get; set; }
        public bool Grade { get; set; }
       

        public bool Passed()
        {
            if (Grade == true)
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
