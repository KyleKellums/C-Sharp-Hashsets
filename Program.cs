using System;
using System.Collections.Generic;
using System.Linq;

namespace HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> Showroom = new HashSet<string>
            {
                "M5", "Range Rover", "R8", "911", "911"
            };
            // Print out how many cars in showroom
            // Console.WriteLine(Showroom.Count);
            
            // Print out the list of cars
            // Showroom.ToList<String>().ForEach(x => Console.WriteLine(x));

            HashSet<string> UsedLot = new HashSet<string>
            {
                "Golf", "Dart"
            };

            Showroom.UnionWith(UsedLot);
            // Showroom.ToList<String>().ForEach(x => Console.WriteLine(x));

            Showroom.Remove("Dart");

            HashSet<string> Junkyard = new HashSet<string>
            {
                "911", "Spider", "Ram", "Navigator", "M5", "Explorer", "Avenger", "Wrangler"
            };

            Showroom.IntersectWith(Junkyard);
            foreach (string car in Showroom) 
            {
                // Console.WriteLine(car);
            }

            Showroom.UnionWith(Junkyard);
            foreach (string all in Showroom)
            {
                // Console.WriteLine(all);
            }

            Showroom.Remove("Spider");
            foreach (string x in Showroom)
            {
                Console.WriteLine(x);
            }
        }
    }
}


// Use the Remove() method to remove any cars that you acquired from the junkyard that you do not want in your showroom.

