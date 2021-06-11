using System;

namespace Employee
{
    class Employee
    {

        string Name;
        int Salary;

        public void GetEmployeeData()
        {

            Console.WriteLine("Enter the name of employee: ");
            Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the salary of employee: ");
            Salary = Convert.ToInt32(Console.ReadLine());
        }
        public void PrintSalary()
        {
            Console.WriteLine("The name of employee is: " + Name);
            Console.WriteLine("The salary of employee is: " + Salary);

        }

        static void Main(string[] args)
        {
            Employee[] obj = new Employee[3];

            while (true)
            {

                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("1.Add an Employee Record");
                Console.WriteLine("2.Display Employee salary");
                Console.WriteLine("Enter your choice");
                int ch = Int32.Parse(Console.ReadLine());

                switch (ch)
                {

                    case 1:


                        for (int i = 0; i < 10; i++)
                        {
                            obj[i] = new Employee();
                            obj[i].GetEmployeeData();
                        }

                        break;

                    case 2:

                        for (int i = 0; i < 10; i++)
                        {
                            obj[i].PrintSalary();
                        }

                        break;
                }

            }
        }
    }
    
}
