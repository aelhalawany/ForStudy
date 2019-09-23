using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForStudy
{
    public class Person
    {
        public Person(string firstName, string lastName)
        {
            fname = firstName;
            lname = lastName;
        }

        private string fname;
        private string lname;

        private int x = 1;
        private int y = 2;
        public int Sum { get; set; }

        //public override string ToString() => $"{fname} {lname}".Trim();
        public void DisplayName() => Console.WriteLine($"{fname} {lname}".Trim());
        public int MakeSum() => Sum = x + y;

        protected int protectedProperty { get; set;
        }
        private List<string> messages = new List<string>
        {
            "Page not Found",
            "Page moved, but left a forwarding address.",
            "The web server can't come out to play today."
        };
        private int PrivatePropert{get;set;}

        private Dictionary<int, string> webErrors = new Dictionary<int, string>
        {
            [404] = "Page not Found",
            [302] = "Page moved, but left a forwarding address.",
            [500] = "The web server can't come out to play today."
        };
        
    }
}
