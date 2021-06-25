using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQAssigment
{
    class LINQAssigment
    {
        List<String> cityNames = new List<string>();

        public void GetFirstValidValue()
        {
            cityNames.Add("Bangalore");
            cityNames.Add("Chennai");
            cityNames.Add("Bangalore1");
            cityNames.Add("Mumbai");

            var result = cityNames.FirstOrDefault(myCity => myCity.Contains("Bangalore"));
            Console.WriteLine(result);

        }

        public void GetValidCount()
        {
            var count = cityNames.Count();
            Console.WriteLine(count);
        }
        static void Main(string[] args)
        {
            LINQAssigment obj = new LINQAssigment();
            obj.GetFirstValidValue();
            obj.GetValidCount();
            
        }
    }
}
