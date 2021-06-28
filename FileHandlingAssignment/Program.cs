using System;
using System.IO;



namespace Filehandling
{
    class Program
    {
        static void Main(string[] args)

        {
            //Task 1 :- Creation of directory using Directory info class
            String path = @"C:\STUDENT";
            DirectoryInfo fl = new DirectoryInfo(path);
            fl.Create();
            {
                Console.WriteLine("Directory has been created");
            }

            //Task2 :- Creation of file in directory 
            String Studentsname = "Studentsname.txt";
            String filepath = Path.Combine(path, Studentsname);



            Console.WriteLine("Enter student name");
            Console.WriteLine("Enter Student Roll no");
            StreamWriter sw = new StreamWriter(filepath);
            sw.WriteLine(Console.ReadLine());
            sw.Flush();
            sw.Close();

        }
    }




}