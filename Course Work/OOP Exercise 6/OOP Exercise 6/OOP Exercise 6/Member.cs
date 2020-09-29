using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_6
{
    class Member
    {
        public string Name { get; set; }
        public Account Checking = new Account("Checking");
        public Account Saving = new Account("Saving");

        public Member(String name)
        {
            this.Name = name;
        }

        public Member()
        {
            this.Name = "Generic Name Here";
            this.Checking.Type = "Checking";
            this.Saving.Type = "Saving";

        }
    }
}
