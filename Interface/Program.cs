using System;

namespace Interface
{
    public interface ICollege
    {
        public void PrintDegree();
    }
    public interface ISchool
    {
        public void PrintSSCMarkSheet();
    }
    public class Student : ISchool,ICollege
    {
        public void PrintDegree()
        {
            Console.WriteLine("ICollege Implementation : Degree has printed and handed over");
        }

        public void PrintSSCMarkSheet()
        {
            Console.WriteLine("ISchool Implementation : Degree has printed and handed over");
        }

        class program
        {
            public static void Main(string[] args)
            {
                ISchool school = new Student();
                school.PrintSSCMarkSheet();

                ICollege college = new Student();
                college.PrintDegree();
            }
        }
    }

}
