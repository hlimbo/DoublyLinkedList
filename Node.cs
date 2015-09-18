using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class Node
    {
        public Person person
        {
            get;
            private set;
        }

        public Node nextNode
        {
            get;
            set;
        }

        public Node(Person p)
        {
            person = p;
            nextNode = null;
        }

        public Boolean isEmpty()
        {
            return this == null;
        }

        public void print()
        {
            Console.WriteLine(person.Name + " - " + person.Weight);
        }
    }
}
