using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileDataAccessDemo
{
    class Person
    {

        public string firstName {  get; set; }
        public string lastName { get; set; }
        public string Url { get; set; }

        public Person (string firstName, string lastName, string url)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.Url = url;
        }

        public override string ToString()
        {
            return ("First Name: " + firstName + ", Last Name: " + lastName + ", URL: " + Url);
        }
    }
}
