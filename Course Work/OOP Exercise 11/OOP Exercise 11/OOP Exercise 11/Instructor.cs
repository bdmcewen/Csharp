using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exercise_11
{
    class Instructor : Person // Inherits from superclass and interface
    {
        //PROPERTIES
        private int InstructorId { get; set; }


        //CONSTRUCTORS
        
        public Instructor(int Instructorid, string lastname, string firstname, decimal grade)
        {
            this.InstructorId = Instructorid;

        }

        public Instructor()
        {

        }
            
        //METHODS

        //get methods

        //allows read access to Instructor ID
        public int GetInstructorId()
        {
            return this.InstructorId;
        }


        //set methods

        //allows write acess to the Instructors ID to a six digit integer
        public void SetInstructorId(int Instructorid)
        {
            try
            {
                // encapsulation
                if(Instructorid >= 100000 && Instructorid <= 999999)
                {
                    this.InstructorId = Instructorid;
                }
            }
            catch
            {
                Console.WriteLine("Instructor ID must be a six digit integer.");
            }
            
        }




        //polymorphism
        public override String toString()
        {         
            String s = "";
            s += this.InstructorId + " " + this.GetFirstName() + " " + this.GetLastName();
            return s;
        }

        
    }
}
