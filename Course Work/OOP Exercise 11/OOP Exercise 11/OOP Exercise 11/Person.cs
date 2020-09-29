using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exercise_11
{
    class Person
    {
        //PROPERTIES
        private int PersonId { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }      
        private decimal Grade { get; set; }

        //CONSTRUCTORS
        
        public Person(int Personid, string lastname, string firstname, decimal grade)
        {
            this.PersonId = Personid;
            this.LastName = lastname;
            this.FirstName = firstname;
            this.Grade = grade;
        }

        public Person()
        {
            this.PersonId = 100001;
            this.LastName = "";
            this.FirstName = "";
            this.Grade = 0.00M;
        }
            
        //METHODS

        //get methods

        //allows read access to Person ID
        public int GetPersonId()
        {
            return this.PersonId;
        }

        //allows read access to Person Last Name
        public string GetLastName()
        {
            return this.LastName;
        }

        //allows read access to Person First Name
        public string GetFirstName()
        {
            return this.FirstName;
        }

        //allows read access to Person Grade
        public decimal GetGrade()
        {
            return this.Grade;
        }

        //set methods

        //allows write acess to the Persons ID to a six digit integer
        public void SetPersonId(int Personid)
        {
            try
            {
                // encapsulation
                if(Personid >= 100000 && Personid <= 999999)
                {
                    this.PersonId = Personid;
                }
            }
            catch
            {
                Console.WriteLine("Person ID must be a six digit integer.");
            }
            
        }

        //allows write acess to the Person last name
        public void SetLastName(string lastname)
        {
            try
            {
                this.LastName = lastname;
            }
            catch
            {
                Console.WriteLine("Please enter letters only. Numbers are not allowed.");
            }
            
        }

        //allows write acess to the Persons first name.
        public void SetFirstName(string firstname)
        {
            try
            {
                this.FirstName = firstname;
            }
            catch
            {
                Console.WriteLine("Please enter letters only. Numbers are not allowed.");
            }
        }

        //allows write acess to the Persons grade  and requires values between 0 and 1.
        public void SetGrade(decimal grade)
        {
            try
            {
                if(grade >=0.00M && grade<= 1.00M)
                this.Grade = grade;
            }
            catch
            {
                Console.WriteLine("Please enter a decimal value between 0.00 and 1.00 only.");
            }
        }

        //polymorphism
        public virtual String toString() 
        {         
            String s = "";
            s += this.PersonId + " " + this.FirstName + " " + this.LastName + " " + this.Grade;
            return s;
        }

        
    }
}
