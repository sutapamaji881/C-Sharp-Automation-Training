using System;
using System.Collections.Generic;

namespace ListAssignment
{
    class Program
    {
        List<string> cityNames = new List<string>();

        public void addCity()
        {
            
            cityNames.Add("Bangalore");
            cityNames.Add("Chennai");
            cityNames.Add("Delhi");
            cityNames.Add("Mumbai");
            for (int i = 0; i < cityNames.Count; i++)
                Console.WriteLine("Initial List : " + cityNames[i]);
        }
        public void addAndRemoveItem()
        {
            cityNames.Remove("Bangalore");
            cityNames.Add("Hyderabad");
            for (int i = 0; i < cityNames.Count; i++)
                Console.WriteLine("Updated List : " + cityNames[i]);
        }

        public void replaceItem()
        {
            for (int i = 0; i < cityNames.Count; i++)
            {
                if (cityNames[i].Equals("Chennai")){

                    cityNames[i]="Pune";
                }
            }

            for (int i = 0; i < cityNames.Count; i++)
                Console.WriteLine("Replaced List : " + cityNames[i]);
        }

        public void sizeOfTheList()
        {
            int length = cityNames.Count;
            Console.WriteLine("Size of the list : " + length);
        }

        public void listContains()
        {
            for (int i = 0; i < cityNames.Count; i++)
            {
                if (cityNames[i].Equals("Bangalore"))
                {

                    Console.WriteLine("True");
                }
            }

        }

        static void Main(string[] args)
        {

            Program obj = new Program();
            obj.addCity();
            obj.addAndRemoveItem();
            obj.replaceItem();
            obj.sizeOfTheList();
            obj.listContains();

        }
    }
}
