using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excersize_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student myself = new Student("Ben", "McEwen", 98.65M);

            Console.WriteLine(myself.FirstName);

            myself.FirstName = "Bob";

            Console.WriteLine(myself.FirstName);


            List<Student> allStudents = new List<Student>
            {
                myself,

                new Student("John", "Smith", 86.65M),
                new Student("Jane", "Doe", 68.65M)
            };

            decimal average;
            decimal sum = 0;

            foreach (Student file in allStudents)
            {
                Console.WriteLine("{0} {1} {2}",
                    file.FirstName,
                    file.Lastname,
                    file.Grade);

                sum += (file.Grade);
            }
            average = sum / (allStudents.Count);

            Console.WriteLine("The average grade is: " + average);
            Console.ReadLine();
        }
    }
    class Student
    {
        public Student(string firstname, string lastname, decimal grade)
        {
            this.FirstName = firstname;
            this.Lastname = lastname;
            this.Grade = grade;
        }
        public string FirstName { get; set; }
        public string Lastname  { get; set; }
        public Decimal Grade { get; set; }
    }
}
