using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {

            DLinkList list = new DLinkList();
            Random r1 = new Random();
            //change size of this object array to 15;
            Person[] people = new Person[15];

            for (int i = 0; i < people.Length; i++)
            {
                int num;
                String name;
                Console.Write("Enter name: ");
                name = Console.ReadLine();
                Console.Write("Enter weight: ");
                int.TryParse(Console.ReadLine(),out num);
                people[i] = new Person(name,num);
            }

            //uncomment this section if you don't want to type in 15 names and weights
       /*     people[0] = new Person("Zeke", 250);
            people[1] = new Person("Abigail", 130);
            people[2] = new Person("Lauren", 118);
            people[3] = new Person("Jeffrey", 185);
            people[4] = new Person("Alex", 120);
            people[5] = new Person("Debby", 140);
            people[6] = new Person("Jessie", 135);
            people[7] = new Person("James", 320);
            people[8] = new Person("Silvia", 160);
            people[9] = new Person("Sam", 210);
            people[10] = new Person("Ella", 140);
            people[11] = new Person("Viktor", 155);
            people[12] = new Person("Bobby", 222);
            people[13] = new Person("Dan",156);
            people[14] = new Person("Charles", 176);
         */   

            foreach (Person person in people)
                list.add(person);

            list.print();
            Console.WriteLine("\n\n");
            list.print(2);

        } 
    }

    /*  Sample output
     * 
    * People's records are printed sorted by name
        Abigail - 130
        Alex - 120
        Bobby - 222
        Charles - 176
        Dan - 156
        Debby - 140
        Ella - 140
        James - 320
        Jeffrey - 185
        Jessie - 135
        Lauren - 118
        Sam - 210
        Silvia - 160
        Viktor - 155
        Zeke - 250

        People's records are printed sorted by weight
        Lauren - 118
        Alex - 120
        Abigail - 130
        Jessie - 135
        Ella - 140
        Debby - 140
        Viktor - 155
        Dan - 156
        Silvia - 160
        Charles - 176
        Jeffrey - 185
        Sam - 210
        Bobby - 222
        Zeke - 250
        James - 320

        Press any key to continue . . .
            
    * 
    */
}
