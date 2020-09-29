using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exercise_11
{
    class Student: Person, IName // Inherits from superclass and interface
    {
        //PROPERTIES
        private int StudentId { get; set; }


        //CONSTRUCTORS
        
        public Student(int studentid, string lastname, string firstname, decimal grade)
        {
            this.StudentId = studentid;

        }

        public Student()
        {
            this.StudentId = 100001;

        }
            
        //METHODS

        //get methods

        //allows read access to Student ID
        public int GetStudentId()
        {
            return this.StudentId;
        }

        //allows read access to Student Last Name
        public string GetLastName()
        {
            return this.GetLastName();
        }


        //set methods

        //allows write acess to the students ID to a six digit integer
        public void SetStudentId(int studentid)
        {
            try
            {
                // encapsulation
                if(studentid >= 100000 && studentid <= 999999)
                {
                    this.StudentId = studentid;
                }
            }
            catch
            {
                Console.WriteLine("Student ID must be a six digit integer.");
            }
            
        }

        //allows write acess to the student last name
        public void SetLastName(string lastname)
        {
            try
            {
                this.SetLastName( lastname);
            }
            catch
            {
                Console.WriteLine("Please enter letters only. Numbers are not allowed.");
            }
            
        }

        //allows write acess to the students first name.
        public void SetFirstName(string firstname)
        {
            try
            {
                this.SetFirstName(firstname);
            }
            catch
            {
                Console.WriteLine("Please enter letters only. Numbers are not allowed.");
            }
        }

        //allows write acess to the students grade  and requires values between 0 and 1.
        public void SetGrade(decimal grade)
        {
            try
            {
                if(grade >=0.00M && grade<= 1.00M)
                this.SetGrade(grade);
            }
            catch
            {
                Console.WriteLine("Please enter a decimal value between 0.00 and 1.00 only.");
            }
        }

        //polymorphism
        public override String toString() 
        {         
            String s = "";
            s += this.StudentId + " " + this.GetFirstName() + " " + this.GetLastName() + " " + this.GetGrade();
            return s;
        }

        
    }
}
