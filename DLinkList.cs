using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class DLinkList
    {
        private Node wHead;
        private Node nHead;

        public int size
        {
            get;
            private set;
        }

        public DLinkList()
        {
            wHead = null;
            nHead = null;
            size = 0;
        }
    
        public void add(Person p)
        {
            Node wt = new Node(p);
            Node nt = new Node(p);
            Node current = wHead;
            Node prev = null;

            //weight sorting loop
            while (current != null && current.person.Weight < p.Weight)
            {
                prev = current;
                current = current.nextNode;
            }

            if (prev == null)
            {
                wt.nextNode = wHead;
                wHead = wt;
            }
            else
            {
                wt.nextNode = current;
                prev.nextNode = wt;
            }

            //name sorting loop
            current = nHead;
            prev = null;

            while (current != null && String.Compare(current.person.Name, p.Name) < 0)
            {
                prev = current;
                current = current.nextNode;
            }

            if (prev == null)
            {
                nt.nextNode = nHead;
                nHead = nt;
            }
            else
            {
                nt.nextNode = current;
                prev.nextNode = nt;
            }
            
            size++;
        }

        //deletes the first occurence of query in the sorted name list.
        public void delete(String name)
        {
            if (nHead == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            Node current = nHead;
            Node prev = null;
            while (current != null)
            {
                if (current.person.Name.Equals(name))
                {
                    if (current == nHead)
                        nHead = nHead.nextNode;
                    else
                        prev.nextNode = current.nextNode;

                    return;
                }

                prev = current;
                current = current.nextNode;
            }

            if(current == null)
                Console.WriteLine(name + " cannot be found.");
        }

        //deletes the first occurence of the query in the sorted weight list.
        public void delete(int weight)
        {
            if (wHead == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            Node current = wHead;
            Node prev = null;
            while (current != null)
            {
                if (current.person.Weight == weight)
                {
                    if (current == wHead)
                        wHead = wHead.nextNode;
                    else
                        prev.nextNode = current.nextNode;

                    return;
                }

                prev = current;
                current = current.nextNode;
            }

            if (current == null)
                Console.WriteLine(weight + " cannot be found.");
        }

        /*
         * @param int choice - optional parameter that can be inputted 
         * to print out the desired sort category.
         * i.e. choice = 1 - sort by name alphabetically in ascending order
         *      choice = 2 - sort by weight in ascending in order.
         */    

        public void print(int choice = 1)
        {
            Node x;

            if (choice == 1)
            {
                x = nHead;
                Console.WriteLine("People's records are printed sorted by name");
            }
            else if (choice == 2)
            {
                x = wHead;
                Console.WriteLine("People's records are printed sorted by weight");
            }
            else
            {
                Console.WriteLine("Invalid selection");
                return;
            }

             if (x == null)
                Console.WriteLine("List is empty.");
            else
            {
                while (x != null)
                {
                    x.print();
                    x = x.nextNode;
                }
            
               Console.WriteLine();
            }
        }
     
    }
}
