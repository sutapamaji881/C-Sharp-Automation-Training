using System;

namespace StringExample
{
    class Program
    {

        string name = "sutapa maji";
        public void upperCase()
        {
            
            string ucaseAuthor = name.ToUpper();
            Console.WriteLine($"Uppercase: {ucaseAuthor}");

        }

        public void inputFnameLname()
        {
            Console.WriteLine("Enter your First Name");
            String FirstName = Console.ReadLine();

            Console.WriteLine("Enter your Last Name");
            String LastName = Console.ReadLine();

            Console.WriteLine("User Input : {0} {1} ", FirstName, LastName);
        }

        public void concatenateFnameLname()
        {
            var names = name.Split(' ');
            string firstName = names[0];
            string lastName = names[1];

            Console.WriteLine("concatenate First name and Last name: " + firstName + lastName);
        }

        public static void Main(string[] args)
        {
            Program obj = new Program();
            obj.upperCase();
            obj.inputFnameLname();
            obj.concatenateFnameLname();
        }
    }
}
