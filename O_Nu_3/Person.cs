using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_Nu_3
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Person other = (Person)obj;
            return FirstName == other.FirstName &&
                   LastName == other.LastName &&
                   Age == other.Age;
        }

 
        public override int GetHashCode()
        {
            
            return FirstName.GetHashCode() ^ LastName.GetHashCode() ^ Age.GetHashCode();
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, Age: {Age}";

        }
    }

}
