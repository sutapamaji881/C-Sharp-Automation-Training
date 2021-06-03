using System;
using System.Collections.Generic;

namespace ListExample
{
    class Program
    {

        static void Main(string[] args)
        {
            List<String> users = new List<String>();

            bool anotherUser = true;
            int count=0;
            while (anotherUser)

            {
                Console.WriteLine("Please specify a name.");
                string userName = Console.ReadLine();
               
                users.Add(userName);
                count++;
                if (count == 4) {
                    anotherUser = false;
                }
               

            }
            Console.WriteLine("\nNames of added users:");

            foreach (String u in users)
            {
                Console.WriteLine(u);

            }
            string longest = "";
           
            foreach (string L in users)  
            {

                if (L.Length > longest.Length)
                {
                    longest = L;
                }
            
            }
            Console.Write("\nlongest name in the List" + longest);
        }
    }

   
    }
