using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_3
{
    class Student
    {
        public Student(string firstname, string lastname, decimal grade)
        {
            this.FirstName = firstname;
            this.Lastname = lastname;
            this.Grade = grade;
        }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public Decimal Grade { get; set; }
  
    }
}
