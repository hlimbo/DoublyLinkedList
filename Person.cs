using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class Person
    {

        public String Name
        {
            get;
            private set;
        }

        public int Weight
        {
            get;
            private set;
        }
        
        
        public Person(String name, int weight)
        {
            Name = String.Copy(name);
            Weight = weight;
        }
    }
}
