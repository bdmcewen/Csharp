using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_6
{
    class Member
    {
        //changed Member name to private to prevent acess from outside of class.
        private string Name { get; set; }
        public Checking_Account Checking = new Checking_Account();
        public Saving_Account Saving = new Saving_Account();
        
        

        public Member(String name)
        {
            this.Name = name;
        }

        public Member()
        {
            this.Name = "Generic Name Here";
            this.Checking.GetType();
            this.Saving.GetType();

        }

        public string GetName()
        {
            return this.Name;
        }
    }
}
